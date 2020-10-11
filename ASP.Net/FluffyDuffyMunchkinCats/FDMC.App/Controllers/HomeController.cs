using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FDMC.App.Models;
using FDMC.Data;
using FDMC.App.ViewModels;

namespace FDMC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly FDMCDbContext DbContext;

        public HomeController(FDMCDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IActionResult Index()
        {

            var model = new IndexViewModel() { 
            Cats = this.DbContext.Cats.ToList()};

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
