using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Approvers
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Adid { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public int StateId { get; set; }
        public string DisplayName { get; set; }
        public string Username { get; set; }

        public virtual States State { get; set; }
    }
}
