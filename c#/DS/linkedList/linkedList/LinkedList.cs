using System;


namespace linkedList
{
    class LinkedList<T>
    {
        int count;
        LinkedListNode<T> head;

        public LinkedList()
        {
            head = null;
            this.count = 0;

        }

        public void AddNode(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);
            node.next = head;
            head = node;
            count++;
        }

        public void DeleteNode()
        {
            LinkedListNode<T> runner = head;


            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Linked List");
                }
                else
                {


                    LinkedListNode<T> nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;


                    head = runner.next;
                    return;

                }
                /*if ()
                {

                }
                if (!contain(given))
                {
                    throw new CustomException("No Value Found");
                }
                


                count--;

                while (runner != null && given.Equals(runner.data))
                {
                    head = runner.next;
                    return;
                }

                while (runner != null && !given.Equals(runner.Data))
                {
                    prev = runner;
                    runner = runner.next;
                }

                if (runner == null)
                {
                    return;
                }

                prev.next = runner.next;


            }*/
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }

        public void AddAtPosition(int position, T data)
        {


            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            LinkedListNode<T> runner = head;

            try
            {
                if (position > count || runner == null || position < 1)
                {

                    throw new CustomException("Position is bigger then the linkedSize");
                }

                count++;

                if (position == 1)
                {

                    newNode.next = head;
                    head = newNode;
                }

                else
                {
                    LinkedListNode<T> temp = new LinkedListNode<T>();
                    temp = head;

                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }

                    if (temp != null)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                }




            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public void DeleteAtPosition(int position)
        {
            LinkedListNode<T> runner = head;
            LinkedListNode<T> prev = null;
            count--;

            int index = 1;
            try
            {
                if (runner == null)
                {
                    count++;
                    throw new CustomException("Empty Linked List");
                }
                if (runner != null && index == position)
                {
                    //Console.WriteLine("first");
                    LinkedListNode<T> nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;


                    head = runner.next;
                    return;
                }

                while (runner != null && index != position)
                {
                    index++;
                    prev = runner;
                    runner = runner.next;
                }

                prev.next = runner.next;


            }
            catch (CustomException ce)
            {
                Console.WriteLine(ce.Message);
            }

        }

        public void getSize()
        {
            Console.WriteLine("\n" + count);
        }

        public void printAtPos(int pos)
        {
            LinkedListNode<T> runner = head;
            int index = 1;

            try
            {

                if (count < pos || pos < 0)
                {
                    throw new CustomException("invalid position");
                }
                while (index != pos)
                {
                    runner = runner.next;
                    index++;

                }

                Console.WriteLine(runner.data);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public void atCenter()
        {

            int middle = (count / 2);


            if (count % 2 == 0)
            {
                printAtPos(middle);

            }
            else
            {
                printAtPos(middle + 1);
            }
            //Console.WriteLine("\n" + count);
            //Console.WriteLine("\n" + middle);
        }

        public LinkedListNode<T> reverseLL()
        {
            LinkedListNode<T> runner = head, prev = null;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty");

                }
                while (runner != null)
                {
                    LinkedListNode<T> next = runner.next;
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


            return head;


        }



        public void printList()
        {
            LinkedListNode<T> runner = head;

            while (runner != null)
            {
                Console.Write(runner.data + "->");
                runner = runner.next;
            }
            Console.Write("NULL  \n");
        }

        public void iterateLL()
        {
            LinkedListNode<T> runner = head;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty");
                }

                while (runner != null)
                {
                    Console.Write(runner.data + "\n");
                    runner = runner.next;
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public LinkedListNode<T> get_Node()
        {
            return head;
        }

        public bool contain(T given)
        {
            LinkedListNode<T> runner = head;

            while (runner != null)
            {
                if (runner.data.Equals(given))
                {
                    return true;
                }
                runner = runner.next;
            }


            return false;
        }

    }
}
