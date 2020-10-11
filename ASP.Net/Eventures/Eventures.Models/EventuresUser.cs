﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Eventures.Models
{
    public class EventuresUser : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }

        public IdentityRole Role { get; set; }

    }
}
