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
	/// XML data used to control the application navigation pane.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sitemap")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SiteMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string IsAppAware = "isappaware";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SiteMapId = "sitemapid";
			public const string Id = "sitemapid";
			public const string SiteMapIdUnique = "sitemapidunique";
			public const string SiteMapName = "sitemapname";
			public const string SiteMapNameUnique = "sitemapnameunique";
			public const string SiteMapXml = "sitemapxml";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string lk_SiteMap_createdby = "lk_SiteMap_createdby";
			public const string lk_SiteMap_createdonbehalfby = "lk_SiteMap_createdonbehalfby";
			public const string lk_SiteMap_modifiedby = "lk_SiteMap_modifiedby";
			public const string lk_SiteMap_modifiedonbehalfby = "lk_SiteMap_modifiedonbehalfby";
			public const string organization_sitemap = "organization_sitemap";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SiteMap() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sitemap";
		
		public const string PrimaryIdAttribute = "sitemapid";
		
		public const int EntityTypeCode = 4709;
		
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
		/// 
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
		/// Information about whether the site map is associated with app module.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappaware")]
		public System.Nullable<bool> IsAppAware
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isappaware");
			}
			set
			{
				this.OnPropertyChanging("IsAppAware");
				this.SetAttributeValue("isappaware", value);
				this.OnPropertyChanged("IsAppAware");
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
		/// 
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
		/// 
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapid")]
		public System.Nullable<System.Guid> SiteMapId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sitemapid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapid")]
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapidunique")]
		public System.Nullable<System.Guid> SiteMapIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sitemapidunique");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapname")]
		public string SiteMapName
		{
			get
			{
				return this.GetAttributeValue<string>("sitemapname");
			}
			set
			{
				this.OnPropertyChanging("SiteMapName");
				this.SetAttributeValue("sitemapname", value);
				this.OnPropertyChanged("SiteMapName");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapnameunique")]
		public string SiteMapNameUnique
		{
			get
			{
				return this.GetAttributeValue<string>("sitemapnameunique");
			}
			set
			{
				this.OnPropertyChanging("SiteMapNameUnique");
				this.SetAttributeValue("sitemapnameunique", value);
				this.OnPropertyChanged("SiteMapNameUnique");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapxml")]
		public string SiteMapXml
		{
			get
			{
				return this.GetAttributeValue<string>("sitemapxml");
			}
			set
			{
				this.OnPropertyChanging("SiteMapXml");
				this.SetAttributeValue("sitemapxml", value);
				this.OnPropertyChanged("SiteMapXml");
			}
		}
		
		/// <summary>
		/// 
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
		/// 1:N userentityinstancedata_sitemap
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sitemap")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_sitemap
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sitemap", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_sitemap");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_sitemap", null, value);
				this.OnPropertyChanged("userentityinstancedata_sitemap");
			}
		}
		
		/// <summary>
		/// N:1 lk_SiteMap_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SiteMap_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_SiteMap_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_SiteMap_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SiteMap_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_SiteMap_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_SiteMap_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_SiteMap_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_SiteMap_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SiteMap_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_SiteMap_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_SiteMap_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SiteMap_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_SiteMap_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_SiteMap_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_SiteMap_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_SiteMap_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_sitemap
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sitemap")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_sitemap
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_sitemap", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SiteMap(object anonymousType) : 
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
                        Attributes["sitemapid"] = base.Id;
                        break;
                    case "sitemapid":
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