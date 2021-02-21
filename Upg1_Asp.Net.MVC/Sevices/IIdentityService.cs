using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upg1_Asp.Net.MVC.Data;

namespace Upg1_Asp.Net.MVC.Sevices
{
    public interface IIdentityService
    {
        Task CreateRootAccountAsync();

        Task CreateNewRole(string roleName);
        Task<IdentityResult> CreateNewUserAsync(AppUser user, string password);
        Task AddUserToRole(AppUser user, string roleName);

        IEnumerable<AppUser> GetAllUsers();

        IEnumerable<IdentityRole> GetAllRoles();


    }
}
