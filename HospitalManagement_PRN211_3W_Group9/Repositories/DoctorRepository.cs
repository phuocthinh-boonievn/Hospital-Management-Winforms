using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DoctorRepository : IRepositoryBase<Doctor>, IProfileRepository<Doctor>, IDoctorRepository
    {
        public IEnumerable<Doctor> GetAll() => DoctorDAO.Instance.GetDoctors();

        public Doctor GetByID(int id) => DoctorDAO.Instance.GetDoctorByID(id);
        public void Insert(Doctor entity) => DoctorDAO.Instance.AddDoctor(entity);

        public void Update(Doctor entity) => DoctorDAO.Instance.UpdateDoctor(entity);
        public void Delete(int id) => DoctorDAO.Instance.RemoveDoctor(id);

        public IEnumerable<Doctor> SearchByName(string name) => DoctorDAO.Instance.SearchDoctorByName(name);

        public bool CheckExist(int id) => DoctorDAO.Instance.CheckExist(id);

        public int GetID(Doctor doctor) => DoctorDAO.Instance.GetDocID(doctor);
    }
}
