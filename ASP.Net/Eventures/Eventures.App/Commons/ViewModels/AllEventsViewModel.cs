using Eventures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.App.Commons.ViewModels
{
    public class AllEventsViewModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}
