using System;


namespace PriorityQueue
{
    public class PriorityQueueNode<T>
    {
        int count;
        Node<T> mainNode;
        bool isLowToHigh = true;
        int queue_size = 100;


        public PriorityQueueNode()
        {
            mainNode = null;
            this.count = 0;

        }

        public PriorityQueueNode(int size)
        {
            mainNode = null;
            this.count = 0;
            this.queue_size = size;

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

        public Node<T> newNode(T data, int priority_val)
        {

            Node<T> temp = new Node<T>();
            temp.data = data;
            temp.priority = priority_val;
            temp.next = null;
            count++;
            return temp;
        }

        public dynamic peek()
        {
            Node<T> head = mainNode;

            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty Queue");
                }
                Console.WriteLine(head.data);
                return head.data;
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
            //Console.WriteLine("PRINTING VALUE ");


            Node<T> runner = mainNode;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Queue");
                }

                while (runner != null)
                {
                    Console.Write("\n data->  " + runner.data + "  priority  ->  " + runner.priority);
                    runner = runner.next;
                }
                Console.Write("\n");


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public bool isContainPriority(int value)

        {

            Node<T> runner = mainNode;

            while (runner != null)
            {
                if (runner.priority == value)
                {
                    return true;
                }
                runner = runner.next;
            }


            return false;

        }

        public bool isContainPriorityValue(dynamic value)
        {

            Node<T> runner = mainNode;

            while (runner != null)
            {
                if (runner.data == value)
                {
                    return true;
                }
                runner = runner.next;
            }




            return false;
        }



        public void enqueue(T data, int priority_val)
        {



            try
            {
                if (OverFlow())
                {
                    throw new CustomException("Queue Overflow");
                }
                if (isContainPriority(priority_val))
                {
                    throw new CustomException("This Priority Already Exists");
                }
                Node<T> start = mainNode;

                Node<T> temp = newNode(data, priority_val);
                Node<T> head = mainNode;
                if (mainNode == null)
                {

                    mainNode = temp;
                }

                else
                {
                    if (isLowToHigh)
                    {
                        if (head.priority > priority_val)
                        {
                            temp.next = head;
                            head = temp;

                            //count++;
                        }
                        else
                        {
                            while (start.next != null && start.next.priority < priority_val)
                            {
                                start = start.next;
                            }
                            temp.next = start.next;
                            start.next = temp;
                            //count++;
                        }
                    }
                    else if (!isLowToHigh)
                    {
                        if (head.priority < priority_val)
                        {
                            temp.next = head;
                            head = temp;

                            //count++;
                        }
                        else
                        {
                            while (start.next != null && start.next.priority > priority_val)
                            {
                                start = start.next;
                            }
                            temp.next = start.next;
                            start.next = temp;
                            //count++;
                        }
                    }


                    mainNode = head;


                }

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public void dequeue()
        {
            Node<T> runner = mainNode;
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

                count--;
                Console.WriteLine("Dequeued Value is " + runner.data);
                mainNode = runner.next;


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }






        }

        public void printNode(Node<T> runner)
        {
            while (runner != null)
            {
                Console.WriteLine("\n data" + runner.data + "  priority" + runner.priority);
                runner = runner.next;
            }
        }

        public bool isEmpty()
        {
            Node<T> head = mainNode;
            return head == null ? true : false;
        }

        public Node<T> reverse()
        {
            Console.WriteLine("\n reversed");
            Node<T> runner = mainNode, prev = null;

            if (runner == null)
            {
                Console.WriteLine("Empty ");
                return runner;
            }

            while (runner != null)
            {
                Node<T> next = runner.next;
                //Console.Write("\n  "+runner.data);
                runner.next = prev;
                prev = runner;
                runner = next;
            }

            //printNode(prev);
            mainNode = prev;

            return mainNode;
        }

        public bool contain(dynamic data)
        {
            Node<T> runner = mainNode;

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

                    if (data.Equals(runner.data))
                    {
                        return true;
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

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            };

            return false;



        }
        public void reveserAll()
        {

            Node<T> runner = mainNode, prev = null, next = null;


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

                isLowToHigh = !isLowToHigh;
                mainNode = prev;



            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Node<T> get_Node()
        {
            return mainNode;
        }


    }
}
