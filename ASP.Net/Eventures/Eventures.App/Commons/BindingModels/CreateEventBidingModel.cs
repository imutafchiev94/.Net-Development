using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.App.Commons.BindingModels
{
    public class CreateEventBidingModel
    {
        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(int.MaxValue,MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        [RegularExpression("(\\S)+ ")]
        public string Place { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [Required]
        [Range(1, int.MinValue)]
        public int TotalTickets { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal PricePerTicket { get; set; }

    }
}
