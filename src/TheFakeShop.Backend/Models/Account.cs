using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string RememberToken { get; set; }
        public int? DistrictId { get; set; }
        public byte[] ModifiedAt { get; set; }

        public virtual District District { get; set; }
    }
}
