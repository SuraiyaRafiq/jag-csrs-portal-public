// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.ssg_autonumberdefinition
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgAutonumberdefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAutonumberdefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAutonumberdefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgAutonumberdefinition class.
        /// </summary>
        public MicrosoftDynamicsCRMssgAutonumberdefinition(string _owneridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string versionnumber = default(string), int? statecode = default(int?), int? statuscode = default(int?), string _owningbusinessunitValue = default(string), string ssgPaddingeightdigits = default(string), int? ssgLastnumber = default(int?), string ssgAutonumberdefinitionid = default(string), string ssgName = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string ssgPadding = default(string), int? utcconversiontimezonecode = default(int?), string _owningteamValue = default(string), string _owninguserValue = default(string), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgAutonumberdefinitionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAutonumberdefinitionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgAutonumberdefinitionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgAutonumberdefinitionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgAutonumberdefinitionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgAutonumberdefinitionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgAutonumberdefinitionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgAutonumberdefinitionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMssgSearchrequest> ssgSsgAutonumberdefinitionSsgSearchrequestAutoNumberDefinition = default(IList<MicrosoftDynamicsCRMssgSearchrequest>), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgAutonumberdefinitionSsgRequestforinformationletterAutoNumberDefinitionId = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>), IList<MicrosoftDynamicsCRMssgSearchapirequest> ssgSsgAutonumberdefinitionSsgSearchapirequestAutoNumberDefinition = default(IList<MicrosoftDynamicsCRMssgSearchapirequest>), IList<MicrosoftDynamicsCRMssgConfirmedprofile> ssgSsgAutonumberdefinitionSsgConfirmedprofileAutoNumberDefinition = default(IList<MicrosoftDynamicsCRMssgConfirmedprofile>))
        {
            this._owneridValue = _owneridValue;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Versionnumber = versionnumber;
            Statecode = statecode;
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgPaddingeightdigits = ssgPaddingeightdigits;
            SsgLastnumber = ssgLastnumber;
            SsgAutonumberdefinitionid = ssgAutonumberdefinitionid;
            SsgName = ssgName;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            SsgPadding = ssgPadding;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgAutonumberdefinitionSyncErrors = ssgAutonumberdefinitionSyncErrors;
            SsgAutonumberdefinitionDuplicateMatchingRecord = ssgAutonumberdefinitionDuplicateMatchingRecord;
            SsgAutonumberdefinitionDuplicateBaseRecord = ssgAutonumberdefinitionDuplicateBaseRecord;
            SsgAutonumberdefinitionAsyncOperations = ssgAutonumberdefinitionAsyncOperations;
            SsgAutonumberdefinitionMailboxTrackingFolders = ssgAutonumberdefinitionMailboxTrackingFolders;
            SsgAutonumberdefinitionProcessSession = ssgAutonumberdefinitionProcessSession;
            SsgAutonumberdefinitionBulkDeleteFailures = ssgAutonumberdefinitionBulkDeleteFailures;
            SsgAutonumberdefinitionPrincipalObjectAttributeAccesses = ssgAutonumberdefinitionPrincipalObjectAttributeAccesses;
            SsgSsgAutonumberdefinitionSsgSearchrequestAutoNumberDefinition = ssgSsgAutonumberdefinitionSsgSearchrequestAutoNumberDefinition;
            SsgSsgAutonumberdefinitionSsgRequestforinformationletterAutoNumberDefinitionId = ssgSsgAutonumberdefinitionSsgRequestforinformationletterAutoNumberDefinitionId;
            SsgSsgAutonumberdefinitionSsgSearchapirequestAutoNumberDefinition = ssgSsgAutonumberdefinitionSsgSearchapirequestAutoNumberDefinition;
            SsgSsgAutonumberdefinitionSsgConfirmedprofileAutoNumberDefinition = ssgSsgAutonumberdefinitionSsgConfirmedprofileAutoNumberDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_paddingeightdigits")]
        public string SsgPaddingeightdigits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_lastnumber")]
        public int? SsgLastnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinitionid")]
        public string SsgAutonumberdefinitionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_padding")]
        public string SsgPadding { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgAutonumberdefinitionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAutonumberdefinitionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgAutonumberdefinitionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgAutonumberdefinitionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgAutonumberdefinitionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgAutonumberdefinitionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgAutonumberdefinitionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_autonumberdefinition_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgAutonumberdefinitionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_autonumberdefinition_ssg_searchrequest_AutoNumberDefinition")]
        public IList<MicrosoftDynamicsCRMssgSearchrequest> SsgSsgAutonumberdefinitionSsgSearchrequestAutoNumberDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_autonumberdefinition_ssg_requestforinformationletter_AutoNumberDefinitionId")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgAutonumberdefinitionSsgRequestforinformationletterAutoNumberDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_autonumberdefinition_ssg_searchapirequest_AutoNumberDefinition")]
        public IList<MicrosoftDynamicsCRMssgSearchapirequest> SsgSsgAutonumberdefinitionSsgSearchapirequestAutoNumberDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_autonumberdefinition_ssg_confirmedprofile_AutoNumberDefinition")]
        public IList<MicrosoftDynamicsCRMssgConfirmedprofile> SsgSsgAutonumberdefinitionSsgConfirmedprofileAutoNumberDefinition { get; set; }

    }
}
