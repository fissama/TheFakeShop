using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace TheFakeShop.IdentityServer.Configs
{
    public static class Config
    {
        private static IConfiguration _configuration;

        public static IConfiguration Configuration
        {
            get
            {
                return _configuration;
            }
        }

        public static void InitConfiguration(IConfiguration configuration) {
            _configuration = configuration;
        }

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
             new ApiScope[]
             {
                  new ApiScope("thefakeshop.api", "Rookie Shop API")
             };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                // machine to machine client
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // scopes that client has access to
                    AllowedScopes = { "thefakeshop.api" }
                },

                // interactive ASP.NET Core MVC client
                new Client
                {
                    
                    ClientId = "mvc",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { _configuration.GetValue<string>("Frontend")+"signin-oidc" },

                    PostLogoutRedirectUris = { _configuration.GetValue<string>("Frontend")+ "signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "thefakeshop.api"
                    }
                }
            };
    }
}
