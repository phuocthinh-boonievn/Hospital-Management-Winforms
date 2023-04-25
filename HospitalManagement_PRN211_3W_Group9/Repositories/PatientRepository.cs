using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PatientRepository : IRepositoryBase<Patient>, IPantientRepository, IProfileRepository<Patient>
    {
        public IEnumerable<Patient> GetAll() => PatientDAO.Instance.GetPatients();

        public Patient GetByID(int id) => PatientDAO.Instance.GetPatientByID(id);


        public void Insert(Patient entity) => PatientDAO.Instance.AddPatient(entity);

        public void Update(Patient entity) => PatientDAO.Instance.UpdatePatient(entity);
        public void Delete(int id) => PatientDAO.Instance.RemovePatient(id);

        public bool CheckExist(int id) => PatientDAO.Instance.CheckExist(id);

        public IEnumerable<Patient> SearchByName(string name) => PatientDAO.Instance.SearchPatientByName(name);
    }
}
