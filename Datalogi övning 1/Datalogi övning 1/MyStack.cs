using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    internal class MyStack<T> : ISimpleStack<T>, ISimpleQueue<T>
    {
        private MyNode<T>? Top = null;
        private MyNode<T> bottom = null;

        public void Push(T value)
        { 
            var newNode = new MyNode<T>();
            newNode.Data = value;
            newNode.Next = Top;
            Top = newNode;

            if (bottom == null)
            {
                bottom = newNode;
            }
        }
        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Stacken är tom");
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
                throw new Exception("Stacken är tom");
            }
            else 
            {
                return Top.Data;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new MyNode<T>();
            newNode.Data = value;
            bottom.Next = newNode;
            bottom = newNode;
        }
        public T GetFirst()
        {
            return Peek();
        }
        public void RemoveFirst()
        {
            Pop();
        }
    }
}
