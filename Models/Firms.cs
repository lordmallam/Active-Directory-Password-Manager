using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Firms
    {
        public Firms()
        {
            FirmDocuments = new HashSet<FirmDocuments>();
            FirmLawyers = new HashSet<FirmLawyers>();
            MemberCronJobs = new HashSet<MemberCronJobs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public bool IsCreated { get; set; }
        public int LocationStateId { get; set; }
        public int RegisteredStateId { get; set; }
        public int LawyerId { get; set; }
        public string Status { get; set; }

        public virtual States LocationState { get; set; }
        public virtual States RegisteredState { get; set; }
        public virtual ICollection<FirmDocuments> FirmDocuments { get; set; }
        public virtual ICollection<FirmLawyers> FirmLawyers { get; set; }
        public virtual ICollection<MemberCronJobs> MemberCronJobs { get; set; }
    }
}
