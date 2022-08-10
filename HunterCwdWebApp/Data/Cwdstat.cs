using System;
using System.Collections.Generic;

namespace HunterCwdWebApp.Data
{
    public partial class Cwdstat
    {
        public string State { get; set; } = null!;
        public string County { get; set; } = null!;
        public int Year { get; set; }
        public int? PositiveTestCount { get; set; }
        public int? TotalTestCount { get; set; }
    }
}
