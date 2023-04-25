using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MedicineRepository : IRepositoryBase<MedicineStorage>
    {
        public IEnumerable<MedicineStorage> GetAll() => MedicineDAO.Instance.GetMedicines();

        public MedicineStorage GetByID(int id) => MedicineDAO.Instance.GetMedicineByID(id);
        public void Insert(MedicineStorage entity) => MedicineDAO.Instance.AddMedicine(entity);

        public void Update(MedicineStorage entity) => MedicineDAO.Instance.UpdateMedicine(entity);
        public void Delete(int id) => MedicineDAO.Instance.RemoveMedicince(id);
    }
}
