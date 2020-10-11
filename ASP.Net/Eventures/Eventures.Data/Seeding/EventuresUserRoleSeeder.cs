using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventures.Data.Seeding
{
    public class EventuresUserRoleSeeder : ISeeder
    {
        private readonly EventuresDbContext context;

        public EventuresUserRoleSeeder(EventuresDbContext context)
        {
            this.context = context;
        }
        public void Seed()
        {
            if (!this.context.Roles.Any())
            {
                 this.context.Roles.AddAsync(new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
                 this.context.Roles.AddAsync(new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                });

                 this.context.SaveChangesAsync();
            }
        }
    }
}
