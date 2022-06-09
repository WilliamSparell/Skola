using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    public interface ISimpleStack<T>
    {
        public void Push(T value);
        public T Pop();
        public T Peek();
    }

}
