using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BussinessLogic;
using Entities;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BookBusinessLogic bookBL = new BookBusinessLogic();
            var books = bookBL.GetBooks();

            Console.WriteLine("Reading data");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Price);
            }
        }
    }
}
