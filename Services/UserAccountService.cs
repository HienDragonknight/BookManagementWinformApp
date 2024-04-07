using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public  class UserAccountService
    {
        private UserAccountRepositories _repo = new();
       public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.GetAccount(email, password);
        }

    }
}
