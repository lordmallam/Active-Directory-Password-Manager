using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Stagings
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string EnrollmentNumber { get; set; }
        public string Nbanumber { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string StateOfOrigin { get; set; }
        public byte[] Photo { get; set; }
        public string Status { get; set; }
        public string Sex { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsSan { get; set; }
        public string OfficeName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string PreviousName { get; set; }
        public DateTime? CallToBar { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? Submitted { get; set; }
    }
}
