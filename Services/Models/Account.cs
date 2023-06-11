﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Account
    {
        public Account()
        {
            ActivityLogs = new HashSet<ActivityLog>();
        }

        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string RoleId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}
