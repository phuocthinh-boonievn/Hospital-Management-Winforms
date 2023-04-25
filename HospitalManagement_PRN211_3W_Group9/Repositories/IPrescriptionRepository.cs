using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPrescriptionRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id1, int id2);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id1, int id2);
    }
}
