using Eventure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Eventure.Data
{
    public class EventureDbContext : IdentityDbContext<EventureUser>
    {
        public EventureDbContext(DbContextOptions<EventureDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
