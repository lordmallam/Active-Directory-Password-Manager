using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class FirmDocuments
    {
        public int Id { get; set; }
        public byte[] File { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public int DocumentTypeId { get; set; }
        public int FirmId { get; set; }

        public virtual DocumentTypes DocumentType { get; set; }
        public virtual Firms Firm { get; set; }
    }
}
