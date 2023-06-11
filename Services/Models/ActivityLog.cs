using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class ActivityLog
    {
        public int ActivityId { get; set; }
        public int AccountId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Activity { get; set; }
        public int RequestId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Request Request { get; set; }
    }
}
