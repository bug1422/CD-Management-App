﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Request
    {
        public Request()
        {
            ActivityLogs = new HashSet<ActivityLog>();
        }

        public int RequestId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime SubmitDate { get; set; }

        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}
