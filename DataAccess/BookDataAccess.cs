using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entities;

namespace DataAccess
{
    public class BookDataAccess
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            string connectionString = "Data Source=.;Initial Catalog=Skills;Integrated Security=True;";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            string commandText = "select * from Book";

            SqlCommand command = new SqlCommand();

            command.CommandText = commandText;
            command.Connection = connection;

            connection.Open();
            SqlDataReader datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                Book book=new Book ();
                book.Title = datareader["Title"].ToString();
                book.Author = datareader["Author"].ToString();
                book.Publisher = datareader["Publisher"].ToString();
                book.Price = Convert.ToDouble(datareader["Price"]);

                books.Add(book);
            }

            connection.Close();

            return books;
        }
    }
}
