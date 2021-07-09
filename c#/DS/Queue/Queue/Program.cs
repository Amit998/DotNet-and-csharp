using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<dynamic> queue = new Queue<dynamic>();


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
            int user_input, choice;
            bool res, iteratorFlag = false, flag = true;
            dynamic get_value;


            QueueClassNode<dynamic> tempNode;
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
                        Console.WriteLine("Please Select Value to push ");
                        get_value = Console.ReadLine();
                        queue.enqueue(get_value);
                        break;

                    case 2:
                        Console.WriteLine("Dequeued");

                        queue.dequeue();
                        break;
                    case 3:
                        Console.WriteLine("Peek");

                        queue.peek();
                        Console.WriteLine("Delete At Position");
                        break;
                    case 4:
                        Console.WriteLine("Contain");
                        get_value = Console.ReadLine();
                        Console.WriteLine(queue.contain(get_value));
                        break;
                    case 5:
                        Console.WriteLine("get size");
                        queue.size();
                        break;
                    case 6:
                        Console.WriteLine("Reverse");
                        queue.reverse();
                        break;
                    case 7:
                        Console.WriteLine("Iterator");

                        Console.WriteLine("Iterator");
                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = queue.get_Node();
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
                        queue.print();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                }
            }
           


            Console.WriteLine();
        }
    }
}
