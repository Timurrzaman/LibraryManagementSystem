using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DataAccess
{
    public class BookDal
    {
        // 1. LİSTELEME
        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = (int)reader["BookID"],
                        BookName = reader["BookName"].ToString(),
                        Author = reader["Author"].ToString(),
                        PageCount = (int)reader["PageCount"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    });
                }
            }
            return books;
        }

        // 2. EKLEME
        public void Add(Book book)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Books (BookName, Author, PageCount, IsAvailable) VALUES (@name, @author, @pages, @status)",
                    connection);
                command.Parameters.AddWithValue("@name", book.BookName);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@pages", book.PageCount);
                command.Parameters.AddWithValue("@status", book.IsAvailable);
                command.ExecuteNonQuery();
            }
        } // <--- Add metodu burada düzgünce bitmeli

        // 3. SİLME
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookID=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
        public List<Book> GetBySearch(string key)
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                // LIKE sorgusu ile arama yapıyoruz. % işareti "içinde geçen" demek.
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE BookName LIKE @key", connection);
                command.Parameters.AddWithValue("@key", "%" + key + "%");

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = (int)reader["BookID"],
                        BookName = reader["BookName"].ToString(),
                        Author = reader["Author"].ToString(),
                        PageCount = (int)reader["PageCount"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    });
                }
            }
            return books;
        }
    }
}