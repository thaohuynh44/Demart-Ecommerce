using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Thao Huynh",
                    Email = "thao@test.com",
                    UserName = "thao@test.com",
                    Address = new Address
                    {
                        FirstName = "Thao",
                        LastName = "Huynh",
                        Street = "497 Dien Bien Phu",
                        City = "Ho Chi Minh",
                        State = "HCM",
                        ZipCode = "70000"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}