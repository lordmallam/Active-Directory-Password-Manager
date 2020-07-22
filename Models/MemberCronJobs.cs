using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class MemberCronJobs
    {
        public Guid Id { get; set; }
        public string LawyerEmail { get; set; }
        public string ChamberEmail { get; set; }
        public int FirmId { get; set; }
        public int LawyerId { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public string Message { get; set; }

        public virtual Firms Firm { get; set; }
        public virtual Lawyers Lawyer { get; set; }
    }
}
