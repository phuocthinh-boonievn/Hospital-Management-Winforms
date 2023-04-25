using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CartDAO
    {
        private static List<Cart> cart = new List<Cart>();
        private static CartDAO instance;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Cart> GetDetails => cart;
        public Cart GetByID(int id)
        {
            Cart detail = cart.SingleOrDefault(pre => pre.MedicineId == id);
            return detail;
        }

        public void AddNew(Cart detail)
        {
            Cart detail1 = GetByID(detail.MedicineId);
            if(detail1 == null) { cart.Add(detail); }
            else { throw new Exception("Can not add new"); }
        }
        public void Update(Cart prescriptionDetail)
        {
            Cart detail = GetByID(prescriptionDetail.MedicineId);
            if (detail != null) { var index = cart.IndexOf(detail); }
            else { throw new Exception("Can not update"); }
        }
        public void Remove(int id)
        {
            Cart detail = GetByID(id);
            if(detail != null) { cart.Remove(detail); } 
            else { throw new Exception("Can not remove"); }
        }

    }
}
