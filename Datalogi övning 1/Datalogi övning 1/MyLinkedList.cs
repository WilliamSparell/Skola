using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    public class MyLinkedList<T>
    {
        private MyNode<T>? Head = null;
        public MyNode<T> Current { get; set; }

        public void Push(T value)
        {
            MyNode<T> oldHead = this.Head;
            this.Head = new MyNode<T>();
            this.Head.Data = value;
            this.Head.Next = oldHead;
        }
        public T Get(int count)
        {
            var nodeReference = this.Head;
            for (int i = 0; i < count; i++)
            {
                nodeReference = nodeReference.Next;
            }
            return nodeReference.Data;
        }
        public void Next()
        {
            Current = Current.Next;
        }
        public void Reset()
        {
            Current = Head;
        }
    }
    public class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }
    }
}

