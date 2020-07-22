using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class VerifiedLists
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string NameChange { get; set; }
        public string EnrollmentNo { get; set; }
        public string Sex { get; set; }
        public string DoB { get; set; }
        public string StateOfOrigin { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long? YearOfCall { get; set; }
        public string Phone { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
    }
}
