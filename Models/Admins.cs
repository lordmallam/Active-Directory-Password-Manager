using System;
using System.Collections.Generic;

namespace ADPasswordManager.Models
{
    public partial class Admins
    {
        public long Id { get; set; }
        public Guid Uuid { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string Address { get; set; }
        public string CreatedBy { get; set; }
        public int? Who { get; set; }
        public bool? Active { get; set; }
        public string Password { get; set; }
        public long? LastSeen { get; set; }
        public DateTime? Dob { get; set; }
        public long? CountdownPass { get; set; }
        public long? CountdownOtp { get; set; }
        public string Otp { get; set; }
        public string Token { get; set; }
        public string ThemeType { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public string RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
