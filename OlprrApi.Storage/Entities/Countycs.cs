using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class County
    {
        [Key]
        public int CountyCode { get; set; }
        public string CountyName { get; set; }
        public int SortBy { get; set; }
    }
}