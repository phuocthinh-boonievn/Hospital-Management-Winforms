using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosplitalManagement
{
    public partial class frmPatientRegister : Form
    {
        private readonly short role = 2;
        private Account account;
        PatientRepository patientRepo;
        public frmPatientRegister(Account tmpAcc)
        {
            InitializeComponent();
            MessageBox.Show("Please provides the info to complete your registration");
            patientRepo = new PatientRepository();
            account = tmpAcc;
            rbMale.Checked = true;
        }

/*        private Account GetAccount()
        {
            Account account = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = role
            };
            return account;
        }*/
        private Patient GetPatient()
        {
            var gender = "M";
            if (rbMale.Checked) { gender = "M"; }
            else if (rbFemale.Checked) { gender = "F"; }
            Patient patient = new Patient
            {
                PatientName = txtName.Text,
                DateOfBirth = dtpBoB.Value.Date,
                Gender = gender,
                AccountId = account.AccountId
            };
            return patient;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Missing name");
            }
            else
            {
                try
                {
                    Patient patient = GetPatient();
                    patientRepo.Insert(patient);
                    MessageBox.Show("Account activated succeeded");
                }
                catch { MessageBox.Show("Account activation failed"); }
            }
        }

        private void dtpBoB_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBoB.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Are you a time traveler");
                dtpBoB.Value = DateTime.Today;
            }
        }
    }
}
