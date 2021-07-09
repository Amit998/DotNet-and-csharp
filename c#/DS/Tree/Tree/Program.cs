using System;

namespace Tree
{
   
    class Program
    {
        static void Main(string[] args)
        {


            NTree myTree = new NTree();
            var options = "\nPlease Select the options below\n" +
                "1 to insert\n" +
                "2 to delete\n" +
                "3 to contain\n" +
                "4 get value by element\n" +
                "5 get element by level\n" +
                "6 to iterator BFS\n" +
                "7 to iterator DFS\n" +
                "8 to print BFS\n" +
                "9 to print DFS\n" +
                "Any other Key to exit";
            int user_input, choice;
            bool res, iteratorFlag = false, flag = true;
            dynamic get_value;


            Queue tempNode;
            Iterator it = new Iterator();

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


                        Console.WriteLine("Please Select Value to Insert ");

                        get_value = Convert.ToInt32(Console.ReadLine());
                        myTree.AddRc(get_value);
                        break;

                    case 2:
                        Console.WriteLine("Delete");
                        Console.WriteLine("Please Select Value to key which you want to delete");
                        user_input = Convert.ToInt32(Console.ReadLine());

                        myTree.delete(user_input);
                        break;
                    case 3:
                        Console.WriteLine("Contain");
                        Console.WriteLine("Please Select Value to key to check if its present or not");
                        user_input = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(myTree.contains(user_input));

                        break;
                    case 4:

                        Console.WriteLine("Get Element By value");
                        user_input = Convert.ToInt32(Console.ReadLine());
                        myTree.get_element_value(user_input);
                        break;
                    case 5:
                        Console.WriteLine("Please value by level");
                        user_input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(myTree.get_level_value(user_input));
                        break;
                    case 6:
                        Console.WriteLine("Iterator BFS ");
                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = myTree.get_node_bfs();
                            it = new Iterator(tempNode);
                            iteratorFlag = true;
                        }
                        Console.WriteLine("this is choice" + choice);
                        switch (choice)
                        {
                            case 1:

                                it.next();
                                break;

                            case 2:

                                iteratorFlag = false;

                                break;
                            default:
                                Console.WriteLine("");
                                break;

                        }

                        break;
                    case 7:
                        Console.WriteLine("Iterator DFS ");

                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = myTree.get_node_bfs();
                            it = new Iterator(tempNode);
                            iteratorFlag = true;
                        }
                        Console.WriteLine("this is choice" + choice);
                        switch (choice)
                        {
                            case 1:

                                it.next();
                                break;

                            case 2:

                                iteratorFlag = false;
                                break;
                            default:
                                Console.WriteLine("");
                                break;
                        }
                        break;
                    case 8:
                        Console.WriteLine("BFS");
                        myTree.BFS();

                        break;
                    case 9:
                        Console.WriteLine("DFS");
                        myTree.DFS();

                        break;
                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                }
            }



            /* myTree.AddRc(5);
             myTree.AddRc(13);
             myTree.AddRc(11);
             myTree.AddRc(14);

             myTree.AddRc(22);
             myTree.AddRc(6);
             myTree.AddRc(9);
             myTree.get_element_value(6);*/




            //Console.WriteLine("Reset");
            //it.next();

            //Console.WriteLine(myTree.contains(5));
            //Console.WriteLine(myTree.get_level_value(5));
            //myTree.get_element_value(6);
            //myTree.BFS();
            //myTree.DFS();

            ;


            //myTree.inorder();

            //myTree.printRe();
            //myTree.DFS();

            /*Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(100);
            queue.enqueue(1000);
            queue.deQueue();
            queue.print();
            queue.deQueue();
            queue.print();*/



            //myTree.delete(1);
            //myTree.delete(32);
            //myTree.delete(12);
            //myTree.inorder();
            //myTree.contains(9);

            Console.ReadKey();
        }
    }
}