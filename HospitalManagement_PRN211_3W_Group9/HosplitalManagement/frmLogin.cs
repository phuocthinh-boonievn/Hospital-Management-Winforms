using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosplitalManagement
{
    public partial class frmLogin : Form
    {
        private readonly short role = 2;
        public AccountRepository repo { get; set; }
        PatientRepository patientRepository;
        //IRepositoryBase<Account> repo { get; set; }
        public frmLogin()
        {
            repo = new AccountRepository();
            patientRepository = new PatientRepository();
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "123";
        }
        private Account GetAccount()
        {
            
            Account account = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = role
            };
            return account;
        }
        private void ClearText()
        {
            txtUsername.Text = string.Empty; txtPassword.Text = string.Empty;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            Account account = repo.GetLogin(username, password);
            //account = repositoryBase.GetLogin(username, password);
            //MessageBox.Show($"ID:{username}\nPwd:{password}");
            //MessageBox.Show($"ID:{account.Username}\nPwd:{account.Password}");
            if (account != null)
            {
                if (!patientRepository.CheckExist(account.AccountId) && account.Role == 2)
                {
                    //var tmpAcc = repo.GetLogin(account.Username, account.Password);
                    //MessageBox.Show("Please provide the necessary info to use the account");
                    frmPatientRegister register = new frmPatientRegister(account);
                    register.ShowDialog();
                }
                else if (account != null)
                {
                    frmMain main = new frmMain(account);
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("Login Failed"); }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string username = repo.GetUsername(txtUsername.Text);
            bool flag = repo.GetUsername(txtUsername.Text);
            /*if (username.Equals(account.Username))
            {
                MessageBox.Show("equal");
            }*/
            //MessageBox.Show("List lenght:" + accounts.Count().ToString());
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Both Username/Password fields must not be empty");
            }
            else
            {
                Account account = GetAccount();
                if (/*account.Username == username*/!flag)
                {
                    MessageBox.Show("Account already existed");
                }
                else
                {
                    try
                    {
                        repo.Insert(account);
                        MessageBox.Show("Account registered");
                        var tmpAcc = repo.GetLogin(account.Username, account.Password);
                        frmPatientRegister register = new frmPatientRegister(tmpAcc);
                        register.ShowDialog();
                    }
                    catch { MessageBox.Show($"Account register failed"); }
                }
            }
        }
    }
}
