using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.DAL.Interfaces
{
    public interface IGenericRepo<T> where T:class
    {
        void Create(T item);

        T Read(Func<T, bool> predicate);

        void Update(T item);

        void Delete(int id);

        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
    }
}
