using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProfileRepository<T> where T : class
    {
        IEnumerable<T> SearchByName(string name);
        //bool CheckExist(int id);
    }
}
