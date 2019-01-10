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
	/// Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("slakpiinstance")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SLAKPIInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComputedFailureTime = "computedfailuretime";
			public const string ComputedWarningTime = "computedwarningtime";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string FailureTime = "failuretime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Regarding = "regarding";
			public const string SLAKPIInstanceId = "slakpiinstanceid";
			public const string Id = "slakpiinstanceid";
			public const string Status = "status";
			public const string SucceededOn = "succeededon";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string WarningTime = "warningtime";
			public const string WarningTimeReached = "warningtimereached";
			public const string business_unit_slakpiinstance = "business_unit_slakpiinstance";
			public const string lk_slakpiinstancebase_createdby = "lk_slakpiinstancebase_createdby";
			public const string lk_slakpiinstancebase_createdonbehalfby = "lk_slakpiinstancebase_createdonbehalfby";
			public const string lk_slakpiinstancebase_modifiedby = "lk_slakpiinstancebase_modifiedby";
			public const string lk_slakpiinstancebase_modifiedonbehalfby = "lk_slakpiinstancebase_modifiedonbehalfby";
			public const string slakpiinstance_account = "slakpiinstance_account";
			public const string slakpiinstance_activitypointer = "slakpiinstance_activitypointer";
			public const string slakpiinstance_appointment = "slakpiinstance_appointment";
			public const string slakpiinstance_contact = "slakpiinstance_contact";
			public const string slakpiinstance_email = "slakpiinstance_email";
			public const string slakpiinstance_fax = "slakpiinstance_fax";
			public const string slakpiinstance_incident = "slakpiinstance_incident";
			public const string slakpiinstance_invoice = "slakpiinstance_invoice";
			public const string slakpiinstance_lead = "slakpiinstance_lead";
			public const string slakpiinstance_letter = "slakpiinstance_letter";
			public const string slakpiinstance_opportunity = "slakpiinstance_opportunity";
			public const string slakpiinstance_phonecall = "slakpiinstance_phonecall";
			public const string slakpiinstance_quote = "slakpiinstance_quote";
			public const string slakpiinstance_salesorder = "slakpiinstance_salesorder";
			public const string slakpiinstance_serviceappointment = "slakpiinstance_serviceappointment";
			public const string slakpiinstance_socialactivity = "slakpiinstance_socialactivity";
			public const string slakpiinstance_task = "slakpiinstance_task";
			public const string TransactionCurrency_slakpiinstance = "TransactionCurrency_slakpiinstance";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SLAKPIInstance() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "slakpiinstance";
		
		public const string PrimaryIdAttribute = "slakpiinstanceid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9752;
		
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
		/// Computed Failure Date and time
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedfailuretime")]
		public System.Nullable<System.DateTime> ComputedFailureTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("computedfailuretime");
			}
			set
			{
				this.OnPropertyChanging("ComputedFailureTime");
				this.SetAttributeValue("computedfailuretime", value);
				this.OnPropertyChanged("ComputedFailureTime");
			}
		}
		
		/// <summary>
		/// Computed Warning Date and time
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedwarningtime")]
		public System.Nullable<System.DateTime> ComputedWarningTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("computedwarningtime");
			}
			set
			{
				this.OnPropertyChanging("ComputedWarningTime");
				this.SetAttributeValue("computedwarningtime", value);
				this.OnPropertyChanged("ComputedWarningTime");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// For internal use only.
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
		/// For internal use only.
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
		/// For internal use only.
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
		/// Enter the date and time when the service level agreement (SLA) key performance indicator (KPI) will expire.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failuretime")]
		public System.Nullable<System.DateTime> FailureTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("failuretime");
			}
			set
			{
				this.OnPropertyChanging("FailureTime");
				this.SetAttributeValue("failuretime", value);
				this.OnPropertyChanged("FailureTime");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// For internal use only.
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
		/// For internal use only.
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
		/// Type a descriptive name for the service level agreement (SLA) key performance indicator (KPI) instance.
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.
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
		/// Owning Business Unit.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// OwningTeam.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Owning User.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		public Microsoft.Xrm.Sdk.EntityReference Regarding
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regarding");
			}
			set
			{
				this.OnPropertyChanging("Regarding");
				this.SetAttributeValue("regarding", value);
				this.OnPropertyChanged("Regarding");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SLA KPI Instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slakpiinstanceid")]
		public System.Nullable<System.Guid> SLAKPIInstanceId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("slakpiinstanceid");
			}
			set
			{
				this.OnPropertyChanging("SLAKPIInstanceId");
				this.SetAttributeValue("slakpiinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SLAKPIInstanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slakpiinstanceid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SLAKPIInstanceId = value;
			}
		}
		
		/// <summary>
		/// Reason for the status of the service level agreement (SLA) key performance indicator (KPI) instance. For example, the SLA KPI could be Noncompliant or Succeeded.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		public Microsoft.Xrm.Sdk.OptionSetValue Status
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("status");
			}
			set
			{
				this.OnPropertyChanging("Status");
				this.SetAttributeValue("status", value);
				this.OnPropertyChanged("Status");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the service level agreement (SLA) key performance indicator (KPI) success criteria was met.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("succeededon")]
		public System.Nullable<System.DateTime> SucceededOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("succeededon");
			}
			set
			{
				this.OnPropertyChanging("SucceededOn");
				this.SetAttributeValue("succeededon", value);
				this.OnPropertyChanged("SucceededOn");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
		/// Enter the date and time when the service level agreement (SLA) key performance indicator (KPI)will go to a warning state.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warningtime")]
		public System.Nullable<System.DateTime> WarningTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("warningtime");
			}
			set
			{
				this.OnPropertyChanging("WarningTime");
				this.SetAttributeValue("warningtime", value);
				this.OnPropertyChanged("WarningTime");
			}
		}
		
		/// <summary>
		/// Shows information about whether the case has reached its warning time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warningtimereached")]
		public Microsoft.Xrm.Sdk.OptionSetValue WarningTimeReached
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("warningtimereached");
			}
			set
			{
				this.OnPropertyChanging("WarningTimeReached");
				this.SetAttributeValue("warningtimereached", value);
				this.OnPropertyChanged("WarningTimeReached");
			}
		}
		
		/// <summary>
		/// 1:N slakpiinstance_incident_firstresponsebykpi
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_firstresponsebykpi")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Incident> slakpiinstance_incident_firstresponsebykpi
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident_firstresponsebykpi", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_incident_firstresponsebykpi");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident_firstresponsebykpi", null, value);
				this.OnPropertyChanged("slakpiinstance_incident_firstresponsebykpi");
			}
		}
		
		/// <summary>
		/// 1:N slakpiinstance_incident_resolvebykpi
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_resolvebykpi")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Incident> slakpiinstance_incident_resolvebykpi
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident_resolvebykpi", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_incident_resolvebykpi");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident_resolvebykpi", null, value);
				this.OnPropertyChanged("slakpiinstance_incident_resolvebykpi");
			}
		}
		
		/// <summary>
		/// 1:N SLAKPIInstance_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SLAKPIInstance_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> SLAKPIInstance_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("SLAKPIInstance_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("SLAKPIInstance_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("SLAKPIInstance_SyncErrors", null, value);
				this.OnPropertyChanged("SLAKPIInstance_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_slakpiinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_slakpiinstance")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_slakpiinstance
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_slakpiinstance", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_slakpiinstance");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_slakpiinstance", null, value);
				this.OnPropertyChanged("business_unit_slakpiinstance");
			}
		}
		
		/// <summary>
		/// N:1 lk_slakpiinstancebase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_slakpiinstancebase_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_slakpiinstancebase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_slakpiinstancebase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_slakpiinstancebase_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_slakpiinstancebase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_slakpiinstancebase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_slakpiinstancebase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_slakpiinstancebase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_slakpiinstancebase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_slakpiinstancebase_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_slakpiinstancebase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_slakpiinstancebase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_account")]
		public Xrm.Sdk.PluginRegistration.Entities.Account slakpiinstance_account
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("slakpiinstance_account", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_account");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("slakpiinstance_account", null, value);
				this.OnPropertyChanged("slakpiinstance_account");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_activitypointer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_activitypointer")]
		public Xrm.Sdk.PluginRegistration.Entities.ActivityPointer slakpiinstance_activitypointer
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActivityPointer>("slakpiinstance_activitypointer", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_activitypointer");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActivityPointer>("slakpiinstance_activitypointer", null, value);
				this.OnPropertyChanged("slakpiinstance_activitypointer");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_appointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_appointment")]
		public Xrm.Sdk.PluginRegistration.Entities.Appointment slakpiinstance_appointment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Appointment>("slakpiinstance_appointment", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_appointment");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Appointment>("slakpiinstance_appointment", null, value);
				this.OnPropertyChanged("slakpiinstance_appointment");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_contact")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact slakpiinstance_contact
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("slakpiinstance_contact", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_contact");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("slakpiinstance_contact", null, value);
				this.OnPropertyChanged("slakpiinstance_contact");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_email
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_email")]
		public Xrm.Sdk.PluginRegistration.Entities.Email slakpiinstance_email
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Email>("slakpiinstance_email", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_email");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Email>("slakpiinstance_email", null, value);
				this.OnPropertyChanged("slakpiinstance_email");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_fax
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_fax")]
		public Xrm.Sdk.PluginRegistration.Entities.Fax slakpiinstance_fax
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Fax>("slakpiinstance_fax", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_fax");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Fax>("slakpiinstance_fax", null, value);
				this.OnPropertyChanged("slakpiinstance_fax");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_incident
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident")]
		public Xrm.Sdk.PluginRegistration.Entities.Incident slakpiinstance_incident
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_incident");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Incident>("slakpiinstance_incident", null, value);
				this.OnPropertyChanged("slakpiinstance_incident");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_invoice
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_invoice")]
		public Xrm.Sdk.PluginRegistration.Entities.Invoice slakpiinstance_invoice
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Invoice>("slakpiinstance_invoice", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_invoice");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Invoice>("slakpiinstance_invoice", null, value);
				this.OnPropertyChanged("slakpiinstance_invoice");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_lead
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_lead")]
		public Xrm.Sdk.PluginRegistration.Entities.Lead slakpiinstance_lead
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Lead>("slakpiinstance_lead", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_lead");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Lead>("slakpiinstance_lead", null, value);
				this.OnPropertyChanged("slakpiinstance_lead");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_letter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_letter")]
		public Xrm.Sdk.PluginRegistration.Entities.Letter slakpiinstance_letter
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Letter>("slakpiinstance_letter", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_letter");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Letter>("slakpiinstance_letter", null, value);
				this.OnPropertyChanged("slakpiinstance_letter");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_opportunity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_opportunity")]
		public Xrm.Sdk.PluginRegistration.Entities.Opportunity slakpiinstance_opportunity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("slakpiinstance_opportunity", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_opportunity");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("slakpiinstance_opportunity", null, value);
				this.OnPropertyChanged("slakpiinstance_opportunity");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_phonecall
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_phonecall")]
		public Xrm.Sdk.PluginRegistration.Entities.PhoneCall slakpiinstance_phonecall
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.PhoneCall>("slakpiinstance_phonecall", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_phonecall");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.PhoneCall>("slakpiinstance_phonecall", null, value);
				this.OnPropertyChanged("slakpiinstance_phonecall");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_quote
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_quote")]
		public Xrm.Sdk.PluginRegistration.Entities.Quote slakpiinstance_quote
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Quote>("slakpiinstance_quote", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_quote");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Quote>("slakpiinstance_quote", null, value);
				this.OnPropertyChanged("slakpiinstance_quote");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_salesorder
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_salesorder")]
		public Xrm.Sdk.PluginRegistration.Entities.SalesOrder slakpiinstance_salesorder
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SalesOrder>("slakpiinstance_salesorder", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_salesorder");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SalesOrder>("slakpiinstance_salesorder", null, value);
				this.OnPropertyChanged("slakpiinstance_salesorder");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_serviceappointment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_serviceappointment")]
		public Xrm.Sdk.PluginRegistration.Entities.ServiceAppointment slakpiinstance_serviceappointment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ServiceAppointment>("slakpiinstance_serviceappointment", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_serviceappointment");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ServiceAppointment>("slakpiinstance_serviceappointment", null, value);
				this.OnPropertyChanged("slakpiinstance_serviceappointment");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_socialactivity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_socialactivity")]
		public Xrm.Sdk.PluginRegistration.Entities.SocialActivity slakpiinstance_socialactivity
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SocialActivity>("slakpiinstance_socialactivity", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_socialactivity");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SocialActivity>("slakpiinstance_socialactivity", null, value);
				this.OnPropertyChanged("slakpiinstance_socialactivity");
			}
		}
		
		/// <summary>
		/// N:1 slakpiinstance_task
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_task")]
		public Xrm.Sdk.PluginRegistration.Entities.Task slakpiinstance_task
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Task>("slakpiinstance_task", null);
			}
			set
			{
				this.OnPropertyChanging("slakpiinstance_task");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Task>("slakpiinstance_task", null, value);
				this.OnPropertyChanged("slakpiinstance_task");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_slakpiinstance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_slakpiinstance")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency TransactionCurrency_slakpiinstance
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_slakpiinstance", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_slakpiinstance");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_slakpiinstance", null, value);
				this.OnPropertyChanged("TransactionCurrency_slakpiinstance");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SLAKPIInstance(object anonymousType) : 
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
                        Attributes["slakpiinstanceid"] = base.Id;
                        break;
                    case "slakpiinstanceid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		public virtual slakpiinstance_status? StatusEnum
		{
			get
			{
				return ((slakpiinstance_status?)(EntityOptionSetEnum.GetEnum(this, "status")));
			}
			set
			{
				Status = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warningtimereached")]
		public virtual slakpiinstance_warningtimereached? WarningTimeReachedEnum
		{
			get
			{
				return ((slakpiinstance_warningtimereached?)(EntityOptionSetEnum.GetEnum(this, "warningtimereached")));
			}
			set
			{
				WarningTimeReached = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}