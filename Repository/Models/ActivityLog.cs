using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class ActivityLog
    {
        public int ActivityId { get; set; }
        public int AccountId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Activity { get; set; }
        public int AlbumId { get; set; }
        public int RequestId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Cdalbum Album { get; set; }
        public virtual CustomerRequest Request { get; set; }
    }
}
