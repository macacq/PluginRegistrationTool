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
	/// Filter that defines which SDK messages are valid for each type of entity.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagefilter")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SdkMessageFilter : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Availability = "availability";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CustomizationLevel = "customizationlevel";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomProcessingStepAllowed = "iscustomprocessingstepallowed";
			public const string IsManaged = "ismanaged";
			public const string IsVisible = "isvisible";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
			public const string RestrictionLevel = "restrictionlevel";
			public const string SdkMessageFilterId = "sdkmessagefilterid";
			public const string Id = "sdkmessagefilterid";
			public const string SdkMessageFilterIdUnique = "sdkmessagefilteridunique";
			public const string SdkMessageId = "sdkmessageid";
			public const string SecondaryObjectTypeCode = "secondaryobjecttypecode";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";
			public const string createdby_sdkmessagefilter = "createdby_sdkmessagefilter";
			public const string lk_sdkmessagefilter_createdonbehalfby = "lk_sdkmessagefilter_createdonbehalfby";
			public const string lk_sdkmessagefilter_modifiedonbehalfby = "lk_sdkmessagefilter_modifiedonbehalfby";
			public const string modifiedby_sdkmessagefilter = "modifiedby_sdkmessagefilter";
			public const string organization_sdkmessagefilter = "organization_sdkmessagefilter";
			public const string sdkmessageid_sdkmessagefilter = "sdkmessageid_sdkmessagefilter";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageFilter() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagefilter";
		
		public const string PrimaryIdAttribute = "sdkmessagefilterid";
		
		public const int EntityTypeCode = 4607;
		
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
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("availability");
			}
			set
			{
				this.OnPropertyChanging("Availability");
				this.SetAttributeValue("availability", value);
				this.OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// Unique identifier of the user who created the SDK message filter.
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
		/// Date and time when the SDK message filter was created.
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
		/// Unique identifier of the delegate user who created the sdkmessagefilter.
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
		/// Customization level of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Version in which the component is introduced.
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
		/// Indicates whether a custom SDK message processing step is allowed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomprocessingstepallowed")]
		public System.Nullable<bool> IsCustomProcessingStepAllowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscustomprocessingstepallowed");
			}
			set
			{
				this.OnPropertyChanging("IsCustomProcessingStepAllowed");
				this.SetAttributeValue("iscustomprocessingstepallowed", value);
				this.OnPropertyChanged("IsCustomProcessingStepAllowed");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
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
		/// Indicates whether the filter should be visible.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
		public System.Nullable<bool> IsVisible
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvisible");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message filter.
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
		/// Date and time when the SDK message filter was last modified.
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
		/// Unique identifier of the delegate user who last modified the sdkmessagefilter.
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
		/// Unique identifier of the organization with which the SDK message filter is associated.
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
		/// For internal use only.
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
		/// Type of entity with which the SDK message filter is primarily associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("primaryobjecttypecode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("restrictionlevel")]
		public System.Nullable<int> RestrictionLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("restrictionlevel");
			}
			set
			{
				this.OnPropertyChanging("RestrictionLevel");
				this.SetAttributeValue("restrictionlevel", value);
				this.OnPropertyChanged("RestrictionLevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public System.Nullable<System.Guid> SdkMessageFilterId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilterid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageFilterId");
				this.SetAttributeValue("sdkmessagefilterid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageFilterId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageFilterId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilteridunique")]
		public System.Nullable<System.Guid> SdkMessageFilterIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilteridunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the related SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageId");
				this.SetAttributeValue("sdkmessageid", value);
				this.OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK message filter is secondarily associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondaryobjecttypecode")]
		public string SecondaryObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("secondaryobjecttypecode");
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
		/// Whether or not the SDK message can be called from a workflow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsdkstepenabled")]
		public System.Nullable<bool> WorkflowSdkStepEnabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("workflowsdkstepenabled");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagefilter")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sdkmessagefilter", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_sdkmessagefilter");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sdkmessagefilter", null, value);
				this.OnPropertyChanged("userentityinstancedata_sdkmessagefilter");
			}
		}
		
		/// <summary>
		/// N:1 createdby_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagefilter")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser createdby_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdby_sdkmessagefilter", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessagefilter_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sdkmessagefilter_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessagefilter_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sdkmessagefilter_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessagefilter_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessagefilter_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessagefilter_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sdkmessagefilter_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessagefilter_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sdkmessagefilter_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessagefilter_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessagefilter_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagefilter")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser modifiedby_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedby_sdkmessagefilter", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagefilter")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_sdkmessagefilter", null);
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public Xrm.Sdk.PluginRegistration.Entities.SdkMessage sdkmessageid_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SdkMessage>("sdkmessageid_sdkmessagefilter", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SdkMessage>("sdkmessageid_sdkmessagefilter", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SdkMessageFilter(object anonymousType) : 
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
                        Attributes["sdkmessagefilterid"] = base.Id;
                        break;
                    case "sdkmessagefilterid":
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