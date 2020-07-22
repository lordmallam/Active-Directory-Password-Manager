using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class DocumentTypes
    {
        public DocumentTypes()
        {
            Documents = new HashSet<Documents>();
            FirmDocuments = new HashSet<FirmDocuments>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public int DocumentId { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
        public virtual ICollection<FirmDocuments> FirmDocuments { get; set; }
    }
}
