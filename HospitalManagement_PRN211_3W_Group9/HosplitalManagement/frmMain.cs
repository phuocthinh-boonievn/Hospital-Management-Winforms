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
    public partial class frmMain : Form
    {
        private readonly Account account;
        private BindingSource source;
        private int tmpID;
        PatientRepository patientRepository;
        AccountRepository accountRepository;
        DoctorRepository doctorRepository;
        AppointmentRepository appointmentRepository;
        BillRepository billRepository;
        MedicineRepository medicineRepository;
        PrescriptionRepository prescriptionRepository;
        public frmMain(Account acc)
        {
            InitializeComponent();
            account = acc;
            patientRepository = new PatientRepository();
            accountRepository = new AccountRepository();
            doctorRepository = new DoctorRepository();
            appointmentRepository = new AppointmentRepository();
            billRepository = new BillRepository();
            prescriptionRepository = new PrescriptionRepository();
            medicineRepository = new MedicineRepository();
        }
        //Yes/No Confirmation msgBox
        private DialogResult confirmationMssBox(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            return result;
        }
        //---------------------------------------------------------------
        //----------------------AccountManangement-----------------------
        //---------------------------------------------------------------
        private void LoadAccountWithFormat()
        {
            LoadAccountData();
            dgvDisplayFormat(dgvDisplayAccounts, "Doctors", "Patients");
        }

        //Get dgv ID on header click
        private void dgvDisplayAccounts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tmpID = Convert.ToInt32(dgvDisplayAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                tmpID = 0;
            }
        }
        private void LoadAccountData()
        {
            var accs = accountRepository.GetAll();
            source = new BindingSource();
            try
            {
                source.DataSource = accs;
                dgvDisplayAccounts.DataSource = null;
                dgvDisplayAccounts.DataSource = accs;
            }
            catch (Exception ex) { }
        }
        private void dgvDisplayFormat(DataGridView dgv, string str1, string str2)
        {
            dgv.Columns[str1].Visible = false;
            dgv.Columns[str2].Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadAccountData();
            dgvDisplayFormat(dgvDisplayAccounts, "Doctors", "Patients");
            //LoadProfileData();
            //dgvDisplayFormat(dgvDisplayProfiles, "Account", "Appointments");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if(txtSearchAccount.Text == string.Empty)
            {
                LoadAccountData();
            }
            else
            {
                var accs = accountRepository.Search(txtSearchAccount.Text);
                dgvDisplayAccounts.DataSource = null;
                dgvDisplayAccounts.DataSource = accs;
            }*/
            var accs = accountRepository.Search(txtSearchAccount.Text);
            dgvDisplayAccounts.DataSource = null;
            dgvDisplayAccounts.DataSource = accs;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account account = null;
            frmAddDoctorAccount addAccount = new frmAddDoctorAccount(account, 0);
            addAccount.ShowDialog();
        }
        //---------------------------------------------------------------
        //----------------------ProfileManangement-----------------------
        //---------------------------------------------------------------
        private void LoadProfileData()
        {
            if (rbDoctorPF.Checked)
            {
                var pros = doctorRepository.GetAll();
                source = new BindingSource();
                try
                {
                    source.DataSource = pros;
                    dgvDisplayProfiles.DataSource = null;
                    dgvDisplayProfiles.DataSource = pros;
                }
                catch (Exception ex) { }
            }
            else if (rbPatientPF.Checked)
            {
                var pros = patientRepository.GetAll();
                source = new BindingSource();
                try
                {
                    source.DataSource = pros;
                    dgvDisplayProfiles.DataSource = null;
                    dgvDisplayProfiles.DataSource = pros;
                }
                catch (Exception ex) { }
            }
        }

        private void rbDoctorPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoctorPF.Checked == true)
            {
                LoadProfileData();
                dgvDisplayFormat(dgvDisplayProfiles, "Account", "Appointments");
            }
        }

        private void rbPatientPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPatientPF.Checked == true)
            {
                LoadProfileData();
                dgvDisplayFormat(dgvDisplayProfiles, "Account", "Appointments");
            }
        }

        private void txtSearchPF_TextChanged(object sender, EventArgs e)
        {
            if (rbPatientPF.Checked == true)
            {
                var patients = patientRepository.SearchByName(txtSearchPF.Text);
                source.DataSource = patients;
                dgvDisplayProfiles.DataSource = null;
                dgvDisplayProfiles.DataSource = patients;
            }
            else if (rbDoctorPF.Checked == true)
            {
                var doctors = doctorRepository.SearchByName(txtSearchPF.Text);
                source.DataSource = doctors;
                dgvDisplayProfiles.DataSource = null;
                dgvDisplayProfiles.DataSource = doctors;
            }
        }

        private void btnCreatePF_Click(object sender, EventArgs e)
        {
            frmAddDocPF docPF = new frmAddDocPF();
            docPF.ShowDialog();
        }

        private void btnUpdateDocAccount_Click(object sender, EventArgs e)
        {
            Account account = accountRepository.GetByID(tmpID);
            frmAddDoctorAccount doctorAccount = new frmAddDoctorAccount(account, 1);
            doctorAccount.ShowDialog();
            LoadAccountWithFormat();
            tmpID = 0;
        }

        private void btnDeleteDocAccount_Click(object sender, EventArgs e)
        {
            Account account = accountRepository.GetByID(tmpID);
            var result = confirmationMssBox("Delete Account", "Confirmation");
            if (result == DialogResult.Yes)
            {
                try
                {
                    accountRepository.Delete(tmpID);
                    MessageBox.Show("Account deleted");
                    tmpID = 0;
                    LoadAccountWithFormat();
                }
                catch { MessageBox.Show("Failed to delete the account"); }
            }
            else { return; }
        }
    }
}
