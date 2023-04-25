using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        Account GetLogin(string username, string password);
        Account GetAccount(string username);
        bool GetUsername(string username);

        IEnumerable<Account> Search(string username);
    }
}
