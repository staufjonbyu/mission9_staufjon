using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Models
{
    public interface IPurchaseRepository 
    {
        IQueryable<Purchase> Purchase { get; }
        public void SavePurchase(Purchase purchase);


    }
}
