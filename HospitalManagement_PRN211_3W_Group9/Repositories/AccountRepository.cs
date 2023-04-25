using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IRepositoryBase<Account>, IAccountRepository
    {
        public IEnumerable<Account> GetAll() => AccountDAO.Instance.GetAccounts();

        public Account GetByID(int id) => AccountDAO.Instance.GetAccountByID(id);

        public Account GetLogin(string username, string password) 
            => AccountDAO.Instance.GetAccount(username, password);

        public void Insert(Account entity) => AccountDAO.Instance.AddAccount(entity);

        public void Update(Account entity) => AccountDAO.Instance.UpdateAccount(entity);
        public void Delete(int id) => AccountDAO.Instance.RemoveAccount(id);

        Account IAccountRepository.GetLogin(string username, string password) 
            => AccountDAO.Instance.GetAccount(username, password);

        public bool GetUsername(string username) => AccountDAO.Instance.GetUsername(username);

        public IEnumerable<Account> Search(string username) => AccountDAO.Instance.SearchAccount(username);

        public Account GetAccount(string username) => AccountDAO.Instance.GetAccount(username);
    }
}
