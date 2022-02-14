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
    /// Microsoft.Dynamics.CRM.ssg_countrysubdivision
    /// </summary>
    public partial class MicrosoftDynamicsCRMssgCountrysubdivision
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCountrysubdivision class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCountrysubdivision()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMssgCountrysubdivision class.
        /// </summary>
        public MicrosoftDynamicsCRMssgCountrysubdivision(string _createdbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string ssgSubdivisioncode = default(string), string ssgProvincecodewithoutcountry = default(string), int? utcconversiontimezonecode = default(int?), string _owningteamValue = default(string), string _owninguserValue = default(string), string ssgCountrysubdivisionid = default(string), string _ssgCountryidValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string _modifiedbyValue = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ssgName = default(string), string _owneridValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ssgCountrysubdivisionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCountrysubdivisionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ssgCountrysubdivisionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ssgCountrysubdivisionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ssgCountrysubdivisionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ssgCountrysubdivisionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ssgCountrysubdivisionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ssgCountrysubdivisionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMssgCountry ssgCountryId = default(MicrosoftDynamicsCRMssgCountry), IList<MicrosoftDynamicsCRMssgAddress> ssgSsgCountrysubdivisionSsgAddressCountrySubdivision = default(IList<MicrosoftDynamicsCRMssgAddress>), IList<MicrosoftDynamicsCRMssgSearchrequest> ssgSsgCountrysubdivisionSsgSearchrequestCountrySubdivision = default(IList<MicrosoftDynamicsCRMssgSearchrequest>), IList<MicrosoftDynamicsCRMssgSearchrequest> ssgSsgCountrysubdivisionSsgSearchrequestApplicantCountrySubdivision = default(IList<MicrosoftDynamicsCRMssgSearchrequest>), IList<MicrosoftDynamicsCRMssgAgencylocation> ssgSsgCountrysubdivisionSsgAgencylocationCountrySubdivision = default(IList<MicrosoftDynamicsCRMssgAgencylocation>), IList<MicrosoftDynamicsCRMssgEmployment> ssgSsgCountrysubdivisionSsgEmploymentCountrySubDivision = default(IList<MicrosoftDynamicsCRMssgEmployment>), IList<MicrosoftDynamicsCRMssgRequestforinformationletter> ssgSsgCountrysubdivisionSsgRequestforinformationletterProvince = default(IList<MicrosoftDynamicsCRMssgRequestforinformationletter>), IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> ssgSsgCountrysubdivisionSsgAssetRealestatepropertyOwnerProvince = default(IList<MicrosoftDynamicsCRMssgAssetRealestateproperty>), IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> ssgSsgCountrysubdivisionSsgAssetRealestatepropertyPropertyProvince = default(IList<MicrosoftDynamicsCRMssgAssetRealestateproperty>), IList<MicrosoftDynamicsCRMssgAssetPensiondisability> ssgSsgCountrysubdivisionSsgAssetPensiondisabilityProviderProvinceState = default(IList<MicrosoftDynamicsCRMssgAssetPensiondisability>), IList<MicrosoftDynamicsCRMssgFamscontact> ssgSsgCountrysubdivisionSsgFamscontactProvince = default(IList<MicrosoftDynamicsCRMssgFamscontact>))
        {
            this._createdbyValue = _createdbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            SsgSubdivisioncode = ssgSubdivisioncode;
            SsgProvincecodewithoutcountry = ssgProvincecodewithoutcountry;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            SsgCountrysubdivisionid = ssgCountrysubdivisionid;
            this._ssgCountryidValue = _ssgCountryidValue;
            Statuscode = statuscode;
            Modifiedon = modifiedon;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            SsgName = ssgName;
            this._owneridValue = _owneridValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SsgCountrysubdivisionSyncErrors = ssgCountrysubdivisionSyncErrors;
            SsgCountrysubdivisionDuplicateMatchingRecord = ssgCountrysubdivisionDuplicateMatchingRecord;
            SsgCountrysubdivisionDuplicateBaseRecord = ssgCountrysubdivisionDuplicateBaseRecord;
            SsgCountrysubdivisionAsyncOperations = ssgCountrysubdivisionAsyncOperations;
            SsgCountrysubdivisionMailboxTrackingFolders = ssgCountrysubdivisionMailboxTrackingFolders;
            SsgCountrysubdivisionProcessSession = ssgCountrysubdivisionProcessSession;
            SsgCountrysubdivisionBulkDeleteFailures = ssgCountrysubdivisionBulkDeleteFailures;
            SsgCountrysubdivisionPrincipalObjectAttributeAccesses = ssgCountrysubdivisionPrincipalObjectAttributeAccesses;
            SsgCountryId = ssgCountryId;
            SsgSsgCountrysubdivisionSsgAddressCountrySubdivision = ssgSsgCountrysubdivisionSsgAddressCountrySubdivision;
            SsgSsgCountrysubdivisionSsgSearchrequestCountrySubdivision = ssgSsgCountrysubdivisionSsgSearchrequestCountrySubdivision;
            SsgSsgCountrysubdivisionSsgSearchrequestApplicantCountrySubdivision = ssgSsgCountrysubdivisionSsgSearchrequestApplicantCountrySubdivision;
            SsgSsgCountrysubdivisionSsgAgencylocationCountrySubdivision = ssgSsgCountrysubdivisionSsgAgencylocationCountrySubdivision;
            SsgSsgCountrysubdivisionSsgEmploymentCountrySubDivision = ssgSsgCountrysubdivisionSsgEmploymentCountrySubDivision;
            SsgSsgCountrysubdivisionSsgRequestforinformationletterProvince = ssgSsgCountrysubdivisionSsgRequestforinformationletterProvince;
            SsgSsgCountrysubdivisionSsgAssetRealestatepropertyOwnerProvince = ssgSsgCountrysubdivisionSsgAssetRealestatepropertyOwnerProvince;
            SsgSsgCountrysubdivisionSsgAssetRealestatepropertyPropertyProvince = ssgSsgCountrysubdivisionSsgAssetRealestatepropertyPropertyProvince;
            SsgSsgCountrysubdivisionSsgAssetPensiondisabilityProviderProvinceState = ssgSsgCountrysubdivisionSsgAssetPensiondisabilityProviderProvinceState;
            SsgSsgCountrysubdivisionSsgFamscontactProvince = ssgSsgCountrysubdivisionSsgFamscontactProvince;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_subdivisioncode")]
        public string SsgSubdivisioncode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_provincecodewithoutcountry")]
        public string SsgProvincecodewithoutcountry { get; set; }

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
        [JsonProperty(PropertyName = "ssg_countrysubdivisionid")]
        public string SsgCountrysubdivisionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ssg_countryid_value")]
        public string _ssgCountryidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_name")]
        public string SsgName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "ssg_countrysubdivision_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SsgCountrysubdivisionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCountrysubdivisionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SsgCountrysubdivisionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SsgCountrysubdivisionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SsgCountrysubdivisionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SsgCountrysubdivisionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SsgCountrysubdivisionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_countrysubdivision_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SsgCountrysubdivisionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_CountryId")]
        public MicrosoftDynamicsCRMssgCountry SsgCountryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_address_CountrySubdivision")]
        public IList<MicrosoftDynamicsCRMssgAddress> SsgSsgCountrysubdivisionSsgAddressCountrySubdivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_searchrequest_CountrySubdivision")]
        public IList<MicrosoftDynamicsCRMssgSearchrequest> SsgSsgCountrysubdivisionSsgSearchrequestCountrySubdivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_searchrequest_ApplicantCountrySubdivision")]
        public IList<MicrosoftDynamicsCRMssgSearchrequest> SsgSsgCountrysubdivisionSsgSearchrequestApplicantCountrySubdivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_agencylocation_CountrySubdivision")]
        public IList<MicrosoftDynamicsCRMssgAgencylocation> SsgSsgCountrysubdivisionSsgAgencylocationCountrySubdivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_employment_CountrySubDivision")]
        public IList<MicrosoftDynamicsCRMssgEmployment> SsgSsgCountrysubdivisionSsgEmploymentCountrySubDivision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_requestforinformationletter_Province")]
        public IList<MicrosoftDynamicsCRMssgRequestforinformationletter> SsgSsgCountrysubdivisionSsgRequestforinformationletterProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_asset_realestateproperty_OwnerProvince")]
        public IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> SsgSsgCountrysubdivisionSsgAssetRealestatepropertyOwnerProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_asset_realestateproperty_PropertyProvince")]
        public IList<MicrosoftDynamicsCRMssgAssetRealestateproperty> SsgSsgCountrysubdivisionSsgAssetRealestatepropertyPropertyProvince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_asset_pensiondisability_ProviderProvinceState")]
        public IList<MicrosoftDynamicsCRMssgAssetPensiondisability> SsgSsgCountrysubdivisionSsgAssetPensiondisabilityProviderProvinceState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssg_ssg_countrysubdivision_ssg_famscontact_Province")]
        public IList<MicrosoftDynamicsCRMssgFamscontact> SsgSsgCountrysubdivisionSsgFamscontactProvince { get; set; }

    }
}
