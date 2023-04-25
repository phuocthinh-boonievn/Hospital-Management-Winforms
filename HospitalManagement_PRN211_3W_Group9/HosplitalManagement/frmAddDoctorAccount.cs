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
    public partial class frmAddDoctorAccount : Form
    {
        private Account account;
        private readonly short role = 1;
        private int btnSave_Role;
        public frmAddDoctorAccount(Account acc, int role)
        {
            InitializeComponent();
            account = acc;
            btnSave_Role = role;
            if (account != null)
            {
                txtUsername.Text = account.Username;
                txtPassword.Text = account.Password;
                btnSave_Role = 1;
            }
            else { btnSave_Role = 0; }
        }
        private Account GetAccount()
        {
            Account tmpAcc = null;
            try
            {
                if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    return tmpAcc = null;
                }
                else
                {
                    tmpAcc = new Account
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Role = role,
                    };
                }
            }
            catch
            {
                return tmpAcc = null;
            }
            return tmpAcc;
        }
        /*private Doctor GetDoctor()
        {
            if (doc == null)
            {
                if (txtName.Text == string.Empty || txtSpecialization.Text == string.Empty)
                {
                    return doc;
                }
                else
                {
                    doc = new Doctor
                    {
                        DoctorName = txtName.Text,
                        DoctorSpecialization = txtSpecialization.Text,
                    };
                }
            }
            return doc;
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountRepository accRepo = new AccountRepository();
            if(btnSave_Role == 0)
            {
                Account acc = GetAccount();
                if (acc == null)
                {
                    MessageBox.Show("Please do not leave any field empty");
                }
                else if (acc != null)
                {
                    bool flag = accRepo.GetUsername(acc.Username);
                    if (!flag)
                    {
                        MessageBox.Show("Account already exist");
                    }
                    else
                    {
                        try
                        {
                            accRepo.Insert(acc);
                            MessageBox.Show("Account added successfully");
                        }
                        catch { MessageBox.Show("Account inserts failed"); }
                    }
                }
            }
            else if( btnSave_Role == 1) 
            { 
                if(txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please do not leave the fields empty");
                }
                else
                {
                    try
                    {
                        account.Username = txtUsername.Text;
                        account.Password = txtPassword.Text;
                        accRepo.Update(account);
                        MessageBox.Show("Account updated successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Account updates failed");
                    }
                }
            }
        }
    }
}
