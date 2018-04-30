using System;
using System.Collections.Generic;
using System.Text;

namespace OlprrApi.Storage.Entities
{
    public class LustSiteAddressSearch
    {
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string SiteCity { get; set; }
        public string SiteZip { get; set; }
        public int? OrderBy { get; set; }
    }
}