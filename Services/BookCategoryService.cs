using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        //CUNG CẤP DATA CHO FORM, THỰC RA LÀ CUNG CẤP DATA CHO CÁI DROPDOWN, BẤM XỔ, COMBOX
        //LẼ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DB - NHƯNG TẠM THỜI HARD-CODED TRƯỚC, ĐỂ MAI TÍNH...

        private BookCategoryRepositories _repo = new();

        public List<BookCategory> GetAllCategories()
        {

            //TODO: Gọi class BookCategoryRepository để lấy toàn bộ danh mục phân loại sách từ DB
            //Call class BookCategoryRepository to retrieve all book categories from DB

          
            // tra ve 6 cai Category 

            return _repo.GetBookCategories(); 
        }
    }
}
