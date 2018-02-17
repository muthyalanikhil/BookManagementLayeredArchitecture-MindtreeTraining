using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccess;

namespace BussinessLogic
{
    public class BookBusinessLogic
    {
        public List<Book> GetBooks()
        {
            BookDataAccess bookDA = new BookDataAccess();
            var books = bookDA.GetBooks();

            foreach (var book in books)
            {
                book.Price = book.Price - book.Price * .1;
            }

            return books;
        }
    }
}
