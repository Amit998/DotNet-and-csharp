using System;

namespace stack
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack<dynamic> stack = new Stack<dynamic>();
            var options = "\nPlease Select the options below\n" +
                "1 to Push\n" +
                "2 to Pop\n" +
              
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
            StackClassNode<dynamic> tempNode;
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
                        stack.push(get_value);
                        break;

                    case 2:
                        Console.WriteLine("Pop");

                        stack.pop();
                        break;
                    case 3:
                        Console.WriteLine("Peek");

                        stack.peek();
                        Console.WriteLine("Delete At Position");
                        break;
                    case 4:
                        Console.WriteLine("Contain");
                        get_value = Console.ReadLine();
                        Console.WriteLine(stack.contain(get_value));
                        break;
                    case 5:
                        Console.WriteLine("get size");
                        stack.size();
                        break;
                    case 6:
                        Console.WriteLine("Reverse");
                        stack.reveserAll();
                        break;
                    case 7:
                        Console.WriteLine("Iterator");

                        Console.WriteLine("Please Select Option Below\n" +
                                "1 for next\n" +
                                "2 for reset\n");
                        choice = Convert.ToInt32(Console.ReadLine());


                        if (!iteratorFlag)
                        {
                            tempNode = stack.get_Node();
                            i = new Iterator<dynamic>(tempNode);
                            iteratorFlag = true;
                        }
                        Console.WriteLine("this is choice" + choice);
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
                                Console.WriteLine("this is 3");
                                break;

                        }


                        break;

                    case 8:
                        Console.WriteLine("Printing Values");
                        stack.printStack();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                }
            }



            /*st.push("1");
            Console.WriteLine(st.pop());
            st.pop();
            st.pop();*/
            /*st.push("2");
            st.push("3");
            st.push("5");*/

            //st.size();
            //st.printStack();
            //st.pop();
            //st.pop();
            //st.printStack();
            //st.printStack();

            //Console.Write(st.contain(1));

            /*StackClassNode<dynamic> tempNode = st.get_Node();
            Iterator<dynamic> i = new Iterator<dynamic>(tempNode);

            i.next();
            i.next();*/

            //tempNode = i.next(tempNode);





            Console.WriteLine("");
        }
    }
}


