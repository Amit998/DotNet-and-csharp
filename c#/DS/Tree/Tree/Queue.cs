using System;


namespace Tree
{
    class Queue
    {
        public int count;
        public QueueNode front, rear, head;

        public Queue()
        {
            front = null;
            this.count = 0;
        }

        public bool isEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public void enqueue(dynamic data)
        {
            QueueNode node = new QueueNode(data);

            if (count == 0)
            {
                head = rear = node;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
            count++;
        }

        public dynamic deQueue()
        {

            QueueNode temp = head;
            if (count != 0)
            {
                head = head.next;
                count--;
                //Console.WriteLine(temp.data + " dequeued");
                return temp.data;
            }

            else
            {
                return null;
            }


        }
        public void print()
        {
            QueueNode runner = head;

            while (runner != null)
            {

                Console.Write("| " + runner.data + " |\n");
                runner = runner.next;
            }
            Console.Write("\n");

        }



    }
}
