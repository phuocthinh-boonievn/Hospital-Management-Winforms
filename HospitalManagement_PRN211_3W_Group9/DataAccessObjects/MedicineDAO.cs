using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MedicineDAO
    {
        private static MedicineDAO instance;
        private static readonly object instanceLock = new object();
        public static MedicineDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MedicineDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MedicineStorage> GetMedicines()
        {
            var meds = new List<MedicineStorage>();
            try
            {
                using var context = new HospitalManagementContext();
                meds = context.MedicineStorages.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return meds;
        }
        public MedicineStorage GetMedicineByID(int id)
        {
            MedicineStorage med = null;
            try
            {
                using var context = new HospitalManagementContext();
                med = context.MedicineStorages.SingleOrDefault(m => m.MedicineId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return med;
        }
        public void AddMedicine(MedicineStorage tmpMed)
        {
            try
            {
                MedicineStorage med = GetMedicineByID(tmpMed.MedicineId);
                if (med == null)
                {
                    using var context = new HospitalManagementContext();
                    context.MedicineStorages.Add(tmpMed);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Medicine already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateMedicine(MedicineStorage tmpMed)
        {
            try
            {
                MedicineStorage med = GetMedicineByID(tmpMed.MedicineId);
                if (med != null)
                {
                    using var context = new HospitalManagementContext();
                    context.MedicineStorages.Update(tmpMed);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Medicine does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveMedicince(int id)
        {
            try
            {
                MedicineStorage med = GetMedicineByID(id);
                if (med != null)
                {
                    using var context = new HospitalManagementContext();
                    context.MedicineStorages.Remove(med);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Medicine does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
