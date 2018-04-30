using System;
using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Models.Request
{
    public class ApOLPRRInsertIncident
    {

        [Required]
        //[MaxLength(20)]
        public string ContractorUid { get; set; }

        [Required]
        //[MaxLength(20)]
        public string ContractorPwd { get; set; }

        [Required]
        //[MaxLength(50)]
        public string ReportedBy { get; set; }

        //[MaxLength(25)]
        public string ReportedByPhone { get; set; }

        //[MaxLength(75)]
        public string ReportedByEmail { get; set; }

        [Required]
        //[MaxLength(1)]
        public string ReleaseType { get; set; }

        public DateTime DateReceived { get; set; }

        public int FacilityId { get; set; }

        //[MaxLength(40)]
        public string SiteName { get; set; }

        //[MaxLength(2)]
        public string SiteCounty { get; set; }

        //[MaxLength(11)]
        public string StreetNbr { get; set; }

        //[MaxLength(2)]
        public string StreetQuad { get; set; }

        //[MaxLength(30)]
        public string StreetName { get; set; }

        //[MaxLength(10)]
        public string StreetType { get; set; }

        //[MaxLength(40)]
        public string SiteAddress { get; set; }

        //[MaxLength(25)]
        public string SiteCity { get; set; }

        //[MaxLength(10)]
        public string SiteZipcode { get; set; }

        //[MaxLength(25)]
        public string SitePhone { get; set; }

        //[MaxLength(720)]
        public string InitialComment { get; set; }

        public DateTime DiscoveryDate { get; set; }

        //[MaxLength(2)]
        public string ConfirmationCode { get; set; }

        //[MaxLength(2)]
        public string DiscoveryCode { get; set; }

        //[MaxLength(2)]
        public string CauseCode { get; set; }

        //[MaxLength(2)]
        public int SourceId { get; set; }

        // Responsible Party data

        //[MaxLength(20)]
        public string RpFirstName { get; set; }

        //[MaxLength(20)]
        public string RpLastName { get; set; }

        //[MaxLength(40)]
        public string RpOrganization { get; set; }

        //[MaxLength(40)]
        public string RpAddress { get; set; }

        //[MaxLength(40)]
        public string RpAddress2 { get; set; }

        //[MaxLength(25)]
        public string RpCity { get; set; }

        //[MaxLength(2)]
        public string RpState { get; set; }

        //[MaxLength(10)]
        public string RpZipcode { get; set; }

        //[MaxLength(30)]
        public string RpPhone { get; set; }

        //[MaxLength(30)]
        public string RpEmail { get; set; }

        // IC data

        //[MaxLength(20)]
        public string IcFirstName { get; set; }

        //[MaxLength(20)]
        public string IcLastName { get; set; }

        //[MaxLength(40)]
        public string IcOrganization { get; set; }

        //[MaxLength(40)]
        public string IcAddress { get; set; }

        //[MaxLength(40)]
        public string IcAddress2 { get; set; }

        //[MaxLength(25)]
        public string IcCity { get; set; }

        //[MaxLength(2)]
        public string IcState { get; set; }

        //[MaxLength(10)]
        public string IcZipcode { get; set; }

        //[MaxLength(30)]
        public string IcPhone { get; set; }

        //[MaxLength(30)]
        public string IcEmail { get; set; }

        //Media data

        public int GroundWater { get; set; }

        public int SurfaceWater { get; set; }

        public int DringkingWater { get; set; }

        public int Soil { get; set; }

        public int Vapor { get; set; }

        public int FreeProduct { get; set; }

        //Contamimnant data

        public int UnleadedGas { get; set; }

        public int LeadedGas { get; set; }

        public int MisGas { get; set; }

        public int Diesel { get; set; }

        public int WasteOil { get; set; }

        public int HeatingOil { get; set; }

        public int Lubricant { get; set; }

        public int Solvent { get; set; }

        public int OtherPet { get; set; }

        public int Chemical { get; set; }

        public int Unknown { get; set; }

        public int Mtbe { get; set; }

        public string SubmitDateTime { get; set; }

        //Deq Office for  E-Mail Notification
        //[MaxLength(3)]
        public string DeqOffice { get; set; }















        //[MaxLength(20)]
        //public string ContractorUid { get; set; }

        //[MaxLength(20)]
        //public string ContractorPwd { get; set; }

        //[MaxLength(50)]
        //public string ReportedBy { get; set; }

        //[MaxLength(25)]
        //public string ReportedByPhone { get; set; }

        //[MaxLength(75)]
        //public string ReportedByEmail { get; set; }

        //[MaxLength(1)]
        //public string ReleaseType { get; set; }

        //public DateTime DateReceived { get; set; }

        //public int FacilityId { get; set; }

        //[MaxLength(40)]
        //public string SiteName { get; set; }

        //[MaxLength(2)]
        //public string SiteCounty { get; set; }

        //[MaxLength(11)]
        //public string StreetNbr { get; set; }

        //[MaxLength(2)]
        //public string StreetQuad { get; set; }

        //[MaxLength(30)]
        //public string StreetName { get; set; }

        //[MaxLength(10)]
        //public string StreetType { get; set; }

        //[MaxLength(40)]
        //public string SiteAddress { get; set; }

        //[MaxLength(25)]
        //public string SiteCity { get; set; }

        //[MaxLength(10)]
        //public string SiteZipcode { get; set; }

        //[MaxLength(25)]
        //public string SitePhone { get; set; }

        //[MaxLength(720)]
        //public string InitialComment { get; set; }

        //public DateTime DiscoveryDate { get; set; }

        //[MaxLength(2)]
        //public string ConfirmationCode { get; set; }

        //[MaxLength(2)]
        //public string DiscoveryCode { get; set; }

        //[MaxLength(2)]
        //public string CauseCode { get; set; }

        //[MaxLength(2)]
        //public int SourceId { get; set; }

        //// Responsible Party data

        //[MaxLength(20)]
        //public string RpFirstName { get; set; }

        //[MaxLength(20)]
        //public string RpLastName { get; set; }

        //[MaxLength(40)]
        //public string RpOrganization { get; set; }

        //[MaxLength(40)]
        //public string RpAddress { get; set; }

        //[MaxLength(40)]
        //public string RpAddress2 { get; set; }

        //[MaxLength(25)]
        //public string RpCity { get; set; }

        //[MaxLength(2)]
        //public string RpState { get; set; }

        //[MaxLength(10)]
        //public string RpZipcode { get; set; }

        //[MaxLength(30)]
        //public string RpPhone { get; set; }

        //[MaxLength(30)]
        //public string RpEmail { get; set; }

        //// IC data

        //[MaxLength(20)]
        //public string IcFirstName { get; set; }

        //[MaxLength(20)]
        //public string IcLastName { get; set; }

        //[MaxLength(40)]
        //public string IcOrganization { get; set; }

        //[MaxLength(40)]
        //public string IcAddress { get; set; }

        //[MaxLength(40)]
        //public string IcAddress2 { get; set; }

        //[MaxLength(25)]
        //public string IcCity { get; set; }

        //[MaxLength(2)]
        //public string IcState { get; set; }

        //[MaxLength(10)]
        //public string IcZipcode { get; set; }

        //[MaxLength(30)]
        //public string IcPhone { get; set; }

        //[MaxLength(30)]
        //public string IcEmail { get; set; }

        ////Media data

        //public int GroundWater { get; set; }

        //public int SurfaceWater { get; set; }

        //public int DringkingWater { get; set; }

        //public int Soil { get; set; }

        //public int Vapor { get; set; }

        //public int FreeProduct { get; set; }

        ////Contamimnant data

        //public int UnleadedGas { get; set; }

        //public int LeadedGas { get; set; }

        //public int MisGas { get; set; }

        //public int Diesel { get; set; }

        //public int WasteOil { get; set; }

        //public int HeatingOil { get; set; }

        //public int Lubricant { get; set; }

        //public int Solvent { get; set; }

        //public int OtherPet { get; set; }

        //public int Chemical { get; set; }

        //public int Unknown { get; set; }

        //public int Mtbe { get; set; }

        //public string SubmitDateTime { get; set; }

        ////Deq Office for  E-Mail Notification
        //[MaxLength(3)]
        //public string DeqOffice { get; set; }
    }
}
