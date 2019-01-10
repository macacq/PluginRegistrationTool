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
	/// Relationship between a customer and a partner in which either can be an account or contact.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customerrelationship")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class CustomerRelationship : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ConverseRelationshipId = "converserelationshipid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CustomerId = "customerid";
			public const string CustomerRelationshipId = "customerrelationshipid";
			public const string Id = "customerrelationshipid";
			public const string CustomerRoleDescription = "customerroledescription";
			public const string CustomerRoleId = "customerroleid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PartnerId = "partnerid";
			public const string PartnerRoleDescription = "partnerroledescription";
			public const string PartnerRoleId = "partnerroleid";
			public const string VersionNumber = "versionnumber";
			public const string account_customer_relationship_customer = "account_customer_relationship_customer";
			public const string account_customer_relationship_partner = "account_customer_relationship_partner";
			public const string business_unit_customer_relationship = "business_unit_customer_relationship";
			public const string contact_customer_relationship_customer = "contact_customer_relationship_customer";
			public const string contact_customer_relationship_partner = "contact_customer_relationship_partner";
			public const string createdby_customer_relationship = "createdby_customer_relationship";
			public const string createdonbehalfby_customer_relationship = "createdonbehalfby_customer_relationship";
			public const string Referencingcustomer_relationship_converse_relationship = "customer_relationship_converse_relationship";
			public const string modifiedby_customer_relationship = "modifiedby_customer_relationship";
			public const string modifiedonbehalfby_customer_relationship = "modifiedonbehalfby_customer_relationship";
			public const string relationship_role_customer_role = "relationship_role_customer_role";
			public const string relationship_role_partner_role = "relationship_role_partner_role";
			public const string team_customer_relationship = "team_customer_relationship";
			public const string user_customer_relationship = "user_customer_relationship";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public CustomerRelationship() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "customerrelationship";
		
		public const string PrimaryIdAttribute = "customerrelationshipid";
		
		public const string PrimaryNameAttribute = "customerroleidname";
		
		public const int EntityTypeCode = 4502;
		
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
		/// Unique identifier of the converse relationship of the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
		public Microsoft.Xrm.Sdk.EntityReference ConverseRelationshipId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("converserelationshipid");
			}
			set
			{
				this.OnPropertyChanging("ConverseRelationshipId");
				this.SetAttributeValue("converserelationshipid", value);
				this.OnPropertyChanged("ConverseRelationshipId");
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
		/// Shows the date and time when the customer relationship was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Select the primary account or contact involved in the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
			}
			set
			{
				this.OnPropertyChanging("CustomerId");
				this.SetAttributeValue("customerid", value);
				this.OnPropertyChanged("CustomerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
		public System.Nullable<System.Guid> CustomerRelationshipId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("customerrelationshipid");
			}
			set
			{
				this.OnPropertyChanging("CustomerRelationshipId");
				this.SetAttributeValue("customerrelationshipid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CustomerRelationshipId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.CustomerRelationshipId = value;
			}
		}
		
		/// <summary>
		/// Type additional information about the primary party's role in the customer relationship, such as the length or quality of the relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroledescription")]
		public string CustomerRoleDescription
		{
			get
			{
				return this.GetAttributeValue<string>("customerroledescription");
			}
			set
			{
				this.OnPropertyChanging("CustomerRoleDescription");
				this.SetAttributeValue("customerroledescription", value);
				this.OnPropertyChanged("CustomerRoleDescription");
			}
		}
		
		/// <summary>
		/// Choose the primary party's role or nature of the relationship the customer has with the second party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerRoleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerroleid");
			}
			set
			{
				this.OnPropertyChanging("CustomerRoleId");
				this.SetAttributeValue("customerroleid", value);
				this.OnPropertyChanged("CustomerRoleId");
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
		/// Unique identifier of the business unit that owns the customer relationship.
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
		/// Unique identifier of the team who owns the customer relationship.
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
		/// Unique identifier of the user who owns the customer relationship.
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
		/// Select the secondary account or contact involved in the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		public Microsoft.Xrm.Sdk.EntityReference PartnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerid");
			}
			set
			{
				this.OnPropertyChanging("PartnerId");
				this.SetAttributeValue("partnerid", value);
				this.OnPropertyChanged("PartnerId");
			}
		}
		
		/// <summary>
		/// Type additional information about the secondary party's role in the customer relationship, such as the length or quality of the relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroledescription")]
		public string PartnerRoleDescription
		{
			get
			{
				return this.GetAttributeValue<string>("partnerroledescription");
			}
			set
			{
				this.OnPropertyChanging("PartnerRoleDescription");
				this.SetAttributeValue("partnerroledescription", value);
				this.OnPropertyChanged("PartnerRoleDescription");
			}
		}
		
		/// <summary>
		/// Choose the secondary party's role or nature of the relationship the customer has with the primary party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
		public Microsoft.Xrm.Sdk.EntityReference PartnerRoleId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerroleid");
			}
			set
			{
				this.OnPropertyChanging("PartnerRoleId");
				this.SetAttributeValue("partnerroleid", value);
				this.OnPropertyChanged("PartnerRoleId");
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
		/// 1:N customer_relationship_converse_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship> Referencedcustomer_relationship_converse_relationship
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedcustomer_relationship_converse_relationship");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcustomer_relationship_converse_relationship");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> CustomerRelationship_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("CustomerRelationship_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("CustomerRelationship_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("CustomerRelationship_AsyncOperations", null, value);
				this.OnPropertyChanged("CustomerRelationship_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> CustomerRelationship_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("CustomerRelationship_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("CustomerRelationship_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> CustomerRelationship_ProcessSessions
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("CustomerRelationship_ProcessSessions", null);
			}
			set
			{
				this.OnPropertyChanging("CustomerRelationship_ProcessSessions");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("CustomerRelationship_ProcessSessions", null, value);
				this.OnPropertyChanged("CustomerRelationship_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_customerrelationship
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customerrelationship")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_customerrelationship
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_customerrelationship", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_customerrelationship");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_customerrelationship", null, value);
				this.OnPropertyChanged("userentityinstancedata_customerrelationship");
			}
		}
		
		/// <summary>
		/// N:1 account_customer_relationship_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_customer")]
		public Xrm.Sdk.PluginRegistration.Entities.Account account_customer_relationship_customer
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("account_customer_relationship_customer", null);
			}
			set
			{
				this.OnPropertyChanging("account_customer_relationship_customer");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("account_customer_relationship_customer", null, value);
				this.OnPropertyChanged("account_customer_relationship_customer");
			}
		}
		
		/// <summary>
		/// N:1 account_customer_relationship_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_partner")]
		public Xrm.Sdk.PluginRegistration.Entities.Account account_customer_relationship_partner
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("account_customer_relationship_partner", null);
			}
			set
			{
				this.OnPropertyChanging("account_customer_relationship_partner");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("account_customer_relationship_partner", null, value);
				this.OnPropertyChanged("account_customer_relationship_partner");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_customer_relationship", null);
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_relationship_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_customer")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact contact_customer_relationship_customer
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("contact_customer_relationship_customer", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_relationship_customer");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("contact_customer_relationship_customer", null, value);
				this.OnPropertyChanged("contact_customer_relationship_customer");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_relationship_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_partner")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact contact_customer_relationship_partner
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("contact_customer_relationship_partner", null);
			}
			set
			{
				this.OnPropertyChanging("contact_customer_relationship_partner");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("contact_customer_relationship_partner", null, value);
				this.OnPropertyChanged("contact_customer_relationship_partner");
			}
		}
		
		/// <summary>
		/// N:1 createdby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser createdby_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdby_customer_relationship", null);
			}
		}
		
		/// <summary>
		/// N:1 createdonbehalfby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser createdonbehalfby_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdonbehalfby_customer_relationship", null);
			}
			set
			{
				this.OnPropertyChanging("createdonbehalfby_customer_relationship");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("createdonbehalfby_customer_relationship", null, value);
				this.OnPropertyChanged("createdonbehalfby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 customer_relationship_converse_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship Referencingcustomer_relationship_converse_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingcustomer_relationship_converse_relationship");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcustomer_relationship_converse_relationship");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser modifiedby_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedby_customer_relationship", null);
			}
		}
		
		/// <summary>
		/// N:1 modifiedonbehalfby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser modifiedonbehalfby_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedonbehalfby_customer_relationship", null);
			}
			set
			{
				this.OnPropertyChanging("modifiedonbehalfby_customer_relationship");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("modifiedonbehalfby_customer_relationship", null, value);
				this.OnPropertyChanged("modifiedonbehalfby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 relationship_role_customer_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_role")]
		public Xrm.Sdk.PluginRegistration.Entities.RelationshipRole relationship_role_customer_role
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RelationshipRole>("relationship_role_customer_role", null);
			}
			set
			{
				this.OnPropertyChanging("relationship_role_customer_role");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RelationshipRole>("relationship_role_customer_role", null, value);
				this.OnPropertyChanged("relationship_role_customer_role");
			}
		}
		
		/// <summary>
		/// N:1 relationship_role_partner_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_partner_role")]
		public Xrm.Sdk.PluginRegistration.Entities.RelationshipRole relationship_role_partner_role
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RelationshipRole>("relationship_role_partner_role", null);
			}
			set
			{
				this.OnPropertyChanging("relationship_role_partner_role");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RelationshipRole>("relationship_role_partner_role", null, value);
				this.OnPropertyChanged("relationship_role_partner_role");
			}
		}
		
		/// <summary>
		/// N:1 team_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.Team team_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Team>("team_customer_relationship", null);
			}
		}
		
		/// <summary>
		/// N:1 user_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_relationship")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser user_customer_relationship
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("user_customer_relationship", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public CustomerRelationship(object anonymousType) : 
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
                        Attributes["customerrelationshipid"] = base.Id;
                        break;
                    case "customerrelationshipid":
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