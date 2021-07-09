using System;



namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = "\nPlease Select the options below\n" +
                "1 to insert\n" +
                "2 to insert at postion\n" +
                "3 to delete\n" +
                "4 to delete at postion\n" +
                "5 get center value\n" +
                "6 to reverse the string\n" +
                "7 to get size\n" +
                "8 to iterator\n"+
                "9 Traverse\n" +
                "Any other Key to exit";

            int user_input, pos_value, choice;
            bool res,iteratorFlag=false, flag = true;
            dynamic get_value;
            

           
      

            LinkedList<dynamic> linkedList = new LinkedList<dynamic>();


            LinkedListNode<dynamic> tempNode;
            Iterator<dynamic> i= new Iterator<dynamic>();



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
                        Console.WriteLine("Please Select Value to insert ");
                        get_value = Console.ReadLine();
                        linkedList.AddNode(get_value);
                        break;
                    case 2:
                        Console.WriteLine("Please Select Value to insert ");
                        get_value = Console.ReadLine();
                        Console.WriteLine("Please Select position of the value to insert ");
                        pos_value = Convert.ToInt32(Console.ReadLine());
                        linkedList.AddAtPosition(pos_value, get_value);


                        break;
                    case 3:
                        Console.WriteLine("Deleted");
                
                        linkedList.DeleteNode();
                        break;
                    case 4:
                        Console.WriteLine("Please Select position of Value to delete ");
                        pos_value = Convert.ToInt32(Console.ReadLine());
                        linkedList.DeleteAtPosition(pos_value);
                        Console.WriteLine("Delete At Position");
                        break;
                    case 5:
                        Console.WriteLine("Center");
                        linkedList.atCenter();
                        break;
                    case 6:
                        Console.WriteLine("Reverse");
                        linkedList.reverseLL();
                        break;
                    case 7:
                        Console.WriteLine("size");
                        linkedList.getSize();
                        break;
                    case 8:

                        Console.WriteLine("Iterator");
                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = linkedList.get_Node();
                            i= new Iterator<dynamic>(tempNode);
                            iteratorFlag = true;
                        }
                        Console.WriteLine("this is choice"+choice);
                        switch (choice)
                        {
                            case 1:
                                
                                i.next();
                                break;
                                    
                            case 2:
                                
                                iteratorFlag = false;
                                i.reset();
                                break;
                            default:
                                
                                break;

                        }


                        break;
                    case 9:

                        Console.WriteLine("Printing Values");
                        linkedList.printList();
                        break;


                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}

