using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFakeShop.IdentityServer.Models
{
    public class CustomUser : IdentityUser
    {
        public CustomUser() : base()
        {
        }

        public CustomUser(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }
    }
}
