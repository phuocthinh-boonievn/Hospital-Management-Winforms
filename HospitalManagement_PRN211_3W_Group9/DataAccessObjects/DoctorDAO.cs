using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class DoctorDAO
    {
        private static DoctorDAO instance;
        private static readonly object instanceLock = new object();
        public static DoctorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DoctorDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>();
            try
            {
                using var context = new HospitalManagementContext();
                doctors = context.Doctors.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return doctors;
        }
        public Doctor GetDoctorByID(int id)
        {
            Doctor doctor = null;
            try
            {
                using var context = new HospitalManagementContext();
                doctor = context.Doctors.SingleOrDefault(m => m.DoctorId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return doctor;
        }
        public void AddDoctor(Doctor doc)
        {
            try
            {
                Doctor doctor = GetDoctorByID(doc.DoctorId);
                if (doctor == null)
                {
                    using var context = new HospitalManagementContext();
                    context.Doctors.Add(doc);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Doctor already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateDoctor(Doctor doc)
        {
            try
            {
                Doctor doctor = GetDoctorByID(doc.DoctorId);
                if (doctor != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Doctors.Update(doc);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Doctor does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveDoctor(int docID)
        {
            try
            {
                Doctor doctor = GetDoctorByID(docID);
                if (doctor != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Doctors.Remove(doctor);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Doctor does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Doctor> SearchDoctorByName(string name)
        {
            List<Doctor> docList = null;
            try
            {
                using var context = new HospitalManagementContext();
                docList = context.Doctors.Where(m => m.DoctorName.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return docList;
        }
        public bool CheckExist(int accID)
        {
            Doctor doc = null;
            try
            {
                using var context = new HospitalManagementContext();
                doc = context.Doctors.SingleOrDefault(m => m.AccountId == accID);
                if (doc == null) { return false; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
        public int GetDocID(Doctor doctor)
        {
            Doctor doc = null;
            int id=0;
            try
            {
                using var context = new HospitalManagementContext();
                doc = context.Doctors.SingleOrDefault(m => m.DoctorName == doctor.DoctorName);
                if (doc == null) { return id; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return doc.DoctorId;
        }
    }
}
