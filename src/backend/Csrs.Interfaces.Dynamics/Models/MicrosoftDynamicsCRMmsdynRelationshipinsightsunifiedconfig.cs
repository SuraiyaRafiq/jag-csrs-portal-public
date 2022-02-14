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
    /// Microsoft.Dynamics.CRM.msdyn_relationshipinsightsunifiedconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRelationshipinsightsunifiedconfig(string _owningteamValue = default(string), int? importsequencenumber = default(int?), string _owneridValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), bool? msdynUsenewconfigexperience = default(bool?), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string newName = default(string), int? statuscode = default(int?), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), string msdynRelationshipinsightsunifiedconfigid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owninguserValue = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> msdynRelationshipinsightsunifiedconfigSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynRelationshipinsightsunifiedconfigDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> msdynRelationshipinsightsunifiedconfigDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> msdynRelationshipinsightsunifiedconfigAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynRelationshipinsightsunifiedconfigMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynRelationshipinsightsunifiedconfigProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynRelationshipinsightsunifiedconfigBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynRelationshipinsightsunifiedconfigPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            this._owneridValue = _owneridValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            MsdynUsenewconfigexperience = msdynUsenewconfigexperience;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            NewName = newName;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            MsdynRelationshipinsightsunifiedconfigid = msdynRelationshipinsightsunifiedconfigid;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            MsdynRelationshipinsightsunifiedconfigSyncErrors = msdynRelationshipinsightsunifiedconfigSyncErrors;
            MsdynRelationshipinsightsunifiedconfigDuplicateMatchingRecord = msdynRelationshipinsightsunifiedconfigDuplicateMatchingRecord;
            MsdynRelationshipinsightsunifiedconfigDuplicateBaseRecord = msdynRelationshipinsightsunifiedconfigDuplicateBaseRecord;
            MsdynRelationshipinsightsunifiedconfigAsyncOperations = msdynRelationshipinsightsunifiedconfigAsyncOperations;
            MsdynRelationshipinsightsunifiedconfigMailboxTrackingFolders = msdynRelationshipinsightsunifiedconfigMailboxTrackingFolders;
            MsdynRelationshipinsightsunifiedconfigProcessSession = msdynRelationshipinsightsunifiedconfigProcessSession;
            MsdynRelationshipinsightsunifiedconfigBulkDeleteFailures = msdynRelationshipinsightsunifiedconfigBulkDeleteFailures;
            MsdynRelationshipinsightsunifiedconfigPrincipalObjectAttributeAccesses = msdynRelationshipinsightsunifiedconfigPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_usenewconfigexperience")]
        public bool? MsdynUsenewconfigexperience { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_name")]
        public string NewName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfigid")]
        public string MsdynRelationshipinsightsunifiedconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MsdynRelationshipinsightsunifiedconfigSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynRelationshipinsightsunifiedconfigDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MsdynRelationshipinsightsunifiedconfigDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MsdynRelationshipinsightsunifiedconfigAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynRelationshipinsightsunifiedconfigMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MsdynRelationshipinsightsunifiedconfigProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynRelationshipinsightsunifiedconfigBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynRelationshipinsightsunifiedconfigPrincipalObjectAttributeAccesses { get; set; }

    }
}
