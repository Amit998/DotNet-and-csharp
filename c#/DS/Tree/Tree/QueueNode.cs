using System;


namespace Tree
{
    class QueueNode
    {
        public QueueNode next;
        public dynamic data;
        public QueueNode(dynamic value)
        {
            this.data = value;
            next = null;
        }
    }
}
