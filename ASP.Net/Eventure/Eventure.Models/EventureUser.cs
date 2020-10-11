using Microsoft.AspNetCore.Identity;
using System;

namespace Eventure.Models
{
    public class EventureUser : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }

        public IdentityRole Role { get; set; }

    }
}
