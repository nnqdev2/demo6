using System;
using System.Collections.Generic;
using System.Text;

namespace OlprrApi.Models.Response
{
    public class LustSiteAddressSearch
    { 
        public int LustId { get; set; }
        public string LogNumber { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string SiteCity { get; set; }
        public string SiteZip { get; set; }
        public string Status { get; set; }
    }
}
