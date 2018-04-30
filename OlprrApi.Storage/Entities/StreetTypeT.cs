using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class StreetTypeT
    {
        [Key]
        public string StreetType { get; set; }
        public int SortBy { get; set; }
    }
}

