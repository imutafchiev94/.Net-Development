using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.App.Controllers
{
    public class CatController : Controller
    {

        private FDMCDbContext dbContext;

        public CatController(FDMCDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add (string Name, int Age, string Breed, string ImageUrl)
        {

            Cat cat = new Cat();

            cat.Name = Name;
            cat.Age = Age;
            cat.Breed = Breed;
            cat.ImageUrl = ImageUrl;

            this.dbContext.Cats.Add(cat);

            this.dbContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        public IActionResult Details(int Id)
        {
            Cat cat = this.dbContext.Cats.First(c => c.Id == Id);

            return View(cat);
        }
    }
}