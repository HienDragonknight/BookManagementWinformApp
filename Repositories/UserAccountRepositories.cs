using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public  class UserAccountRepositories
    {
        private BookManagementDbContext _context ;


        public UserAccount? GetAccount(string email, string password ) //  UserAccount? : ? là có thể bagnwf null nếu tìm không thấy email trogn đán user .
        {

            _context = new ();
         return    _context.UserAccounts.FirstOrDefault(x => x.Email.ToLower() == email.ToLower().Trim() && x.Password.ToLower()==password.ToLower().Trim());
        }


    }
}
