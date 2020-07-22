using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class FirmLawyers
    {
        public Guid Id { get; set; }
        public int LawyerId { get; set; }
        public int FirmId { get; set; }

        public virtual Firms Firm { get; set; }
        public virtual Lawyers Lawyer { get; set; }
    }
}
