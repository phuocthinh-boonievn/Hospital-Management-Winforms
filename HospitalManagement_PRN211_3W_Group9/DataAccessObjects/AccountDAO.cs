using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private static readonly object instanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Account> GetAccounts()
        {
            var accounts = new List<Account>();
            try
            {
                using var context = new HospitalManagementContext();
                accounts = context.Accounts.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return accounts;
        }
        public bool GetUsername(string user)
        {
            string username = null;
            Account account = null;
            try
            {
                using var context = new HospitalManagementContext();
                account = context.Accounts.SingleOrDefault(m => m.Username == user);
                if(account != null) { return false; }
                //else { username = account.Username; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        } 
        public Account GetAccountByID(int id)
        {
            Account account = null;
            try
            {
                using var context = new HospitalManagementContext();
                account = context.Accounts.SingleOrDefault(m => m.AccountId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }
        public Account GetAccount(string username, string password)
        {
            Account account = null;
            try
            {
                using var context = new HospitalManagementContext();
                account = context.Accounts.FirstOrDefault(m => m.Username == username && m.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }
        public void AddAccount(Account account)
        {
            try
            {
                Account account1 = GetAccountByID(account.AccountId);
                if (account1 == null)
                {
                    using var context = new HospitalManagementContext();
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Account already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateAccount(Account acc)
        {
            try
            {
                Account account = GetAccountByID(acc.AccountId);
                if (account != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Accounts.Update(acc);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The account does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveAccount(int accID)
        {
            try
            {
                Account account = GetAccountByID(accID);
                if (account != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Accounts.Remove(account);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Account does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Account> SearchAccount(string username)
        {
            List<Account> account = null;
            try
            {
                using var context = new HospitalManagementContext();
                account = context.Accounts.Where(m => m.Username.Contains(username)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }
        public Account GetAccount(string username)
        {
            Account account = null;
            try
            {
                using var context = new HospitalManagementContext();
                account = context.Accounts.FirstOrDefault(m => m.Username == username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }
    }
}
