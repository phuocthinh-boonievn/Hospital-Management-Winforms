using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BillRepository : IRepositoryBase<HospitalBill>
    {
        public IEnumerable<HospitalBill> GetAll() => HospitalBillDAO.Instance.GetBills();

        public HospitalBill GetByID(int id) => HospitalBillDAO.Instance.GetBillByID(id);


        public void Insert(HospitalBill entity) => HospitalBillDAO.Instance.AddBill(entity);

        public void Update(HospitalBill entity) => HospitalBillDAO.Instance.UpdateBill(entity);
        public void Delete(int id) => HospitalBillDAO.Instance.RemoveBill(id);
    }
}
