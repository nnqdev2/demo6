using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class SiteTypeT
    {
        [Key]
        public string SiteTypeCode { get; set; }

        public string SiteType { get; set; }
    }
}