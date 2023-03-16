using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Needs a name")]
        public string Name { get; set; }
        public double Price { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "needs a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "needs a state")]
        public string State { get; set; }
       
        public string Zip { get; set; }
        [Required(ErrorMessage = "needs a country")]
        public string Country { get; set; }
        public bool Anonymous { get; set; }
    }
}

