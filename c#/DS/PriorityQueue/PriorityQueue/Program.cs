using System;

namespace PriorityQueue
{
    
    
        class Program
    {
        static void Main(string[] args)
        {
            PriorityQueueNode<dynamic> pq =new PriorityQueueNode<dynamic>();
            var options = "\nPlease Select the options below\n" +
                "1 to Enqueue\n" +
                "2 to Dequeue\n" +

                "3 to Peek\n" +
                "4 Contain\n" +
                "5 to get Size\n" +
                "6 to Reverse\n" +
                "7 to iterator\n" +
                "8 Traverse\n" +
                "Any other Key to exit";
            int user_input, get_priority, choice;
            bool res, iteratorFlag = false, flag = true;
            dynamic get_value;

            Node<dynamic> tempNode;
            Iterator<dynamic> i = new Iterator<dynamic>();

            while (flag)
            {
                Console.WriteLine(options);
                res = int.TryParse(Console.ReadLine(), out user_input);
                if (!res)
                {
                    Console.WriteLine("please select Integer");
                    continue;
                }
                switch (user_input)
                {
                    case 1:
                        Console.WriteLine("Please Select Value to insert into queue ");
                        get_value = Console.ReadLine();
                        Console.WriteLine("Please Select Priority ");
                        get_priority = Convert.ToInt32(Console.ReadLine());
                        pq.enqueue(get_value, get_priority);
                        break;

                    case 2:
                        Console.WriteLine("Dequeued");

                        pq.dequeue();
                        break;
                    case 3:
                        Console.WriteLine("Peek");

                        pq.peek();
                        Console.WriteLine("Delete At Position");
                        break;
                    case 4:
                        Console.WriteLine("Contain");
                        get_value = Console.ReadLine();
                        Console.WriteLine(pq.contain(get_value));
                        break;
                    case 5:
                        Console.WriteLine("get size");
                        pq.size();
                        break;
                    case 6:
                        Console.WriteLine("Reverse");
                        pq.reverse();
                        break;
                    case 7:
                        Console.WriteLine("Iterator");


                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = pq.get_Node();
                            i = new Iterator<dynamic>(tempNode);
                            iteratorFlag = true;
                        }
                        Console.WriteLine("this is choice" + choice);
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("this is 1");
                                i.next();
                                break;

                            case 2:
                                Console.WriteLine("this is 2");
                                iteratorFlag = false;
                                i.reset();
                                break;
                            default:
                                Console.WriteLine("this is 3");
                                break;

                        }


                        break;

                    case 8:
                        Console.WriteLine("Printing Values");
                        pq.print();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                }
            }



            //Node node = pq.newNode(4, 5);

            /*pq.enqueue(5, 2);

            pq.enqueue(6, 2);

            pq.enqueue(7, 4);

            pq.enqueue(700, 1);
            pq.enqueue(700111, 0);

            pq.print();
            pq.reveserAll();
            pq.print();*/


            //pq.size();

            //Console.WriteLine("\n");
            /*pq.print();
            Console.WriteLine("\n" + pq.peek() + " peek");
            pq.dequeue();
            pq.print();

            Console.WriteLine("\n" + pq.peek() + " peek");
            pq.dequeue();
            pq.print();


            Console.WriteLine(pq.contain(4));*/

            //pq.size();


            //pq.print();
            //pq.print();
            /*pq.reveserAll();
            pq.enqueue(70, 40);
            //pq.print();
            pq.reveserAll();
            pq.enqueue(17, 14);
            //pq.print();

            Node<dynamic> tempNode = pq.get_Node();
            iterator<dynamic> i = new iterator<dynamic>(tempNode);
            tempNode = i.next(tempNode);
            tempNode = i.next(tempNode);
            tempNode = i.next(tempNode);*/


            //pq.size();

            //pq.print();
            // Console.WriteLine(pq.peek());

            Console.ReadLine();
        }
    }
}
