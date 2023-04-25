using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class PrescriptionDetailDAO
    {
        private static PrescriptionDetailDAO instance;
        private static readonly object instanceLock = new object();
        public static PrescriptionDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PrescriptionDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<PrescriptionDetail> GetPrescriptions()
        {
            var prescriptions = new List<PrescriptionDetail>();
            try
            {
                using var context = new HospitalManagementContext();
                prescriptions = context.PrescriptionDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prescriptions;
        }
        public PrescriptionDetail GetPrescriptionByID(int id1, int id2)
        {
            PrescriptionDetail prescription = null;
            try
            {
                using var context = new HospitalManagementContext();
                prescription = context.PrescriptionDetails.SingleOrDefault(b => b.BillId == id1 && b.MedicineId == id2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prescription;
        }
        public void AddPrescription(PrescriptionDetail tmpPrescription)
        {
            try
            {
                PrescriptionDetail prescription = GetPrescriptionByID(tmpPrescription.BillId, tmpPrescription.MedicineId);
                if (prescription == null)
                {
                    using var context = new HospitalManagementContext();
                    context.PrescriptionDetails.Add(tmpPrescription);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("PrescriptionDetail already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdatePrescription(PrescriptionDetail tmpPrescription)
        {
            try
            {
                PrescriptionDetail prescription = GetPrescriptionByID(tmpPrescription.BillId, tmpPrescription.MedicineId);
                if (prescription != null)
                {
                    using var context = new HospitalManagementContext();
                    context.PrescriptionDetails.Update(tmpPrescription);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The PrescriptionDetail does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemovePrescription(int id1, int id2)
        {
            try
            {
                PrescriptionDetail prescription = GetPrescriptionByID(id1, id2);
                if (prescription != null)
                {
                    using var context = new HospitalManagementContext();
                    context.PrescriptionDetails.Remove(prescription);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The PrescriptionDetail does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
