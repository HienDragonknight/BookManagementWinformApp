using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        // goị DbContext để choơi trực tiế DB
        // class chứa các hàm CRUD cơ bản với mỗi table Book
        // sum , avg, ... để cho service lo 
 
        private BookManagementDbContext _context;
        // mình ko new , để vào từng hàm CRUD sẽ new 

        public List<Book> GetBooks()
        {
            //hàm select * from Book 
            _context = new();
            return _context.Books.ToList();
            // new viết ngắn do đã biết kiểu dữ liệu ]
        }




        public List<UserAccount> GetUsers()
        {
            _context = new();
            return _context.UserAccounts.ToList();
        }

        public void UpdateBook  (Book b) {   // new book ởe đâu đó rồi đẩy xuống đay - do EF chới với project 

            _context = new();
            _context.Books.Update(b);
            _context.SaveChanges();
        
        }

        public void AddBook(Book b)
        {
            try
            {
                _context = new (); // Replace YourDbContext with your actual DbContext class
                _context.Books.Add(b);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Check if the exception is due to a primary key violation
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 2601)
                {
                    // Handle primary key duplication error here
                    // For example, you can log the error, display a message to the user, or take other appropriate actions
                    Console.WriteLine("Primary key duplication detected. Please enter a unique BookId.");
                }
                else
                {
                    // If it's not a primary key violation, re-throw the exception
                    throw;
                }
            }
        }

        public void DeleteBook(Book b)
        {
            _context = new();
            _context.Books.Remove(b);
            _context.SaveChanges();
        }

    }
}

