using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public interface IConveyor<T>
    {
        void Push(T entity);
        T  Pull();
        bool isEmpty { get; }
    }
}
