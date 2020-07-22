using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class ChamberCronJobs
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int LawyerId { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

        public virtual Lawyers Lawyer { get; set; }
    }
}
