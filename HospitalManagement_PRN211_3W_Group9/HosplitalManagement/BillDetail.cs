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
    public partial class BillDetail : Form
    {
        BillRepository bill;
        CartRepository cart;
        PrescriptionRepository detail;
        MedicineRepository medRepo;
        Appointment sessionApp;
        private static float price = 0;
        public BillDetail(Appointment app)
        {
            InitializeComponent();
            bill = new BillRepository();
            cart = new CartRepository();
            detail = new PrescriptionRepository();
            medRepo = new MedicineRepository();
            sessionApp = app;
            txtAppointmentID.Text = sessionApp.AppointmentId.ToString();
            txtDate.Text = sessionApp.AppointedDate.ToString();
        }
        private void FillMedList()
        {
            var meds = medRepo.GetAll();
            foreach (var med in meds)
            {
                if (!cbMedList.Items.Contains(med.MedicineName))
                {
                    cbMedList.Items.Add(med.MedicineName);
                }
            }
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            FillMedList();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            var meds = medRepo.GetAll();
            var med = meds.SingleOrDefault(n => n.MedicineName == cbMedList.Text);
            if (byte.Parse(txtAmount.Text) > med.MedicineAmount)
            {
                MessageBox.Show($"This only have {med.MedicineAmount} in stock");
                txtAmount.Text = med.MedicineAmount.ToString();
            }
        }
        private Cart Item()
        {
            var meds = medRepo.GetAll();
            var med = meds.SingleOrDefault(n => n.MedicineName == cbMedList.Text);
            Cart item = new Cart
            {
                MedicineId = med.MedicineId,
                PrescriptedAmount = byte.Parse(txtAmount.Text),
                MedicinePrice = med.MedicinePrice,
                PrescriptedDose = txtDosage.Text,
                PrescriptionDescription = txtDiscription.Text,
            };
            return item;
        }
        private void LoadDgv()
        {
            var items = cart.GetAll();
            try
            {
                dgvCart.DataSource = null;
                dgvCart.DataSource = items;
            }
            catch { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbMedList.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                MessageBox.Show("The MedName and amount must not be empty");
            }
            else
            {
                try
                {
                    Cart item = Item();
                    cart.Insert(item);
                    LoadDgv();
                }
                catch { }
                var items = cart.GetAll();
                foreach (var item in items)
                {
                    price += (float.Parse(item.MedicinePrice.ToString()) * item.PrescriptedAmount);
                }
                txtTotalPrice.Text = price.ToString();
            }
        }
        private HospitalBill GetBill()
        {
            var items = cart.GetAll();
            HospitalBill bill = new HospitalBill
            {
                BillDate = sessionApp.AppointedDate.Date,
                TotalPrice = price,
                AppointmentId = sessionApp.AppointmentId
            };
            return bill;
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            HospitalBill hBill = GetBill();
            PrescriptionDetail prescription;
            bill.Insert(hBill);
            var items = cart.GetAll();
            var bills = bill.GetAll();
            hBill = bills.FirstOrDefault(b => b.AppointmentId == sessionApp.AppointmentId);
            foreach (var item in items)
            {
                prescription = new PrescriptionDetail
                {
                    PrescriptedDose = item.PrescriptedDose,
                    PrescriptedAmount = item.PrescriptedAmount,
                    PrescriptionDescription = item.PrescriptionDescription,
                    BillId = hBill.BillId,
                    MedicineId = item.MedicineId,
                };
                detail.Insert(prescription);
                MedicineStorage med = medRepo.GetByID(item.MedicineId);
                med.MedicineAmount -= item.PrescriptedAmount;
                medRepo.Update(med);
                MessageBox.Show("Finished");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
