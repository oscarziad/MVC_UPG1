using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Upg1_Asp.Net.MVC.Data
{
    public class AppUserClaims : UserClaimsPrincipalFactory<AppUser, IdentityRole>
    {
        public AppUserClaims(
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("DisplayName", user.DisplayName ?? ""));

            return identity;
        }
    }
}
