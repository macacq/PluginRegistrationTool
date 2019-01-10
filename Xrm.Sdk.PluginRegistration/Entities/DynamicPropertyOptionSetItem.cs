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
	/// Item with a name and value in a property option set type.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyoptionsetitem")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class DynamicPropertyOptionSetItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DMTImportState = "dmtimportstate";
			public const string DynamicPropertyId = "dynamicpropertyid";
			public const string DynamicPropertyOptionDescription = "dynamicpropertyoptiondescription";
			public const string DynamicPropertyOptionName = "dynamicpropertyoptionname";
			public const string DynamicPropertyOptionSetValueId = "dynamicpropertyoptionsetvalueid";
			public const string Id = "dynamicpropertyoptionsetvalueid";
			public const string DynamicPropertyOptionSetValueSequenceNumber = "dynamicpropertyoptionsetvaluesequencenumber";
			public const string DynamicPropertyOptionValue = "dynamicpropertyoptionvalue";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string DynamicProperty_DynamicPropertyOptionSetItem = "DynamicProperty_DynamicPropertyOptionSetItem";
			public const string DynamicPropertyOptionSetItem_organization = "DynamicPropertyOptionSetItem_organization";
			public const string DynamicPropertyOptionSetItem_TransactionCurrency = "DynamicPropertyOptionSetItem_TransactionCurrency";
			public const string lk_DynamicPropertyOptionSetItem_createdby = "lk_DynamicPropertyOptionSetItem_createdby";
			public const string lk_DynamicPropertyOptionSetItem_createdonbehalfby = "lk_DynamicPropertyOptionSetItem_createdonbehalfby";
			public const string lk_DynamicPropertyOptionSetItem_modifiedby = "lk_DynamicPropertyOptionSetItem_modifiedby";
			public const string lk_DynamicPropertyOptionSetItem_modifiedonbehalfby = "lk_DynamicPropertyOptionSetItem_modifiedonbehalfby";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public DynamicPropertyOptionSetItem() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dynamicpropertyoptionsetitem";
		
		public const string PrimaryIdAttribute = "dynamicpropertyoptionsetvalueid";
		
		public const string PrimaryNameAttribute = "dynamicpropertyoptionname";
		
		public const int EntityTypeCode = 1049;
		
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
		/// Unique identifier of the user who created the record.
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
		/// Date and time when the record was created.
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
		/// Unique identifier of the delegate user who created the record.
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
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
		public System.Nullable<int> DMTImportState
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate");
			}
			set
			{
				this.OnPropertyChanging("DMTImportState");
				this.SetAttributeValue("dmtimportstate", value);
				this.OnPropertyChanged("DMTImportState");
			}
		}
		
		/// <summary>
		/// Shows the property that uses this option set item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		public Microsoft.Xrm.Sdk.EntityReference DynamicPropertyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dynamicpropertyid");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyId");
				this.SetAttributeValue("dynamicpropertyid", value);
				this.OnPropertyChanged("DynamicPropertyId");
			}
		}
		
		/// <summary>
		/// Type additional information about the property option set item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptiondescription")]
		public string DynamicPropertyOptionDescription
		{
			get
			{
				return this.GetAttributeValue<string>("dynamicpropertyoptiondescription");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionDescription");
				this.SetAttributeValue("dynamicpropertyoptiondescription", value);
				this.OnPropertyChanged("DynamicPropertyOptionDescription");
			}
		}
		
		/// <summary>
		/// Type the name of the property option set item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionname")]
		public string DynamicPropertyOptionName
		{
			get
			{
				return this.GetAttributeValue<string>("dynamicpropertyoptionname");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionName");
				this.SetAttributeValue("dynamicpropertyoptionname", value);
				this.OnPropertyChanged("DynamicPropertyOptionName");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the property option set item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvalueid")]
		public System.Nullable<System.Guid> DynamicPropertyOptionSetValueId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyoptionsetvalueid");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionSetValueId");
				this.SetAttributeValue("dynamicpropertyoptionsetvalueid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("DynamicPropertyOptionSetValueId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvalueid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.DynamicPropertyOptionSetValueId = value;
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvaluesequencenumber")]
		public System.Nullable<int> DynamicPropertyOptionSetValueSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dynamicpropertyoptionsetvaluesequencenumber");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionSetValueSequenceNumber");
				this.SetAttributeValue("dynamicpropertyoptionsetvaluesequencenumber", value);
				this.OnPropertyChanged("DynamicPropertyOptionSetValueSequenceNumber");
			}
		}
		
		/// <summary>
		/// Shows the value of the property option set item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionvalue")]
		public System.Nullable<int> DynamicPropertyOptionValue
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dynamicpropertyoptionvalue");
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionValue");
				this.SetAttributeValue("dynamicpropertyoptionvalue", value);
				this.OnPropertyChanged("DynamicPropertyOptionValue");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
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
		/// Unique identifier of the user who modified the record.
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
		/// Date and time when the record was modified.
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
		/// Unique identifier of the delegate user who modified the record.
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
		/// Unique identifier for the organization
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
		/// Date and time that the record was migrated.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Shows the currency associated with the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
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
		/// 1:N DefaultValueOptionSet_DynamicProperty
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DefaultValueOptionSet_DynamicProperty")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DynamicProperty> DefaultValueOptionSet_DynamicProperty
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DynamicProperty>("DefaultValueOptionSet_DynamicProperty", null);
			}
			set
			{
				this.OnPropertyChanging("DefaultValueOptionSet_DynamicProperty");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DynamicProperty>("DefaultValueOptionSet_DynamicProperty", null, value);
				this.OnPropertyChanged("DefaultValueOptionSet_DynamicProperty");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> dynamicpropertyoptionsetitem_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("dynamicpropertyoptionsetitem_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("dynamicpropertyoptionsetitem_AsyncOperations", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> dynamicpropertyoptionsetitem_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("dynamicpropertyoptionsetitem_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("dynamicpropertyoptionsetitem_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> dynamicpropertyoptionsetitem_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("dynamicpropertyoptionsetitem_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("dynamicpropertyoptionsetitem_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> dynamicpropertyoptionsetitem_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("dynamicpropertyoptionsetitem_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("dynamicpropertyoptionsetitem_SyncErrors", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N dynamicpropertyoptionsetitem_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicpropertyoptionsetitem_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> dynamicpropertyoptionsetitem_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("dynamicpropertyoptionsetitem_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("dynamicpropertyoptionsetitem_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("dynamicpropertyoptionsetitem_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("dynamicpropertyoptionsetitem_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 DynamicProperty_DynamicPropertyOptionSetItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyOptionSetItem")]
		public Xrm.Sdk.PluginRegistration.Entities.DynamicProperty DynamicProperty_DynamicPropertyOptionSetItem
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.DynamicProperty>("DynamicProperty_DynamicPropertyOptionSetItem", null);
			}
			set
			{
				this.OnPropertyChanging("DynamicProperty_DynamicPropertyOptionSetItem");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.DynamicProperty>("DynamicProperty_DynamicPropertyOptionSetItem", null, value);
				this.OnPropertyChanged("DynamicProperty_DynamicPropertyOptionSetItem");
			}
		}
		
		/// <summary>
		/// N:1 DynamicPropertyOptionSetItem_organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_organization")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization DynamicPropertyOptionSetItem_organization
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("DynamicPropertyOptionSetItem_organization", null);
			}
		}
		
		/// <summary>
		/// N:1 DynamicPropertyOptionSetItem_TransactionCurrency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_TransactionCurrency")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency DynamicPropertyOptionSetItem_TransactionCurrency
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("DynamicPropertyOptionSetItem_TransactionCurrency", null);
			}
			set
			{
				this.OnPropertyChanging("DynamicPropertyOptionSetItem_TransactionCurrency");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("DynamicPropertyOptionSetItem_TransactionCurrency", null, value);
				this.OnPropertyChanged("DynamicPropertyOptionSetItem_TransactionCurrency");
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyOptionSetItem_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_DynamicPropertyOptionSetItem_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyOptionSetItem_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_DynamicPropertyOptionSetItem_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyOptionSetItem_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_DynamicPropertyOptionSetItem_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public DynamicPropertyOptionSetItem(object anonymousType) : 
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
                        Attributes["dynamicpropertyoptionsetvalueid"] = base.Id;
                        break;
                    case "dynamicpropertyoptionsetvalueid":
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
	}
}