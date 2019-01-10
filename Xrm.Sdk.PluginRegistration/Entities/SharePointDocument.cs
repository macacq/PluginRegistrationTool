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
	/// Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sharepointdocument")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SharePointDocument : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AbsoluteUrl = "absoluteurl";
			public const string AppCreatedBy = "appcreatedby";
			public const string AppModifiedBy = "appmodifiedby";
			public const string Author = "author";
			public const string BusinessUnitId = "businessunitid";
			public const string CheckedOutTo = "checkedoutto";
			public const string CheckInComment = "checkincomment";
			public const string ChildFolderCount = "childfoldercount";
			public const string ChildItemCount = "childitemcount";
			public const string ContentType = "contenttype";
			public const string ContentTypeId = "contenttypeid";
			public const string CopySource = "copysource";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DocumentId = "documentid";
			public const string DocumentLocationType = "documentlocationtype";
			public const string Edit = "edit";
			public const string EditUrl = "editurl";
			public const string ExchangeRate = "exchangerate";
			public const string FileSize = "filesize";
			public const string FileType = "filetype";
			public const string FullName = "fullname";
			public const string IconClassName = "iconclassname";
			public const string IsCheckedOut = "ischeckedout";
			public const string IsFolder = "isfolder";
			public const string IsRecursiveFetch = "isrecursivefetch";
			public const string LocationId = "locationid";
			public const string LocationName = "locationname";
			public const string Modified = "modified";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string ReadUrl = "readurl";
			public const string RegardingObjectId = "regardingobjectid";
			public const string RelativeLocation = "relativelocation";
			public const string ServiceType = "servicetype";
			public const string SharePointCreatedOn = "sharepointcreatedon";
			public const string SharePointDocumentId = "sharepointdocumentid";
			public const string Id = "sharepointdocumentid";
			public const string SharePointModifiedBy = "sharepointmodifiedby";
			public const string Title = "title";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string Version = "version";
			public const string Account_SharepointDocument = "Account_SharepointDocument";
			public const string business_unit_sharepointdocument = "business_unit_sharepointdocument";
			public const string business_unit_sharepointdocument2 = "business_unit_sharepointdocument2";
			public const string KbArticle_SharepointDocument = "KbArticle_SharepointDocument";
			public const string knowledgearticle_SharePointDocuments = "knowledgearticle_SharePointDocuments";
			public const string Lead_SharepointDocument = "Lead_SharepointDocument";
			public const string lk_sharepointdocumentbase_createdby = "lk_sharepointdocumentbase_createdby";
			public const string lk_sharepointdocumentbase_createdonbehalfby = "lk_sharepointdocumentbase_createdonbehalfby";
			public const string lk_sharepointdocumentbase_modifiedby = "lk_sharepointdocumentbase_modifiedby";
			public const string lk_sharepointdocumentbase_modifiedonbehalfby = "lk_sharepointdocumentbase_modifiedonbehalfby";
			public const string Opportunity_SharepointDocument = "Opportunity_SharepointDocument";
			public const string organization_sharepointdocument = "organization_sharepointdocument";
			public const string Product_SharepointDocument = "Product_SharepointDocument";
			public const string Quote_SharepointDocument = "Quote_SharepointDocument";
			public const string SalesLiterature_SharepointDocument = "SalesLiterature_SharepointDocument";
			public const string TransactionCurrency_SharePointDocument = "TransactionCurrency_SharePointDocument";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SharePointDocument() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sharepointdocument";
		
		public const string PrimaryIdAttribute = "sharepointdocumentid";
		
		public const string PrimaryNameAttribute = "fullname";
		
		public const int EntityTypeCode = 9507;
		
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
		/// Type the URL where the SharePoint document is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("absoluteurl")]
		public string AbsoluteUrl
		{
			get
			{
				return this.GetAttributeValue<string>("absoluteurl");
			}
		}
		
		/// <summary>
		/// Name of the person who created the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appcreatedby")]
		public string AppCreatedBy
		{
			get
			{
				return this.GetAttributeValue<string>("appcreatedby");
			}
		}
		
		/// <summary>
		/// Name of the person who last modified the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("appmodifiedby")]
		public string AppModifiedBy
		{
			get
			{
				return this.GetAttributeValue<string>("appmodifiedby");
			}
		}
		
		/// <summary>
		/// Name of the author of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("author")]
		public string Author
		{
			get
			{
				return this.GetAttributeValue<string>("author");
			}
			set
			{
				this.OnPropertyChanging("Author");
				this.SetAttributeValue("author", value);
				this.OnPropertyChanged("Author");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
			}
			set
			{
				this.OnPropertyChanging("BusinessUnitId");
				this.SetAttributeValue("businessunitid", value);
				this.OnPropertyChanged("BusinessUnitId");
			}
		}
		
		/// <summary>
		/// Shows who the SharePoint document is checked out to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkedoutto")]
		public string CheckedOutTo
		{
			get
			{
				return this.GetAttributeValue<string>("checkedoutto");
			}
		}
		
		/// <summary>
		/// Type a comment about the document that is being checked in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkincomment")]
		public string CheckInComment
		{
			get
			{
				return this.GetAttributeValue<string>("checkincomment");
			}
		}
		
		/// <summary>
		/// Shows the number of child folders.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childfoldercount")]
		public System.Nullable<int> ChildFolderCount
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("childfoldercount");
			}
		}
		
		/// <summary>
		/// Shows how many child items there are.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childitemcount")]
		public System.Nullable<int> ChildItemCount
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("childitemcount");
			}
		}
		
		/// <summary>
		/// The content type of the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contenttype")]
		public string ContentType
		{
			get
			{
				return this.GetAttributeValue<string>("contenttype");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the content type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contenttypeid")]
		public System.Nullable<int> ContentTypeId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("contenttypeid");
			}
		}
		
		/// <summary>
		/// SharePoint source item URL
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("copysource")]
		public string CopySource
		{
			get
			{
				return this.GetAttributeValue<string>("copysource");
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Unique identifier of a SharePoint document in document library.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentid")]
		public System.Nullable<int> DocumentId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("documentid");
			}
		}
		
		/// <summary>
		/// Location type of the SharePoint document location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentlocationtype")]
		public Microsoft.Xrm.Sdk.OptionSetValue DocumentLocationType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("documentlocationtype");
			}
		}
		
		/// <summary>
		/// Edit Url of the Sharepoint Form
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("edit")]
		public string Edit
		{
			get
			{
				return this.GetAttributeValue<string>("edit");
			}
		}
		
		/// <summary>
		/// Shows the edit URL of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("editurl")]
		public string EditUrl
		{
			get
			{
				return this.GetAttributeValue<string>("editurl");
			}
		}
		
		/// <summary>
		/// Shows the exchange rate between the currency associated with the SharePoint document record and the base currency.
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
		/// Shows the file size.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
		public System.Nullable<int> FileSize
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filesize");
			}
		}
		
		/// <summary>
		/// Shows the file type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filetype")]
		public string FileType
		{
			get
			{
				return this.GetAttributeValue<string>("filetype");
			}
		}
		
		/// <summary>
		/// Shows the full name of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
		public string FullName
		{
			get
			{
				return this.GetAttributeValue<string>("fullname");
			}
		}
		
		/// <summary>
		/// Stores the Icon Class name of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iconclassname")]
		public string IconClassName
		{
			get
			{
				return this.GetAttributeValue<string>("iconclassname");
			}
		}
		
		/// <summary>
		/// Shows whether the file is checked out.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ischeckedout")]
		public System.Nullable<bool> IsCheckedOut
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ischeckedout");
			}
		}
		
		/// <summary>
		/// Shows whether the file is a folder.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfolder")]
		public System.Nullable<bool> IsFolder
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isfolder");
			}
		}
		
		/// <summary>
		/// Shows whether to fetch data recursively from the given folder location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrecursivefetch")]
		public System.Nullable<bool> IsRecursiveFetch
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isrecursivefetch");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated document location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("locationid")]
		public string LocationId
		{
			get
			{
				return this.GetAttributeValue<string>("locationid");
			}
		}
		
		/// <summary>
		/// Name of the associated document location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("locationname")]
		public string LocationName
		{
			get
			{
				return this.GetAttributeValue<string>("locationname");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the SharePoint document was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modified")]
		public System.Nullable<System.DateTime> Modified
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modified");
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
		/// Shows who modified the record on behalf of another user.
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
		/// Unique identifier of the organization associated with the SharePoint document.
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
		/// Shows the business unit that the record owner belongs to.
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
		/// Shows the team that owns the SharePoint document record.
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
		/// Shows the user who owns the SharePoint document record.
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
		/// Shows the Read URL of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readurl")]
		public string ReadUrl
		{
			get
			{
				return this.GetAttributeValue<string>("readurl");
			}
		}
		
		/// <summary>
		/// Choose the parent record that the SharePoint document record is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Relative location of Sharepoint Document
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relativelocation")]
		public string RelativeLocation
		{
			get
			{
				return this.GetAttributeValue<string>("relativelocation");
			}
		}
		
		/// <summary>
		/// Shows the service type of the SharePoint site.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ServiceType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("servicetype");
			}
			set
			{
				this.OnPropertyChanging("ServiceType");
				this.SetAttributeValue("servicetype", value);
				this.OnPropertyChanged("ServiceType");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the SharePoint document record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointcreatedon")]
		public System.Nullable<System.DateTime> SharePointCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("sharepointcreatedon");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the SharePoint document record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdocumentid")]
		public System.Nullable<System.Guid> SharePointDocumentId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sharepointdocumentid");
			}
			set
			{
				this.OnPropertyChanging("SharePointDocumentId");
				this.SetAttributeValue("sharepointdocumentid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SharePointDocumentId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdocumentid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SharePointDocumentId = value;
			}
		}
		
		/// <summary>
		/// Shows who last updated the document record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointmodifiedby")]
		public string SharePointModifiedBy
		{
			get
			{
				return this.GetAttributeValue<string>("sharepointmodifiedby");
			}
		}
		
		/// <summary>
		/// Shows the title or name that describes the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			get
			{
				return this.GetAttributeValue<string>("title");
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
		}
		
		/// <summary>
		/// Shows the SharePoint document version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			get
			{
				return this.GetAttributeValue<string>("version");
			}
		}
		
		/// <summary>
		/// 1:N SharePointDocument_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocument_Annotation")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Annotation> SharePointDocument_Annotation
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Annotation>("SharePointDocument_Annotation", null);
			}
			set
			{
				this.OnPropertyChanging("SharePointDocument_Annotation");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Annotation>("SharePointDocument_Annotation", null, value);
				this.OnPropertyChanged("SharePointDocument_Annotation");
			}
		}
		
		/// <summary>
		/// N:1 Account_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Account Account_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("Account_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("Account_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Account>("Account_SharepointDocument", null, value);
				this.OnPropertyChanged("Account_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_sharepointdocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocument")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_sharepointdocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_sharepointdocument", null);
			}
		}
		
		/// <summary>
		/// N:1 business_unit_sharepointdocument2
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocument2")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_sharepointdocument2
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_sharepointdocument2", null);
			}
			set
			{
				this.OnPropertyChanging("business_unit_sharepointdocument2");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_sharepointdocument2", null, value);
				this.OnPropertyChanged("business_unit_sharepointdocument2");
			}
		}
		
		/// <summary>
		/// N:1 KbArticle_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.KbArticle KbArticle_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KbArticle>("KbArticle_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("KbArticle_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KbArticle>("KbArticle_SharepointDocument", null, value);
				this.OnPropertyChanged("KbArticle_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 knowledgearticle_SharePointDocuments
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgearticle_SharePointDocuments")]
		public Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle knowledgearticle_SharePointDocuments
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle>("knowledgearticle_SharePointDocuments", null);
			}
			set
			{
				this.OnPropertyChanging("knowledgearticle_SharePointDocuments");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle>("knowledgearticle_SharePointDocuments", null, value);
				this.OnPropertyChanged("knowledgearticle_SharePointDocuments");
			}
		}
		
		/// <summary>
		/// N:1 Lead_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Lead Lead_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Lead>("Lead_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("Lead_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Lead>("Lead_SharepointDocument", null, value);
				this.OnPropertyChanged("Lead_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 lk_sharepointdocumentbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sharepointdocumentbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_sharepointdocumentbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sharepointdocumentbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sharepointdocumentbase_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_sharepointdocumentbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_sharepointdocumentbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sharepointdocumentbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_sharepointdocumentbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_sharepointdocumentbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_sharepointdocumentbase_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_sharepointdocumentbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_sharepointdocumentbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 Opportunity_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Opportunity Opportunity_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("Opportunity_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("Opportunity_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("Opportunity_SharepointDocument", null, value);
				this.OnPropertyChanged("Opportunity_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 organization_sharepointdocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sharepointdocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_sharepointdocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_sharepointdocument", null);
			}
		}
		
		/// <summary>
		/// N:1 Product_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Product Product_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("Product_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("Product_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("Product_SharepointDocument", null, value);
				this.OnPropertyChanged("Product_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 Quote_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.Quote Quote_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Quote>("Quote_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("Quote_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Quote>("Quote_SharepointDocument", null, value);
				this.OnPropertyChanged("Quote_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 SalesLiterature_SharepointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_SharepointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.SalesLiterature SalesLiterature_SharepointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SalesLiterature>("SalesLiterature_SharepointDocument", null);
			}
			set
			{
				this.OnPropertyChanging("SalesLiterature_SharepointDocument");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SalesLiterature>("SalesLiterature_SharepointDocument", null, value);
				this.OnPropertyChanged("SalesLiterature_SharepointDocument");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_SharePointDocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointDocument")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency TransactionCurrency_SharePointDocument
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_SharePointDocument", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SharePointDocument(object anonymousType) : 
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
                        Attributes["sharepointdocumentid"] = base.Id;
                        break;
                    case "sharepointdocumentid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentlocationtype")]
		public virtual sharepointdocumentlocation_locationtype? DocumentLocationTypeEnum
		{
			get
			{
				return ((sharepointdocumentlocation_locationtype?)(EntityOptionSetEnum.GetEnum(this, "documentlocationtype")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicetype")]
		public virtual sharepointsite_servicetype? ServiceTypeEnum
		{
			get
			{
				return ((sharepointsite_servicetype?)(EntityOptionSetEnum.GetEnum(this, "servicetype")));
			}
			set
			{
				ServiceType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}