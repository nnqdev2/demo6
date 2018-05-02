using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlprrApi.Storage.Entities
{
    public class ApOlprrInsertIncident
    {
        [Column("ERR_NUM")]
        public int ErrNum { get; set; }

        [Key]
        [Column("CONTRACTOR_UID")]
        [MaxLength(20)]
        public string ContractorUid { get; set; }

        [Column("CONTRACTOR_PWD")]
        [MaxLength(20)]
        public string ContractorPwd { get; set; }

        [Column("REPORTED_BY")]
        [MaxLength(50)]
        public string ReportedBy { get; set; }

        [Column("REPORTED_BY_PHONE")]
        [MaxLength(25)]
        public string ReportedByPhone { get; set; }

        [Column("REPORTED_BY_EMAIL")]
        [MaxLength(75)]
        public string ReportedByEmail { get; set; }

        [Column("RELEASE_TYPE")]
        [MaxLength(1)]
        public string ReleaseType { get; set; }

        [Column("DATE_RECEIVED")]
        public DateTime DateReceived { get; set; }

        [Column("FACILITY_ID")]
        public int FacilityId { get; set; }

        [Column("SITE_NAME")]
        [MaxLength(40)]
        public string SiteName { get; set; }

        [Column("SITE_COUNTY")]
        [MaxLength(2)]
        public string SiteCounty { get; set; }

        [Column("STREET_NBR")]
        [MaxLength(11)]
        public string StreetNbr { get; set; }

        [Column("STREET_QUAD")]
        [MaxLength(2)]
        public string StreetQuad { get; set; }

        [Column("STREET_NAME")]
        [MaxLength(30)]
        public string StreetName { get; set; }

        [Column("STREET_TYPE")]
        [MaxLength(10)]
        public string StreetType { get; set; }

        [Column("SITE_ADDRESS")]
        [MaxLength(40)]
        public string SiteAddress { get; set; }

        [Column("SITE_CITY")]
        [MaxLength(25)]
        public string SiteCity { get; set; }

        [Column("SITE_ZIPCODE")]
        [MaxLength(10)]
        public string SiteZipcode { get; set; }

        [Column("SITE_PHONE")]
        [MaxLength(25)]
        public string SitePhone { get; set; }

        [Column("INITIAL_COMMENT")]
        [MaxLength(720)]
        public string InitialComment { get; set; }

        [Column("DISCOVERY_DATE")]
        public DateTime DiscoveryDate { get; set; }

        [Column("CONFIRMATION_CODE")]
        [MaxLength(2)]
        public string ConfirmationCode { get; set; }

        [Column("DISCOVERY_CODE")]
        [MaxLength(2)]
        public string DiscoveryCode { get; set; }

        [Column("CAUSE_CODE")]
        [MaxLength(2)]
        public string CauseCode { get; set; }

        [Column("SOURCEID")]
        [MaxLength(2)]
        public int SourceId { get; set; }

        // Responsible Party data

        [Column("RP_FIRSTNAME")]
        [MaxLength(20)]
        public string RpFirstName { get; set; }

        [Column("RP_LASTNAME")]
        [MaxLength(20)]
        public string RpLastName { get; set; }

        [Column("RP_ORGANIZATION")]
        [MaxLength(40)]
        public string RpOrganization { get; set; }

        [Column("RP_ADDRESS")]
        [MaxLength(40)]
        public string RpAddress { get; set; }

        [Column("RP_ADDRESS2")]
        [MaxLength(40)]
        public string RpAddress2 { get; set; }

        [Column("RP_CITY")]
        [MaxLength(25)]
        public string RpCity { get; set; }

        [Column("RP_STATE")]
        [MaxLength(2)]
        public string RpState { get; set; }

        [Column("RP_ZIPCODE")]
        [MaxLength(10)]
        public string RpZipcode { get; set; }

        [Column("RP_PHONE")]
        [MaxLength(30)]
        public string RpPhone { get; set; }

        [Column("RP_EMAIL")]
        [MaxLength(30)]
        public string RpEmail { get; set; }

        // IC data

        [Column("IC_FIRSTNAME")]
        [MaxLength(20)]
        public string IcFirstName { get; set; }

        [Column("IC_LASTNAME")]
        [MaxLength(20)]
        public string IcLastName { get; set; }

        [Column("IC_ORGANIZATION")]
        [MaxLength(40)]
        public string IcOrganization { get; set; }

        [Column("IC_ADDRESS")]
        [MaxLength(40)]
        public string IcAddress { get; set; }

        [Column("IC_ADDRESS2")]
        [MaxLength(40)]
        public string IcAddress2 { get; set; }

        [Column("IC_CITY")]
        [MaxLength(25)]
        public string IcCity { get; set; }

        [Column("IC_STATE")]
        [MaxLength(2)]
        public string IcState { get; set; }

        [Column("IC_ZIPCODE")]
        [MaxLength(10)]
        public string IcZipcode { get; set; }

        [Column("IC_PHONE")]
        [MaxLength(30)]
        public string IcPhone { get; set; }

        [Column("IC_EMAIL")]
        [MaxLength(30)]
        public string IcEmail { get; set; }

        //Media data

        [Column("GROUNDWATER")]
        public int GroundWater { get; set; }

        [Column("SURFACEWATER")]
        public int SurfaceWater { get; set; }

        [Column("DRINKINGWATER")]
        public int DringkingWater { get; set; }

        [Column("SOIL")]
        public int Soil { get; set; }

        [Column("VAPOR")]
        public int Vapor { get; set; }

        [Column("FREEPRODUCT")]
        public int FreeProduct { get; set; }

        //Contamimnant data

        [Column("UNLEADEDGAS")]
        public int UnleadedGas { get; set; }

        [Column("LEADEDGAS")]
        public int LeadedGas { get; set; }

        [Column("MISGAS")]
        public int MisGas { get; set; }

        [Column("DIESEL")]
        public int Diesel { get; set; }

        [Column("WASTEOIL")]
        public int WasteOil { get; set; }

        [Column("HEATINGOIL")]
        public int HeatingOil { get; set; }

        [Column("LUBRICANT")]
        public int Lubricant { get; set; }

        [Column("SOLVENT")]
        public int Solvent { get; set; }

        [Column("OTHERPET")]
        public int OtherPet { get; set; }

        [Column("CHEMICAL")]
        public int Chemical { get; set; }

        [Column("UNKNOWN")]
        public int Unknown { get; set; }

        [Column("MTBE")]
        public int Mtbe { get; set; }

        [Column("SUBMIT_DATETIME")]
        public string SubmitDateTime { get; set; }

        //Deq Office for  E-Mail Notification
        [Column("DEQ_OFFICE")]
        [MaxLength(3)]
        public string DeqOffice { get; set; }
    }
}
