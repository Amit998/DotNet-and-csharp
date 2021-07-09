using System;

namespace linkedList
{
    class LinkedListNode<T>
    {
        internal T data;
        internal LinkedListNode<T> next;

        public LinkedListNode()
        {

        }
        public LinkedListNode(T value)
        {
            this.data = value;
            this.next = null;
        }

        public T Data
        {
            get { return data; }
            set { Data = value; }
        }

    }
}
