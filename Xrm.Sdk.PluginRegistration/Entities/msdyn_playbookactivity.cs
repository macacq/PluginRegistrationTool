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
	public enum msdyn_playbookactivityState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Published = 1,
	}
	
	/// <summary>
	/// Stores the details of the activities to be created when a playbook is launched.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_playbookactivity")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class msdyn_playbookactivity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
			public const string msdyn_activityLogicalName = "msdyn_activityLogicalName";
			public const string msdyn_activityType = "msdyn_activityType";
			public const string msdyn_playbookactivityId = "msdyn_playbookactivityid";
			public const string Id = "msdyn_playbookactivityid";
			public const string msdyn_playbooktemplateid = "msdyn_playbooktemplateid";
			public const string msdyn_subject = "msdyn_subject";
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
			public const string business_unit_msdyn_playbookactivity = "business_unit_msdyn_playbookactivity";
			public const string lk_msdyn_playbookactivity_createdby = "lk_msdyn_playbookactivity_createdby";
			public const string lk_msdyn_playbookactivity_createdonbehalfby = "lk_msdyn_playbookactivity_createdonbehalfby";
			public const string lk_msdyn_playbookactivity_modifiedby = "lk_msdyn_playbookactivity_modifiedby";
			public const string lk_msdyn_playbookactivity_modifiedonbehalfby = "lk_msdyn_playbookactivity_modifiedonbehalfby";
			public const string msdyn_playbooktemplate_msdyn_playbookactivity = "msdyn_playbooktemplate_msdyn_playbookactivity";
			public const string team_msdyn_playbookactivity = "team_msdyn_playbookactivity";
			public const string user_msdyn_playbookactivity = "user_msdyn_playbookactivity";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public msdyn_playbookactivity() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_playbookactivity";
		
		public const string PrimaryIdAttribute = "msdyn_playbookactivityid";
		
		public const string PrimaryNameAttribute = "msdyn_subject";
		
		public const int EntityTypeCode = 10004;
		
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
		/// The logical name of the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_activityLogicalName")]
		public string msdyn_activityLogicalName
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_activityLogicalName");
			}
			set
			{
				this.OnPropertyChanging("msdyn_activityLogicalName");
				this.SetAttributeValue("msdyn_activityLogicalName", value);
				this.OnPropertyChanged("msdyn_activityLogicalName");
			}
		}
		
		/// <summary>
		/// Select the type of activity to be associated with the playbook.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_activityType")]
		public Microsoft.Xrm.Sdk.OptionSetValue msdyn_activityType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_activityType");
			}
			set
			{
				this.OnPropertyChanging("msdyn_activityType");
				this.SetAttributeValue("msdyn_activityType", value);
				this.OnPropertyChanged("msdyn_activityType");
			}
		}
		
		/// <summary>
		/// Shows the ID of the playbook activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_playbookactivityid")]
		public System.Nullable<System.Guid> msdyn_playbookactivityId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_playbookactivityid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivityId");
				this.SetAttributeValue("msdyn_playbookactivityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_playbookactivityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_playbookactivityid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.msdyn_playbookactivityId = value;
			}
		}
		
		/// <summary>
		/// Shows the ID of the playbook template associated with the playbook activities.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_playbooktemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_playbooktemplateid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_playbooktemplateid");
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbooktemplateid");
				this.SetAttributeValue("msdyn_playbooktemplateid", value);
				this.OnPropertyChanged("msdyn_playbooktemplateid");
			}
		}
		
		/// <summary>
		/// Type a short description about the objective or primary topic of the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_subject")]
		public string msdyn_subject
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_subject");
			}
			set
			{
				this.OnPropertyChanging("msdyn_subject");
				this.SetAttributeValue("msdyn_subject", value);
				this.OnPropertyChanged("msdyn_subject");
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
		/// Status of the Playbook Activities
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityState), optionSet.Value)));
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
		/// Reason for the status of the Playbook Activities
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
		/// 1:N msdyn_playbookactivity_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> msdyn_playbookactivity_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("msdyn_playbookactivity_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("msdyn_playbookactivity_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> msdyn_playbookactivity_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("msdyn_playbookactivity_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("msdyn_playbookactivity_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> msdyn_playbookactivity_DuplicateBaseRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_playbookactivity_DuplicateBaseRecord", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_DuplicateBaseRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_playbookactivity_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> msdyn_playbookactivity_DuplicateMatchingRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_playbookactivity_DuplicateMatchingRecord", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_DuplicateMatchingRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("msdyn_playbookactivity_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> msdyn_playbookactivity_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("msdyn_playbookactivity_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("msdyn_playbookactivity_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_msdyn_playbookactivityattribute
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_msdyn_playbookactivityattribute")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityattribute> msdyn_playbookactivity_msdyn_playbookactivityattribute
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityattribute>("msdyn_playbookactivity_msdyn_playbookactivityattribute", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_msdyn_playbookactivityattribute");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbookactivityattribute>("msdyn_playbookactivity_msdyn_playbookactivityattribute", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_msdyn_playbookactivityattribute");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> msdyn_playbookactivity_PrincipalObjectAttributeAccesses
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("msdyn_playbookactivity_PrincipalObjectAttributeAccesses", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("msdyn_playbookactivity_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> msdyn_playbookactivity_ProcessSession
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("msdyn_playbookactivity_ProcessSession", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_ProcessSession");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("msdyn_playbookactivity_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> msdyn_playbookactivity_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("msdyn_playbookactivity_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("msdyn_playbookactivity_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_playbookactivity_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbookactivity_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> msdyn_playbookactivity_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("msdyn_playbookactivity_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbookactivity_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("msdyn_playbookactivity_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_playbookactivity_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_playbookactivity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_playbookactivity")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_msdyn_playbookactivity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_msdyn_playbookactivity", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_playbookactivity_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_playbookactivity_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_playbookactivity_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_playbookactivity_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_playbookactivity_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_playbookactivity_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_msdyn_playbookactivity_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_playbookactivity_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_playbookactivity_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_playbookactivity_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_playbookactivity_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_playbookactivity_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_playbookactivity_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_msdyn_playbookactivity_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_msdyn_playbookactivity_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_msdyn_playbookactivity_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_playbookactivity_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_playbooktemplate_msdyn_playbookactivity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_playbooktemplateid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_playbooktemplate_msdyn_playbookactivity")]
		public Xrm.Sdk.PluginRegistration.Entities.msdyn_playbooktemplate msdyn_playbooktemplate_msdyn_playbookactivity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbooktemplate>("msdyn_playbooktemplate_msdyn_playbookactivity", null);
			}
			set
			{
				this.OnPropertyChanging("msdyn_playbooktemplate_msdyn_playbookactivity");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.msdyn_playbooktemplate>("msdyn_playbooktemplate_msdyn_playbookactivity", null, value);
				this.OnPropertyChanged("msdyn_playbooktemplate_msdyn_playbookactivity");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_playbookactivity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_playbookactivity")]
		public Xrm.Sdk.PluginRegistration.Entities.Team team_msdyn_playbookactivity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Team>("team_msdyn_playbookactivity", null);
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_playbookactivity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_playbookactivity")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser user_msdyn_playbookactivity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("user_msdyn_playbookactivity", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public msdyn_playbookactivity(object anonymousType) : 
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
                        Attributes["msdyn_playbookactivityid"] = base.Id;
                        break;
                    case "msdyn_playbookactivityid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_activityType")]
		public virtual msdyn_playbookactivity_optionset? msdyn_activityTypeEnum
		{
			get
			{
				return ((msdyn_playbookactivity_optionset?)(EntityOptionSetEnum.GetEnum(this, "msdyn_activityType")));
			}
			set
			{
				msdyn_activityType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msdyn_playbookactivity_statuscode? StatusCodeEnum
		{
			get
			{
				return ((msdyn_playbookactivity_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}