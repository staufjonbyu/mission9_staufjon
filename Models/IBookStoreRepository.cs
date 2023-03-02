using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
