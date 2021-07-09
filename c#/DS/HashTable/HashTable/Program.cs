
using System;

namespace HashTable
{

    class Program
    {
        static void Main(string[] args)
        {
            HashTable<dynamic,dynamic> ht = new HashTable<dynamic,dynamic>();

            var options = "\nPlease Select the options below\n" +
                "1 to insert\n" +
                "2 to delete\n" +
                "3 to contain\n" +
                "4 get value by key\n" +
                "5 to get Size\n" +
                "6 to iterator\n" +
                "7 to print\n" +

                "Any other Key to exit";


            int user_input, choice;
            bool res, iteratorFlag = false, flag = true;
            dynamic get_value, get_key;


            Node<dynamic,dynamic> tempNode;
            Iterator<dynamic,dynamic> i = new Iterator<dynamic,dynamic>();

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
                        Console.WriteLine("Please Select Value to key ");
                        get_key = Console.ReadLine();

                        Console.WriteLine("Please Select Value to value ");
                        get_value = Console.ReadLine();
                        ht.Add(get_key, get_value);
                        break;

                    case 2:
                        Console.WriteLine("Delete");
                        Console.WriteLine("Please Select Value to key which you want to delete");
                        get_key = Console.ReadLine();
                        ht.remove(get_key);
                        break;
                    case 3:
                        Console.WriteLine("Contain");
                        Console.WriteLine("Please Select Value to key to check if its present or not");
                        get_key = Console.ReadLine();

                        ht.contain(get_key);
                        Console.WriteLine("Delete At Position");
                        break;
                    case 4:
                        Console.WriteLine("Contain");
                        Console.WriteLine("Please Select Value to key to check the value");
                        get_key = Console.ReadLine();
                        ht.get_value_by_id(get_key);
                        break;
                    case 5:
                        Console.WriteLine("get size");
                        ht.size();
                        break;

                    case 6:
                        Console.WriteLine("Iterator");


                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = ht.get_main_Node();
                            i = new Iterator<dynamic,dynamic>(tempNode);
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

                    case 7:
                        Console.WriteLine("Printing ");
                        ht.print();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                }
            }



            /*ht.Add(2, "B");
            ht.Add(3, "C");
            ht.Add("aaa", "yo");
            ht.Add("sb", "lol");
            ht.Add(4, "D");
            ht.Add("a", "A");
            ht.Add("b", "AFF");
            ht.Add(5, "E");

            ht.print();
            ht.size();
            ht.remove("aaa");
            ht.print();
            ht.size();*/


            Console.ReadKey();
        }
    }
}
