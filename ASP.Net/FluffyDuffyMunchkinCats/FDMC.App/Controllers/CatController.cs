using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.App.BindingModels;
using FDMC.App.ViewModels;
using FDMC.Data;
using FDMC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.App.Controllers
{
    public class CatController : Controller
    {
        private readonly FDMCDbContext dbContext;

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
        public IActionResult Add(AddCatBindingModel bindingModel)
        {

            var cat = new Cat()
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Breed = bindingModel.Breed,
                ImageUrl = bindingModel.ImageUrl
            };

            this.dbContext.Cats.Add(cat);
            this.dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {

            var cat = this.dbContext.Cats.FirstOrDefault(c => c.Id == Id);

            var model = new CatDetailsViewModel()
            {
                Name = cat.Name,
                Age = cat.Age,
                Breed = cat.Breed,
                ImageUrl = cat.ImageUrl
            };

            return View(model);
        }
    }
}