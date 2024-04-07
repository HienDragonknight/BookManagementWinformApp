using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepositories
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetBookCategories()
        {
            //hàm select * from Book 
            _context = new();
            return _context.BookCategories.ToList();
            // new viết ngắn do đã biết kiểu dữ liệu ]
        }

    }
}
