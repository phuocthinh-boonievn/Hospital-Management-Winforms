using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository<PrescriptionDetail>
    {
        public IEnumerable<PrescriptionDetail> GetAll() => PrescriptionDetailDAO.Instance.GetPrescriptions();   

        public PrescriptionDetail GetByID(int id1, int id2) => PrescriptionDetailDAO.Instance.GetPrescriptionByID(id1,id2);

        public void Insert(PrescriptionDetail entity) => PrescriptionDetailDAO.Instance.AddPrescription(entity);

        public void Update(PrescriptionDetail entity) => PrescriptionDetailDAO.Instance.UpdatePrescription(entity);
        public void Delete(int id1, int id2) => PrescriptionDetailDAO.Instance.RemovePrescription(id1,id2);
    }
}
