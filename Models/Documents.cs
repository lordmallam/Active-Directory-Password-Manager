using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Documents
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] File { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public int DocumentTypeId { get; set; }
        public bool IsApprovalDocument { get; set; }
        public int LawyerId { get; set; }

        public virtual DocumentTypes DocumentType { get; set; }
        public virtual Lawyers Lawyer { get; set; }
    }
}
