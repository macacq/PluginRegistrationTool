// =====================================================================
//
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// =====================================================================

namespace Xrm.Sdk.PluginRegistration
{
    using Helpers;
    using Microsoft.Xrm.Sdk;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Wrappers;

    public sealed class AppDomainContext<T> : IDisposable
        where T : class, new()
    {
        private AppDomain _domain;
        private bool _disposed;

        public AppDomainContext()
            : this("TemporaryDomain")
        {
        }

        public AppDomainContext(string domainName)
        {
            if (string.IsNullOrWhiteSpace(domainName))
            {
                throw new ArgumentNullException("domainName");
            }

            //Create the AppDomain
            var setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            _domain = AppDomain.CreateDomain(domainName, null, setup);

            //Create the proxy in the AppDomain so that all assemblies that are loaded do not stay loaded in the AppDomain
            Proxy = (T)_domain.CreateInstanceFromAndUnwrap(typeof(T).Assembly.Location, typeof(T).FullName);

            //Attach the resolver so that assemblies can be resolved correctly
            AssemblyResolver.AttachResolver(_domain);
        }

        ~AppDomainContext()
        {
            Dispose(false);
        }

        #region Properties

        public T Proxy
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Methods

        #region Private Methods

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (null != _domain)
            {
                AppDomain.Unload(_domain);
                _domain = null;
                Proxy = null;
            }

            if (disposing)
            {
                _disposed = true;
            }
        }

        #endregion Private Methods
    }

    public sealed class AssemblyReader : MarshalByRefObject
    {
        public CrmPluginAssembly RetrieveAssemblyProperties(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            else if (!System.IO.File.Exists(path))
            {
                throw new ArgumentException("Path does not point to an existing file");
            }

            return RetrieveAssemblyProperties(LoadAssembly(path), path);
        }

        public CrmPluginAssembly RetrievePluginsFromAssembly(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            else if (!System.IO.File.Exists(path))
            {
                throw new ArgumentException("Path does not point to an existing file");
            }

            //Load the assembly
            Assembly assembly = LoadAssembly(path);
            AssemblyName assemblyName = assembly.GetName();
            string defaultGroupName = RegistrationHelper.GenerateDefaultGroupName(assemblyName.Name, assemblyName.Version);

            //Retrieve the assembly properties
            CrmPluginAssembly pluginAssembly = RetrieveAssemblyProperties(assembly, path);

            //Loop through each type and process it
            List<string> errorList = new List<string>();
            foreach (Type t in assembly.GetExportedTypes())
            {
                //Plugins and Workflow Activities must be non-abstract classes
                if (t.IsAbstract || !t.IsClass)
                {
                    continue;
                }

                // Plugins must implement the IPlugin interface
                string errorMessage = null;
                CrmPluginType type;
                CrmPluginIsolatable isolatable;

                //Retrieve the two interface types
                Type xrmPlugin = t.GetInterface(typeof(IPlugin).FullName);
                Type v4Plugin = t.GetInterface("Microsoft.Crm.Sdk.IPlugin");

                string workflowGroupName = defaultGroupName;
                string pluginName = t.FullName;

                Version sdkVersion = null;
                if (null != xrmPlugin)
                {
                    type = CrmPluginType.Plugin;
                    isolatable = CrmPluginIsolatable.Yes;
                    sdkVersion = xrmPlugin.Assembly.GetName().Version;
                }
                else if (null != v4Plugin)
                {
                    type = CrmPluginType.Plugin;
                    isolatable = CrmPluginIsolatable.No;

                    //It may be that the version of Microsoft.Crm.Sdk.dll will be the v5 version, but it will still be a v4 plug-in.
                    sdkVersion = new Version(4, 0);
                }
                else if (t.IsSubclassOf(typeof(System.Workflow.ComponentModel.Activity)) || t.IsSubclassOf(typeof(System.Activities.Activity)))
                {
                    //Checking whether the Custom Activity descends from Activity will save time, because it
                    //would most likely fail at run-time since the Workflow engine would not know how to handle the class

                    type = CrmPluginType.WorkflowActivity;
                    isolatable = CrmPluginIsolatable.No;

                    if (t.IsSubclassOf(typeof(System.Workflow.ComponentModel.Activity)))
                    {
                        errorMessage = string.Format("The Custom Workflow Activity {0} class must have the CrmWorkflowActivity attribute set",
                            t.FullName);

                        //Verify that the Workflow attribute is present.
                        foreach (Attribute att in t.GetCustomAttributes(true))
                        {
                            if (att != null && (att.GetType().FullName == "Microsoft.Crm.Workflow.CrmWorkflowActivityAttribute"))
                            {
                                dynamic attribute = att;
                                workflowGroupName = attribute.GroupName;
                                pluginName = attribute.Name;

                                if (string.IsNullOrEmpty(pluginName))
                                {
                                    errorMessage = string.Format("The Custom Workflow Activity {0} class's CrmWorkflowActivity attribute must have the Name property set",
                                        t.FullName);
                                }
                                else
                                {
                                    errorMessage = null;
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }

                //If the SDK version has been set, extract the Major/Minor number
                if (null != sdkVersion)
                {
                    pluginAssembly.SdkVersion = new Version(sdkVersion.Major, sdkVersion.Minor);
                }

                if (errorMessage != null)
                {
                    errorList.Add(errorMessage);
                }
                else
                {
                    CrmPlugin plugin = new CrmPlugin(null);
                    plugin.TypeName = t.FullName;
                    plugin.Name = pluginName;
                    plugin.PluginType = type;
                    plugin.PluginId = Guid.NewGuid();
                    plugin.AssemblyId = pluginAssembly.AssemblyId;
                    plugin.AssemblyName = pluginAssembly.Name;
                    plugin.Isolatable = isolatable;

                    if (type == CrmPluginType.WorkflowActivity && !string.IsNullOrWhiteSpace(workflowGroupName))
                    {
                        plugin.WorkflowActivityGroupName = workflowGroupName;
                    }

                    pluginAssembly.AddPlugin(plugin);
                }
            }

            return pluginAssembly;
        }

        #region Private Helper Methods

        private Assembly LoadAssembly(string path)
        {
            return Assembly.LoadFrom(path);
        }

        private CrmPluginAssembly RetrieveAssemblyProperties(Assembly assembly, string path)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            CrmPluginAssembly pluginAssembly = new CrmPluginAssembly(null);
            pluginAssembly.AssemblyId = Guid.NewGuid();
            pluginAssembly.SourceType = CrmAssemblySourceType.Disk;

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
            pluginAssembly.ServerFileName = fileInfo.Name;

            AssemblyName name = assembly.GetName();
            string cultureLabel;
            if (name.CultureInfo.LCID == System.Globalization.CultureInfo.InvariantCulture.LCID)
            {
                cultureLabel = "neutral";
            }
            else
            {
                cultureLabel = name.CultureInfo.Name;
            }

            pluginAssembly.Name = name.Name;
            pluginAssembly.Version = name.Version.ToString();
            pluginAssembly.Culture = cultureLabel;

            byte[] tokenBytes = name.GetPublicKeyToken();
            if (null == tokenBytes || 0 == tokenBytes.Length)
            {
                pluginAssembly.PublicKeyToken = null;
            }
            else
            {
                pluginAssembly.PublicKeyToken = string.Join(string.Empty, tokenBytes.Select(b => b.ToString("X2")));
            }

            return pluginAssembly;
        }

        #endregion Private Helper Methods
    }
}