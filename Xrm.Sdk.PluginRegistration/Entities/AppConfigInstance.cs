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
	
	/// <summary>
	/// Contains a property or a list of properties from the app configuration master list that can be customized for any app in Dynamics 365. For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("appconfiginstance")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class AppConfigInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AppConfigId = "appconfigid";
			public const string AppConfigIdUnique = "appconfigidunique";
			public const string AppConfigInstanceId = "appconfiginstanceid";
			public const string Id = "appconfiginstanceid";
			public const string AppConfigInstanceIdUnique = "appconfiginstanceidunique";
			public const string AppConfigMasterId = "appconfigmasterid";
			public const string ComponentState = "componentstate";
			public const string ComponentType = "componenttype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ObjectId = "objectid";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string Value = "value";
			public const string VersionNumber = "versionnumber";
			public const string appconfig_appconfiginstance = "appconfig_appconfiginstance";
			public const string appconfigmaster_appconfiginstance = "appconfigmaster_appconfiginstance";
			public const string lk_appconfiginstance_createdby = "lk_appconfiginstance_createdby";
			public const string lk_appconfiginstance_createdonbehalfby = "lk_appconfiginstance_createdonbehalfby";
			public const string lk_appconfiginstance_modifiedby = "lk_appconfiginstance_modifiedby";
			public const string lk_appconfiginstance_modifiedonbehalfby = "lk_appconfiginstance_modifiedonbehalfby";
			public const string organization_appconfiginstance = "organization_appconfiginstance";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public AppConfigInstance() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "appconfiginstance";
		
		public const string PrimaryIdAttribute = "appconfiginstanceid";
		
		public const int EntityTypeCode = 9013;
		
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
		/// System-calculated App Configuration unique identifier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfigid")]
		public Microsoft.Xrm.Sdk.EntityReference AppConfigId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("appconfigid");
			}
			set
			{
				this.OnPropertyChanging("AppConfigId");
				this.SetAttributeValue("appconfigid", value);
				this.OnPropertyChanged("AppConfigId");
			}
		}
		
		/// <summary>
		/// Enter the App Configuration unique identifier of AppConfig entity for which this customization belongs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfigidunique")]
		public System.Nullable<System.Guid> AppConfigIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("appconfigidunique");
			}
			set
			{
				this.OnPropertyChanging("AppConfigIdUnique");
				this.SetAttributeValue("appconfigidunique", value);
				this.OnPropertyChanged("AppConfigIdUnique");
			}
		}
		
		/// <summary>
		/// System-Populated App Configuration instance identifier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfiginstanceid")]
		public System.Nullable<System.Guid> AppConfigInstanceId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("appconfiginstanceid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfiginstanceid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				base.Id = value;
			}
		}
		
		/// <summary>
		/// System-populated App Configuration Instance unique identifier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfiginstanceidunique")]
		public System.Nullable<System.Guid> AppConfigInstanceIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("appconfiginstanceidunique");
			}
			set
			{
				this.OnPropertyChanging("AppConfigInstanceIdUnique");
				this.SetAttributeValue("appconfiginstanceidunique", value);
				this.OnPropertyChanged("AppConfigInstanceIdUnique");
			}
		}
		
		/// <summary>
		/// System-calculated App Configuration Master identifier.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfigmasterid")]
		public Microsoft.Xrm.Sdk.EntityReference AppConfigMasterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("appconfigmasterid");
			}
			set
			{
				this.OnPropertyChanging("AppConfigMasterId");
				this.SetAttributeValue("appconfigmasterid", value);
				this.OnPropertyChanged("AppConfigMasterId");
			}
		}
		
		/// <summary>
		/// System-Populated Published or UnPublished state of App Configuration Instance.
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
		/// ComponentType
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componenttype")]
		public string ComponentType
		{
			get
			{
				return this.GetAttributeValue<string>("componenttype");
			}
			set
			{
				this.OnPropertyChanging("ComponentType");
				this.SetAttributeValue("componenttype", value);
				this.OnPropertyChanged("ComponentType");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who created the record on behalfÂ of another user.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
		}
		
		/// <summary>
		/// Shows the version in which the App Configuration Instance is introduced.
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
		/// Is Managed
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
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// ObjectId
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public System.Nullable<System.Guid> ObjectId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("objectid");
			}
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// System-calculated field for Organization identifier.
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
		/// Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Shows the last overwrite time for the App Configuration Instance.
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
		/// Set the solution idenfitier for associated solution.
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
		/// Enter a value for the customization property that is valid as per the validator XML specified in the app configuration master record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("value")]
		public string Value
		{
			get
			{
				return this.GetAttributeValue<string>("value");
			}
			set
			{
				this.OnPropertyChanging("Value");
				this.SetAttributeValue("value", value);
				this.OnPropertyChanged("Value");
			}
		}
		
		/// <summary>
		/// 
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
		/// N:1 appconfig_appconfiginstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfigid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appconfig_appconfiginstance")]
		public Xrm.Sdk.PluginRegistration.Entities.AppConfig appconfig_appconfiginstance
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AppConfig>("appconfig_appconfiginstance", null);
			}
			set
			{
				this.OnPropertyChanging("appconfig_appconfiginstance");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AppConfig>("appconfig_appconfiginstance", null, value);
				this.OnPropertyChanged("appconfig_appconfiginstance");
			}
		}
		
		/// <summary>
		/// N:1 appconfigmaster_appconfiginstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appconfigmasterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appconfigmaster_appconfiginstance")]
		public Xrm.Sdk.PluginRegistration.Entities.AppConfigMaster appconfigmaster_appconfiginstance
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AppConfigMaster>("appconfigmaster_appconfiginstance", null);
			}
			set
			{
				this.OnPropertyChanging("appconfigmaster_appconfiginstance");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AppConfigMaster>("appconfigmaster_appconfiginstance", null, value);
				this.OnPropertyChanged("appconfigmaster_appconfiginstance");
			}
		}
		
		/// <summary>
		/// N:1 lk_appconfiginstance_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appconfiginstance_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_appconfiginstance_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_appconfiginstance_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appconfiginstance_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_appconfiginstance_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_appconfiginstance_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_appconfiginstance_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_appconfiginstance_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appconfiginstance_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_appconfiginstance_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_appconfiginstance_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appconfiginstance_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_appconfiginstance_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_appconfiginstance_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_appconfiginstance_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_appconfiginstance_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_appconfiginstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_appconfiginstance")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_appconfiginstance
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_appconfiginstance", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public AppConfigInstance(object anonymousType) : 
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
                        Attributes["appconfiginstanceid"] = base.Id;
                        break;
                    case "appconfiginstanceid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual componentstate? ComponentStateEnum
		{
			get
			{
				return ((componentstate?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
	}
}