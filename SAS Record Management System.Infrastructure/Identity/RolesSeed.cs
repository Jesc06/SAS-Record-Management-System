using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SAS_Record_Management_System.Infrastructure.Persistence.Data;

namespace SAS_Record_Management_System.Infrastructure.Identity
{
    public class RolesSeed
    {
        public static async Task Seeder(RoleManager<IdentityRole> roleManager, UserManager<UserAccountRegistrationCredentials> userManager)
        {
            string[] roles = { "Admin", "Student" };

            foreach(var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            var adminEmail = "admin@gmail.com";
            var adminPassword = "Password_@123%";

            var FindExistingEmail = await userManager.FindByEmailAsync(adminEmail);

            if(FindExistingEmail == null)
            {
                var SetUpAdmin = new UserAccountRegistrationCredentials
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FirstName = "Josh",
                    Middlename = "Manalo",
                    LastName = "Escarez"
                };

                var CreateAdminAccount = await userManager.CreateAsync(SetUpAdmin, adminPassword);

                if (CreateAdminAccount.Succeeded)
                {
                    await userManager.AddToRoleAsync(SetUpAdmin, "Admin");
                }
                else
                {
                    throw new Exception("Failed to create seeded admin account");
                }
            }

        }


    }
}
