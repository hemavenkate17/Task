using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBLLibrary
{
    public interface IRepo<T>
    {
        bool Add(T t);

        bool Update(T t);
        ICollection<T> GetAll();
    }
}
