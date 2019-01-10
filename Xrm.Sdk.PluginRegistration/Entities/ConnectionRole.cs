//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xrm.Sdk.PluginRegistration.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum ConnectionRoleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Role describing a relationship between a two records.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("connectionrole")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ConnectionRole : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Category = "category";
			public const string ComponentState = "componentstate";
			public const string ConnectionRoleId = "connectionroleid";
			public const string Id = "connectionroleid";
			public const string ConnectionRoleIdUnique = "connectionroleidunique";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string VersionNumber = "versionnumber";
			public const string createdby_connection_role = "createdby_connection_role";
			public const string lk_connectionrolebase_createdonbehalfby = "lk_connectionrolebase_createdonbehalfby";
			public const string lk_connectionrolebase_modifiedonbehalfby = "lk_connectionrolebase_modifiedonbehalfby";
			public const string modifiedby_connection_role = "modifiedby_connection_role";
			public const string organization_connection_roles = "organization_connection_roles";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ConnectionRole() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "connectionrole";
		
		public const string PrimaryIdAttribute = "connectionroleid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 3231;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Categories for connection roles.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public Microsoft.Xrm.Sdk.OptionSetValue Category
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("category");
			}
			set
			{
				this.OnPropertyChanging("Category");
				this.SetAttributeValue("category", value);
				this.OnPropertyChanged("Category");
			}
		}
		
		/// <summary>
		/// State of the component.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
		public System.Nullable<System.Guid> ConnectionRoleId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleid");
			}
			set
			{
				this.OnPropertyChanging("ConnectionRoleId");
				this.SetAttributeValue("connectionroleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ConnectionRoleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ConnectionRoleId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the published or unpublished connection role record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleidunique")]
		public System.Nullable<System.Guid> ConnectionRoleIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the relationship role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the connection role was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the relationship role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Description of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the connection role was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the relationship role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization that this connection role belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time when the record was last overwritten.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Status of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Version number of the connection role.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N Connection_Role_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_Role_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> Connection_Role_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("Connection_Role_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("Connection_Role_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("Connection_Role_AsyncOperations", null, value);
				this.OnPropertyChanged("Connection_Role_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N connection_role_connection_role_object_type_codes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connection_role_object_type_codes")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleObjectTypeCode> connection_role_connection_role_object_type_codes
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleObjectTypeCode>("connection_role_connection_role_object_type_codes", null);
			}
			set
			{
				this.OnPropertyChanging("connection_role_connection_role_object_type_codes");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRoleObjectTypeCode>("connection_role_connection_role_object_type_codes", null, value);
				this.OnPropertyChanged("connection_role_connection_role_object_type_codes");
			}
		}
		
		/// <summary>
		/// 1:N connection_role_connections1
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connections1")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Connection> connection_role_connections1
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("connection_role_connections1", null);
			}
			set
			{
				this.OnPropertyChanging("connection_role_connections1");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("connection_role_connections1", null, value);
				this.OnPropertyChanged("connection_role_connections1");
			}
		}
		
		/// <summary>
		/// 1:N connection_role_connections2
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connections2")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Connection> connection_role_connections2
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("connection_role_connections2", null);
			}
			set
			{
				this.OnPropertyChanging("connection_role_connections2");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("connection_role_connections2", null, value);
				this.OnPropertyChanged("connection_role_connections2");
			}
		}
		
		/// <summary>
		/// 1:N ConnectionRole_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConnectionRole_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> ConnectionRole_ProcessSessions
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ConnectionRole_ProcessSessions", null);
			}
			set
			{
				this.OnPropertyChanging("ConnectionRole_ProcessSessions");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ConnectionRole_ProcessSessions", null, value);
				this.OnPropertyChanged("ConnectionRole_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N ConnectionRole_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConnectionRole_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> ConnectionRole_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ConnectionRole_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("ConnectionRole_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ConnectionRole_SyncErrors", null, value);
				this.OnPropertyChanged("ConnectionRole_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_connectionrole
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionrole")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_connectionrole
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_connectionrole", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_connectionrole");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_connectionrole", null, value);
				this.OnPropertyChanged("userentityinstancedata_connectionrole");
			}
		}
		
		/// <summary>
		/// N:N connectionroleassociation_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole> Referencingconnectionroleassociation_association
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole>("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingconnectionroleassociation_association");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole>("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingconnectionroleassociation_association");
			}
		}
		
		/// <summary>
		/// N:N connectionroleassociation_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole> Referencedconnectionroleassociation_association
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole>("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedconnectionroleassociation_association");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ConnectionRole>("connectionroleassociation_association", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedconnectionroleassociation_association");
			}
		}
		
		/// <summary>
		/// N:1 createdby_connection_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection_role")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser createdby_connection_role
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdby_connection_role", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_connectionrolebase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_connectionrolebase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_connectionrolebase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_connectionrolebase_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_connectionrolebase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_connectionrolebase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_connectionrolebase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_connectionrolebase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_connectionrolebase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_connectionrolebase_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_connectionrolebase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_connectionrolebase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_connection_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection_role")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser modifiedby_connection_role
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedby_connection_role", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_connection_roles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_connection_roles")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_connection_roles
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_connection_roles", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public ConnectionRole(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["connectionroleid"] = base.Id;
                        break;
                    case "connectionroleid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
		public virtual connectionrole_category? CategoryEnum
		{
			get
			{
				return ((connectionrole_category?)(EntityOptionSetEnum.GetEnum(this, "category")));
			}
			set
			{
				Category = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual componentstate? ComponentStateEnum
		{
			get
			{
				return ((componentstate?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual connectionrole_statuscode? StatusCodeEnum
		{
			get
			{
				return ((connectionrole_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}