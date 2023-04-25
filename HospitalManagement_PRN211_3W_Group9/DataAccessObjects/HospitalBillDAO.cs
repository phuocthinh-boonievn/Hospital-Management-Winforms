using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class HospitalBillDAO
    {
        private static HospitalBillDAO instance;
        private static readonly object instanceLock = new object();
        public static HospitalBillDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HospitalBillDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<HospitalBill> GetBills()
        {
            var bills = new List<HospitalBill>();
            try
            {
                using var context = new HospitalManagementContext();
                bills = context.HospitalBills.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bills;
        }
        public HospitalBill GetBillByID(int id)
        {
            HospitalBill bill = null;
            try
            {
                using var context = new HospitalManagementContext();
                bill = context.HospitalBills.SingleOrDefault(m => m.BillId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bill;
        }
        public void AddBill(HospitalBill tmpBill)
        {
            try
            {
                HospitalBill bill = GetBillByID(tmpBill.BillId);
                if (bill == null)
                {
                    using var context = new HospitalManagementContext();
                    context.HospitalBills.Add(tmpBill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("HospitalBill already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateBill(HospitalBill tmpBill)
        {
            try
            {
                HospitalBill bill = GetBillByID(tmpBill.BillId);
                if (bill != null)
                {
                    using var context = new HospitalManagementContext();
                    context.HospitalBills.Update(tmpBill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The HospitalBill does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveBill(int billID)
        {
            try
            {
                HospitalBill bill = GetBillByID(billID);
                if (bill != null)
                {
                    using var context = new HospitalManagementContext();
                    context.HospitalBills.Remove(bill);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The HospitalBill does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
