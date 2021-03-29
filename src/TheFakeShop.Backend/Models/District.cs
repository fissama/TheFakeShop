using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class District
    {
        public District()
        {
            Accounts = new HashSet<Account>();
        }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
