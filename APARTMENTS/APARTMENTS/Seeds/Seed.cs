using APARTMENTS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APARTMENTS.Seeds
{
    public class Seed
    {

        public static async Task SeedUsers(UserManager<User> userManager, RoleManager<AppRole> roleManager) 
        {
            if (await userManager.Users.AnyAsync()) return;

            


            var roles = new List<AppRole>
            {
            new AppRole{Name = "Member"},
            new AppRole{Name = "Admin" },
            new AppRole{Name = "Moderator" } 
            };
            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }
  
            var admin = new User
            {
                UserName = "admin"
            };
            await userManager.CreateAsync(admin, "Pa$$word");
            await userManager.AddToRolesAsync(admin, new[] {"Admin", "Moderator" });
            

        }
    }
}
