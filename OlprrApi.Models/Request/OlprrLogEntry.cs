using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlprrApi.Models.Request
{
    public enum OlprrLogLevel
    {
        All = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5,
        Off = 6
    }
    public class OlprrLogEntry
    {
        [Required]
        public string EntryDate { get; set; }
        [Required]
        public string Message { get; set; }
        [Column("Level")]
        [Required]
        public string LogLevel { get; set; }
        public bool LogWithDate { get; set; }
    }
}