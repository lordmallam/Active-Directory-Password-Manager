using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class LawFirm
    {
        public int Id { get; set; }
        public string ChamberName { get; set; }
        public string Email { get; set; }
        public string AlternetiveEmail { get; set; }
        public string ChamberAddress { get; set; }
        public string DisplayName { get; set; }
        public string CreatedBy { get; set; }
    }
}
