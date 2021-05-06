using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBLLibrary
{
    public interface IUserLogin<T>

    {
        bool Add(T t);
        bool Login(T t);
    }
}
