using System;
using System.Collections.Generic;

namespace HunterCwdWebApp.Data
{
    public partial class Cwd
    {
        public string? State { get; set; }
        public string? County { get; set; }
        public int? PositiveTestCount { get; set; }
        public int? TotalTestCount { get; set; }
        public int? Year { get; set; }
    }
}
