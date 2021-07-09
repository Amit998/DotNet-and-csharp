using System;


namespace Queue
{
    class Queue<T>
    {
        public int count;
        public QueueClassNode<T> front, head, rear;
        public int queue_size = 100;

        public Queue()
        {
            front = null;
            this.count = 0;
        }
        public Queue(int size)
        {
            queue_size = size;
        }

        public bool OverFlow()
        {
            if (count >= queue_size)
            {
                return true;
            }
            return false;
        }

        public bool UnderFlow()
        {
            if (count < 1)
            {
                return true;
            }
            return false;
        }


        public void enqueue(T data)
        {

            try
            {
                if (OverFlow())
                {
                    throw new CustomException("Queue Overflow");
                }
                Console.Write("inserted value " + data + "\n");

                QueueClassNode<T> node = new QueueClassNode<T>(data);

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
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

        public dynamic dequeue()
        {

            QueueClassNode<T> runner = head;

            try
            {
                if (UnderFlow())
                {
                    throw new CustomException("UnderFlow");


                }


                if (runner == null)
                {
                    throw new CustomException("Empty");
                }

                head = head.next;
                count--;
                Console.WriteLine(runner.data + " dequeued");
                return runner.data;




            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



            return null;


        }

        public void size()
        {
            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty Queue");
                }

                Console.WriteLine(count);

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void print()
        {
            QueueClassNode<T> runner = head;



            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Queue");
                }

                while (runner != null)
                {

                    Console.Write("| " + runner.data + " |\n");
                    runner = runner.next;
                }
                Console.Write("\n");


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void reverse()
        {
            QueueClassNode<T> runner = head, prev = null, next = null;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Queue");
                }

                while (runner != null)
                {
                    next = runner.next;
                    runner.next = prev;
                    prev = runner;
                    runner = next;

                }

                head = prev;

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }






        }

        public QueueClassNode<T> get_Node()
        {
            return head;
        }

        public bool contain(T data)
        {
            QueueClassNode<T> runner = head;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Queue");
                }
                while (runner != null)
                {

                    if (data.Equals(runner.data))
                    {
                        return true;
                    }
                    runner = runner.next;
                }

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            };

            return false;
        }

        public dynamic peek()
        {
            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty Queue");
                }
                return head.data;
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }



    }
}
