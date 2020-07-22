using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class States
    {
        public States()
        {
            Applications = new HashSet<Applications>();
            Approvers = new HashSet<Approvers>();
            FirmsLocationState = new HashSet<Firms>();
            FirmsRegisteredState = new HashSet<Firms>();
            Lawyers = new HashSet<Lawyers>();
            Postlawyers = new HashSet<Postlawyers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Applications> Applications { get; set; }
        public virtual ICollection<Approvers> Approvers { get; set; }
        public virtual ICollection<Firms> FirmsLocationState { get; set; }
        public virtual ICollection<Firms> FirmsRegisteredState { get; set; }
        public virtual ICollection<Lawyers> Lawyers { get; set; }
        public virtual ICollection<Postlawyers> Postlawyers { get; set; }
    }
}
