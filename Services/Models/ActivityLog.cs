using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class ActivityLog
    {
        public int ActivityId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Activity { get; set; }
    }
}
