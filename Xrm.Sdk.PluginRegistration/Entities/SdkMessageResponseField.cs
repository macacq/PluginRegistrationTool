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
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageresponsefield")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SdkMessageResponseField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClrFormatter = "clrformatter";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CustomizationLevel = "customizationlevel";
			public const string Formatter = "formatter";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ParameterBindingInformation = "parameterbindinginformation";
			public const string Position = "position";
			public const string PublicName = "publicname";
			public const string SdkMessageResponseFieldId = "sdkmessageresponsefieldid";
			public const string Id = "sdkmessageresponsefieldid";
			public const string SdkMessageResponseFieldIdUnique = "sdkmessageresponsefieldidunique";
			public const string SdkMessageResponseId = "sdkmessageresponseid";
			public const string SolutionId = "solutionid";
			public const string Value = "value";
			public const string VersionNumber = "versionnumber";
			public const string createdby_sdkmessageresponsefield = "createdby_sdkmessageresponsefield";
			public const string lk_sdkmessageresponsefield_createdonbehalfby = "lk_sdkmessageresponsefield_createdonbehalfby";
			public const string lk_sdkmessageresponsefield_modifiedonbehalfby = "lk_sdkmessageresponsefield_modifiedonbehalfby";
			public const string messageresponse_sdkmessageresponsefield = "messageresponse_sdkmessageresponsefield";
			public const string modifiedby_sdkmessageresponsefield = "modifiedby_sdkmessageresponsefield";
			public const string organization_sdkmessageresponsefield = "organization_sdkmessageresponsefield";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageResponseField() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageresponsefield";
		
		public const string PrimaryIdAttribute = "sdkmessageresponsefieldid";
		
		public const int EntityTypeCode = 4611;
		
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
		/// Common language runtime (CLR)-based formatter of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clrformatter")]
		public string ClrFormatter
		{
			get
			{
				return this.GetAttributeValue<string>("clrformatter");
			}
			set
			{
				this.OnPropertyChanging("ClrFormatter");
				this.SetAttributeValue("clrformatter", value);
				this.OnPropertyChanged("ClrFormatter");
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
		/// Unique identifier of the user who created the SDK message response field.
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
		/// Date and time when the SDK message response field was created.
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
		/// Unique identifier of the delegate user who created the sdkmessageresponsefield.
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
		/// Customization level of the SDK message response field.
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
		/// Formatter for the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formatter")]
		public string Formatter
		{
			get
			{
				return this.GetAttributeValue<string>("formatter");
			}
			set
			{
				this.OnPropertyChanging("Formatter");
				this.SetAttributeValue("formatter", value);
				this.OnPropertyChanged("Formatter");
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
		/// Unique identifier of the user who last modified the SDK message response field.
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
		/// Date and time when the SDK message response field was last modified.
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
		/// Unique identifier of the delegate user who last modified the sdkmessageresponsefield.
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
		/// Name of the SDK message response field.
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
		/// Unique identifier of the organization with which the SDK message response field is associated.
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parameterbindinginformation")]
		public string ParameterBindingInformation
		{
			get
			{
				return this.GetAttributeValue<string>("parameterbindinginformation");
			}
			set
			{
				this.OnPropertyChanging("ParameterBindingInformation");
				this.SetAttributeValue("parameterbindinginformation", value);
				this.OnPropertyChanged("ParameterBindingInformation");
			}
		}
		
		/// <summary>
		/// Position of the Sdk message response field
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("position")]
		public System.Nullable<int> Position
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("position");
			}
		}
		
		/// <summary>
		/// Public name of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publicname")]
		public string PublicName
		{
			get
			{
				return this.GetAttributeValue<string>("publicname");
			}
			set
			{
				this.OnPropertyChanging("PublicName");
				this.SetAttributeValue("publicname", value);
				this.OnPropertyChanged("PublicName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageResponseFieldId");
				this.SetAttributeValue("sdkmessageresponsefieldid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageResponseFieldId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageResponseFieldId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldidunique")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message response with which the SDK message response field is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageResponseId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageresponseid");
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
		/// Actual value of the SDK message response field.
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
		/// For internal use only.
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
		/// 1:N userentityinstancedata_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageresponsefield")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sdkmessageresponsefield", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_sdkmessageresponsefield");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sdkmessageresponsefield", null, value);
				this.OnPropertyChanged("userentityinstancedata_sdkmessageresponsefield");
			}
		}
		
		/// <summary>
		/// N:1 createdby_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponsefield")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser createdby_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdby_sdkmessageresponsefield", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessageresponsefield_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sdkmessageresponsefield_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessageresponsefield_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sdkmessageresponsefield_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessageresponsefield_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessageresponsefield_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessageresponsefield_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sdkmessageresponsefield_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessageresponsefield_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sdkmessageresponsefield_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sdkmessageresponsefield_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessageresponsefield_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 messageresponse_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
		public Xrm.Sdk.PluginRegistration.Entities.SdkMessageResponse messageresponse_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SdkMessageResponse>("messageresponse_sdkmessageresponsefield", null);
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponsefield")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser modifiedby_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedby_sdkmessageresponsefield", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponsefield")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_sdkmessageresponsefield", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SdkMessageResponseField(object anonymousType) : 
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
                        Attributes["sdkmessageresponsefieldid"] = base.Id;
                        break;
                    case "sdkmessageresponsefieldid":
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