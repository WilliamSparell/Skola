using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    internal class Stack<T> : ISimpleStack<T>
    {
        private MyNode<T>? Top = null;
        public void Push(T value)
        {
            var newNode = new MyNode<T>();
            newNode.Data = value;
            newNode.Next = Top;
            Top = newNode;
            //Om stacken är tom?
        }
        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Listan är tom");
            }
            else
            {
                T value = Top.Data;
                Top = Top.Next;
                return value;
            }
            
        }
        public T Peek()
        {
            if (Top == null)
            {
                throw new Exception("Listan är tom");
            }
            else 
            {
                return Top.Data;
            }
        }

    }
}
