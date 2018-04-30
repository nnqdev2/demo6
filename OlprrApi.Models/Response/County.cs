using System;
using System.Collections.Generic;
using System.Text;

namespace OlprrApi.Models.Response
{
    public class County
    {
        public int CountyCode { get; set; }
        public string CountyName { get; set; }
        public int SortBy { get; set; }
    }
}
