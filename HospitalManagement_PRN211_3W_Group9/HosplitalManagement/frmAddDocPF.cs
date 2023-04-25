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
    public partial class frmAddDocPF : Form
    {
        AccountRepository accRepo;
        DoctorRepository docRepo;
        public frmAddDocPF()
        {
            InitializeComponent();
            accRepo = new AccountRepository();
            docRepo = new DoctorRepository();
        }

        private Doctor GetDoctor()
        {
            Doctor doctor = new Doctor
            {
                DoctorName = txtName.Text,
                DoctorSpecialization = txtSpec.Text,
            };
            return doctor;
        }
        private void LoadAccountComboBox()
        {
            var accounts = accRepo.GetAll();
            var doctors = docRepo.GetAll();
            List<int> accID = new List<int>();
            foreach (var account in accounts)
            {
                if (!accID.Contains(account.AccountId) && account.Role == 1)
                {
                    accID.Add(account.AccountId);
                }
            }
            List<int> docAccID = new List<int>();
            foreach (var doc in doctors)
            {
                if (!docAccID.Contains(doc.AccountId))
                {
                    docAccID.Add(doc.AccountId);
                }
            }
            var result = accID.Except(docAccID);
            foreach (var re in result)
            {
                if (!cbAccountList.Items.Contains(re))
                {
                    cbAccountList.Items.Add(re);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Doctor doctor = GetDoctor();
            DoctorRepository repository = new DoctorRepository();
            try
            {
                repository.Insert(doctor);

            }
            catch { MessageBox.Show("Insert failed"); }
        }

        private void frmAddDocPF_Load(object sender, EventArgs e)
        {
            LoadAccountComboBox();
        }
    }
}
