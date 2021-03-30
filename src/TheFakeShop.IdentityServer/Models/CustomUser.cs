using Microsoft.AspNetCore.Identity;

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

        [PersonalData]
        public bool gender { get; set; }
    }
}