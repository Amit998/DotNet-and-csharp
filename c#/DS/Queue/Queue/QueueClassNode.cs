using System;


namespace Queue
{
 

    class QueueClassNode<T>
    {
        public QueueClassNode<T> next;
        public T data;


        public QueueClassNode(T value)
        {
            data = value;
            next = null;

        }


    }
}
