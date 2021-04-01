using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheFakeShop.IdentityServer.Contexts;
using TheFakeShop.IdentityServer.Models;

[assembly: HostingStartup(typeof(TheFakeShop.IdentityServer.Areas.Identity.IdentityHostingStartup))]
namespace TheFakeShop.IdentityServer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}