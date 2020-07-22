using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Postlawyers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string EnrollmentNumber { get; set; }
        public string Nbanumber { get; set; }
        public string Adid { get; set; }
        public string OfficePhone { get; set; }
        public string MobilePhone { get; set; }
        public string AlternativePhone { get; set; }
        public string Address { get; set; }
        public string StateOfOrigin { get; set; }
        public byte[] Photo { get; set; }
        public string Status { get; set; }
        public string Sex { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public bool IsMailCreated { get; set; }
        public DateTime? MailCreated { get; set; }
        public bool IsSupremeCourtApproved { get; set; }
        public bool IsSan { get; set; }
        public bool IsAgreedToTerms { get; set; }
        public string OfficeName { get; set; }
        public string PostalCode { get; set; }
        public string PostOfficeBox { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public DateTime EmployeeStartDate { get; set; }
        public DateTime? EmployeeEndDate { get; set; }
        public string ActivationCode { get; set; }
        public string Password { get; set; }
        public bool HasUpdate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? LastLogin { get; set; }
        public int StateId { get; set; }
        public string RefNo { get; set; }
        public string PreviousName { get; set; }
        public string Comments { get; set; }
        public string Otp { get; set; }

        public virtual States State { get; set; }
    }
}
