using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class PatientDAO
    {
        private static PatientDAO instance;
        private static readonly object instanceLock = new object();
        public static PatientDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PatientDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Patient> GetPatients()
        {
            var patients = new List<Patient>();
            try
            {
                using var context = new HospitalManagementContext();
                patients = context.Patients.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return patients;
        }
        public Patient GetPatientByID(int id)
        {
            Patient patient = null;
            try
            {
                using var context = new HospitalManagementContext();
                patient = context.Patients.SingleOrDefault(m => m.PatientId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return patient;
        }
        public void AddPatient(Patient tmpPatient)
        {
            try
            {
                Patient patient = GetPatientByID(tmpPatient.PatientId);
                if (patient == null)
                {
                    using var context = new HospitalManagementContext();
                    context.Patients.Add(tmpPatient);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Patient already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdatePatient(Patient tmpPatient)
        {
            try
            {
                Patient patient = GetPatientByID(tmpPatient.PatientId);
                if (patient != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Patients.Update(tmpPatient);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Patient does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemovePatient(int id)
        {
            try
            {
                Patient patient = GetPatientByID(id);
                if (patient != null)
                {
                    using var context = new HospitalManagementContext();
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Patient does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool CheckExist(int accID)
        {
            Patient patient = null;
            try
            {
                using var context = new HospitalManagementContext();
                patient = context.Patients.SingleOrDefault(m => m.AccountId == accID);
                if (patient == null) { return false; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
        public IEnumerable<Patient> SearchPatientByName(string name)
        {
            List<Patient> patients = null;
            try
            {
                using var context = new HospitalManagementContext();
                patients = context.Patients.Where(m => m.PatientName.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return patients;
        }
    }
}
