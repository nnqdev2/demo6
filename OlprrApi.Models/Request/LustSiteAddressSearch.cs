using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlprrApi.Models.Request
{
    public class LustSiteAddressSearch
    {
        [MaxLength(40)]
        public string SiteName { get; set; }
        [MaxLength(40)]
        public string SiteAddress { get; set; }
        [MaxLength(25)]
        public string SiteCity { get; set; }
        [MaxLength(5)]
        public string SiteZip { get; set; }
        [Range(0, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        //[Range(0, 5)]
        public int? OrderBy { get; set; }
    }
}