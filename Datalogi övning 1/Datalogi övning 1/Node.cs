using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalogi_övning_1
{
    internal class MyLinkedList<T>
    {
        private MyNode<T>? Head = null;

        public void Push(T value)
        {
            MyNode<T> oldHead = this.Head;
            this.Head = new MyNode<T>();
            this.Head.Data = value;
            this.Head.Next = oldHead;
        }
        public T Get(int count)
        {
            //if (count == 0)
            //    return this.Head.Data;
            //if (count == 1)
            //{
            //    return this.Head.Next.Data;
            //}
            var nodeReference = this.Head;
            for (int i = 0; i < count; i++)
            {
                nodeReference = nodeReference.Next;
            }
            return nodeReference.Data;
        }
    }
    public class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T> Next { get; set; }
    }
}
