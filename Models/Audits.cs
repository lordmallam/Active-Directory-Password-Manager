using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Audits
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Entity { get; set; }
        public string Action { get; set; }
        public DateTime Created { get; set; }
        public string PerformedBy { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
    }
}
