using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class ReleaseCauseType
    {
        [Key]
        public string ReleaseCauseCode { get; set; }
        public string ReleaseCauseDescription { get; set; }
        public int SortBy { get; set; }
    }
}
