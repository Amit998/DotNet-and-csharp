using System;


namespace stack
{
    

    class StackClassNode<T>
    {
        internal StackClassNode<T> next;
        internal T data;
        public StackClassNode(T value)
        {
            data = value;
            next = null;

        }
    }
}
