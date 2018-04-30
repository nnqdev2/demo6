using System;
using System.ComponentModel.DataAnnotations;

namespace OlprrApi.Storage.Entities
{
    public class QuadrantT
    {
        [Key]
        public string Quadrant { get; set; }
        public int SortBy { get; set; }

    }
}