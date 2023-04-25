using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : IRepositoryBase<Cart>
    {
        public void Delete(int id) => CartDAO.Instance.Remove(id);

        public IEnumerable<Cart> GetAll() => CartDAO.Instance.GetDetails;

        public Cart GetByID(int id) => CartDAO.Instance.GetByID(id);

        public void Insert(Cart entity) => CartDAO.Instance.AddNew(entity);

        public void Update(Cart entity) => CartDAO.Instance.Update(entity);
    }
}
