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
	public enum msdyn_untrackedappointmentState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_untrackedappointment")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class msdyn_untrackedappointment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_untrackedappointmentId = "msdyn_untrackedappointmentid";
			public const string Id = "msdyn_untrackedappointmentid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_msdyn_untrackedappointment = "business_unit_msdyn_untrackedappointment";
			public const string lk_msdyn_untrackedappointment_createdby = "lk_msdyn_untrackedappointment_createdby";
			public const string lk_msdyn_untrackedappointment_createdonbehalfby = "lk_msdyn_untrackedappointment_createdonbehalfby";
			public const string lk_msdyn_untrackedappointment_modifiedby = "lk_msdyn_untrackedappointment_modifiedby";
			public const string lk_msdyn_untrackedappointment_modifiedonbehalfby = "lk_msdyn_untrackedappointment_modifiedonbehalfby";
			public const string team_msdyn_untrackedappointment = "team_msdyn_untrackedappointment";
			public const string user_msdyn_untrackedappointment = "user_msdyn_untrackedappointment";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public msdyn_untrackedappointment() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_untrackedappointment";
		
		public const string PrimaryIdAttribute = "msdyn_untrackedappointmentid";
		
		public const string PrimaryNameAttribute = "msdyn_name";
		
		public const int EntityTypeCode = 10013;
		
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
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_name")]
		public string msdyn_name
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_name");
			}
			set
			{
				this.OnPropertyChanging("msdyn_name");
				this.SetAttributeValue("msdyn_name", value);
				this.OnPropertyChanged("msdyn_name");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_untrackedappointmentid")]
		public System.Nullable<System.Guid> msdyn_untrackedappointmentId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_untrackedappointmentid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointmentId");
				this.SetAttributeValue("msdyn_untrackedappointmentid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_untrackedappointmentId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_untrackedappointmentid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.msdyn_untrackedappointmentId = value;
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
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the UntrackedAppointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.msdyn_untrackedappointmentState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.msdyn_untrackedappointmentState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.msdyn_untrackedappointmentState), optionSet.Value)));
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
		/// Reason for the status of the UntrackedAppointment
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
		/// 1:N msdyn_untrackedappointment_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> msdyn_untrackedappointment_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("msdyn_untrackedappointment_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("msdyn_untrackedappointment_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> msdyn_untrackedappointment_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("msdyn_untrackedappointment_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("msdyn_untrackedappointment_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> msdyn_untrackedappointment_DuplicateBaseRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_untrackedappointment_DuplicateBaseRecord", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_DuplicateBaseRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_untrackedappointment_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> msdyn_untrackedappointment_DuplicateMatchingRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_untrackedappointment_DuplicateMatchingRecord", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_DuplicateMatchingRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_untrackedappointment_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> msdyn_untrackedappointment_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("msdyn_untrackedappointment_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("msdyn_untrackedappointment_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> msdyn_untrackedappointment_PrincipalObjectAttributeAccesses
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("msdyn_untrackedappointment_PrincipalObjectAttributeAccesses", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("msdyn_untrackedappointment_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> msdyn_untrackedappointment_ProcessSession
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("msdyn_untrackedappointment_ProcessSession", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_ProcessSession");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("msdyn_untrackedappointment_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> msdyn_untrackedappointment_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("msdyn_untrackedappointment_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("msdyn_untrackedappointment_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_untrackedappointment_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_untrackedappointment_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> msdyn_untrackedappointment_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("msdyn_untrackedappointment_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_untrackedappointment_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("msdyn_untrackedappointment_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_untrackedappointment_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_untrackedappointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_untrackedappointment")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_msdyn_untrackedappointment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_msdyn_untrackedappointment", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_untrackedappointment_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_untrackedappointment_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_untrackedappointment_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_untrackedappointment_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_untrackedappointment_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_untrackedappointment_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_msdyn_untrackedappointment_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_untrackedappointment_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_untrackedappointment_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_untrackedappointment_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_untrackedappointment_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_untrackedappointment_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_untrackedappointment_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_untrackedappointment_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_msdyn_untrackedappointment_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_untrackedappointment_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_untrackedappointment_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_untrackedappointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_untrackedappointment")]
		public Xrm.Sdk.PluginRegistration.Entities.Team team_msdyn_untrackedappointment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Team>("team_msdyn_untrackedappointment", null);
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_untrackedappointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_untrackedappointment")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser user_msdyn_untrackedappointment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("user_msdyn_untrackedappointment", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public msdyn_untrackedappointment(object anonymousType) : 
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
                        Attributes["msdyn_untrackedappointmentid"] = base.Id;
                        break;
                    case "msdyn_untrackedappointmentid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msdyn_untrackedappointment_statuscode? StatusCodeEnum
		{
			get
			{
				return ((msdyn_untrackedappointment_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}