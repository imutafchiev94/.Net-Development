using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.App.Commons.BindingModels;
using Eventures.App.Commons.ViewModels;
using Eventures.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.App.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext dbContext;

        public EventsController(EventuresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult All()
        {
            var model = new AllEventsViewModel() 
            { 
                Events = this.dbContext.Events 
            };

            return View(model);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEventBidingModel model)
        {

            var events = new Event()
            {
                Name = model.Name,
                Place = model.Place,
                Start = model.Start,
                End = model.End,
                TotalTickets = model.TotalTickets,
                PricePerTicket = model.PricePerTicket
            };

            this.dbContext.Events.Add(events);
            this.dbContext.SaveChanges();

            return RedirectToAction("All");
        }
    }
}