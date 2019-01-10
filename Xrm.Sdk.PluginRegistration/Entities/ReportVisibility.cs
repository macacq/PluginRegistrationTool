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
	/// Area in which to show a report. A report can be shown in multiple areas.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("reportvisibility")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ReportVisibility : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string ReportId = "reportid";
			public const string ReportVisibilityId = "reportvisibilityid";
			public const string Id = "reportvisibilityid";
			public const string ReportVisibilityIdUnique = "reportvisibilityidunique";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string VisibilityCode = "visibilitycode";
			public const string lk_reportvisibility_createdonbehalfby = "lk_reportvisibility_createdonbehalfby";
			public const string lk_reportvisibility_modifiedonbehalfby = "lk_reportvisibility_modifiedonbehalfby";
			public const string lk_reportvisibilitybase_createdby = "lk_reportvisibilitybase_createdby";
			public const string lk_reportvisibilitybase_modifiedby = "lk_reportvisibilitybase_modifiedby";
			public const string report_reportvisibility = "report_reportvisibility";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ReportVisibility() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "reportvisibility";
		
		public const string PrimaryIdAttribute = "reportvisibilityid";
		
		public const int EntityTypeCode = 9103;
		
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
		/// Unique identifier of the user who created the report visibility record.
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
		/// Date and time when the report visibility record was created.
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
		/// Unique identifier of the delegate user who created the reportvisibility.
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
		/// 
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
		/// Unique identifier of the user who last modified the report visibility record.
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
		/// Date and time when the report visibility record was last modified.
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
		/// Unique identifier of the delegate user who last modified the reportvisibility.
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
		/// Unique identifier of the user or team who owns the report visibility.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the report visibility record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the report visibility record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public System.Nullable<System.Guid> OwningUser
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
			}
		}
		
		/// <summary>
		/// Unique identifier of the report.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
		public Microsoft.Xrm.Sdk.EntityReference ReportId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("reportid");
			}
			set
			{
				this.OnPropertyChanging("ReportId");
				this.SetAttributeValue("reportid", value);
				this.OnPropertyChanged("ReportId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the report visibility record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportvisibilityid")]
		public System.Nullable<System.Guid> ReportVisibilityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("reportvisibilityid");
			}
			set
			{
				this.OnPropertyChanging("ReportVisibilityId");
				this.SetAttributeValue("reportvisibilityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ReportVisibilityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportvisibilityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ReportVisibilityId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportvisibilityidunique")]
		public System.Nullable<System.Guid> ReportVisibilityIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("reportvisibilityidunique");
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
		/// Type of visibility of the report.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("visibilitycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue VisibilityCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("visibilitycode");
			}
			set
			{
				this.OnPropertyChanging("VisibilityCode");
				this.SetAttributeValue("visibilitycode", value);
				this.OnPropertyChanged("VisibilityCode");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_reportvisibility
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportvisibility")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_reportvisibility
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_reportvisibility", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_reportvisibility");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_reportvisibility", null, value);
				this.OnPropertyChanged("userentityinstancedata_reportvisibility");
			}
		}
		
		/// <summary>
		/// N:1 lk_reportvisibility_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_reportvisibility_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibility_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_reportvisibility_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibility_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_reportvisibility_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_reportvisibility_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_reportvisibility_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibility_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_reportvisibility_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibility_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_reportvisibility_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_reportvisibilitybase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_reportvisibilitybase_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibilitybase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_reportvisibilitybase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_reportvisibilitybase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_reportvisibilitybase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 report_reportvisibility
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportvisibility")]
		public Xrm.Sdk.PluginRegistration.Entities.Report report_reportvisibility
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Report>("report_reportvisibility", null);
			}
			set
			{
				this.OnPropertyChanging("report_reportvisibility");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Report>("report_reportvisibility", null, value);
				this.OnPropertyChanged("report_reportvisibility");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public ReportVisibility(object anonymousType) : 
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
                        Attributes["reportvisibilityid"] = base.Id;
                        break;
                    case "reportvisibilityid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("visibilitycode")]
		public virtual reportvisibility_visibilitycode? VisibilityCodeEnum
		{
			get
			{
				return ((reportvisibility_visibilitycode?)(EntityOptionSetEnum.GetEnum(this, "visibilitycode")));
			}
			set
			{
				VisibilityCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}