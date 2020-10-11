using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FDMC.App.BindingModels
{
    public class AddCatBindingModel
    {
        
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string Breed { get; set; }

        [BindProperty]
        public string ImageUrl { get; set; }

    }
}
