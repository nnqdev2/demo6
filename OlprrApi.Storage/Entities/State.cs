using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlprrApi.Storage.Entities
{
    public class State
    {
        [Key]
        [Column("STATE_CODE")]
        public string StateCode { get; set; }
        [Column("STATE_NAME")]
        public string StateName { get; set; }
        public int SortBy { get; set; }
    }
}