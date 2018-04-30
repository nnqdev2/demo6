using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class ConfirmationType
    {
        [Key]
        public string ConfirmationCode { get; set; }
        public string ConfirmationDescription { get; set; }
        public int SortBy { get; set; }
    }
}