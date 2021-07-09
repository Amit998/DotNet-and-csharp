using System;


namespace HashTable
{
    public class HashTable<T, T2>
    {
        int count;
        Node<T, T2> mainNode;
        int hasTable_size = 100;

        public HashTable()
        {
            this.count = 0;
            mainNode = null;
        }

        public Node<T, T2> newNode(dynamic key, T data)
        {

            //Console.WriteLine((int)key+" lol" + key);

            /*int tempValue;*/

            /*if(key is string)
            {
                tempValue = get_asci_value_of_string(key);
            }
            else
            {
                tempValue = key;
            }*/


            Node<T, T2> temp = new Node<T, T2>();
            temp.isString = key is string;
            temp.tempValue = temp.isString ? get_asci_value_of_string((key)) : 1;

            temp.key = key;
            temp.data = data;
            temp.next = null;
            count++;
            return temp;
        }


        public int get_asci_value_of_string(string value)
        {
            int total = 0;

            foreach (var c in value)
            {
                total += (int)c;
            }

            return total;
        }

        public bool isLessThen(int A, int B)
        {
            if (A < B)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public int filter(Node<T, T2> head, dynamic value)
        {
            int tempValue = head.isString ? head.tempValue : head.key;
            return tempValue;
        }

        public int key_tester(dynamic value)
        {


            return value is string ? get_asci_value_of_string(value) : value;
        }

        public bool OverFlow()
        {
            if (count >= hasTable_size)
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

        public void Add(dynamic key, T data)
        {
            Node<T, T2> start = mainNode;
            Node<T, T2> head = mainNode;
            Node<T, T2> temp = newNode(key, data);
            int tempValue = filter(temp, temp.key);
            int key_tester_value = key_tester(key);


            try
            {
                if (contain(key))
                {
                    throw new CustomException("Key Exception");
                }


                if (mainNode == null)
                {
                    mainNode = temp;
                }
                else if (!contain(key))
                {

                    if (tempValue > key_tester_value)
                    {
                        temp.next = head;
                        head = temp;
                    }
                    else
                    {
                        while (start.next != null && key_tester(start.next.key) < key_tester_value)
                        {
                            start = start.next;
                        }
                        temp.next = start.next;
                        start.next = temp;
                    }
                    mainNode = head;
                }
                else
                {
                    Node<T, T2> runner = mainNode;
                    while (runner != null)
                    {
                        if (runner.key == key_tester_value)
                        {

                            runner.data = data;

                        }
                        runner = runner.next;
                    }
                }


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
        /*public Node<T, T2> get_Node()
        {
            return mainNode;
        }*/

        public void size()
        {

            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty");
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
            Node<T, T2> runner = mainNode;


            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Hash Table");
                }

                while (runner != null)
                {
                    Console.Write(runner.key + " is key " + runner.data + "\n");
                    runner = runner.next;
                }
                Console.Write("\n");


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public bool isEmpty()
        {
            Node<T, T2> head = mainNode;
            return head == null ? true : false;
        }



        public bool contain(dynamic key)
        {
            Node<T, T2> runner = mainNode;



            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Hash Table");
                }
                if (isEmpty())
                {
                    throw new CustomException("Empty Hash Table");

                }
                int tempValue = filter(runner, runner.key);
                int key_tester_value = key_tester(key);

                if (tempValue == key_tester_value)
                {
                    return true;
                }

                while (runner != null)
                {
                    if (tempValue == key_tester_value)
                    {

                        return true;
                    }

                    runner = runner.next;
                }


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



            return false;
        }


        public void remove(dynamic key)
        {
            Node<T, T2> runner = mainNode;
            Node<T, T2> prev = null;



            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty");
                }
                if (contain(key))
                {
                    throw new CustomException("Unkown Key");

                }

                count--;

                while (runner != null && key_tester(runner.key) == key_tester(key))
                {
                    //Console.WriteLine("first");
                    mainNode = runner.next;
                    return;
                }

                while (runner != null && key_tester(runner.key) != key_tester(key))
                {

                    prev = runner;
                    runner = runner.next;
                }

                prev.next = runner.next;



            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public dynamic get_value_by_id(dynamic key)
        {
            Node<T, T2> runner = mainNode;
            bool flag = false;
            dynamic value = null;


            try
            {
                if (isEmpty())
                {
                    throw new CustomException("Empty HashTable");
                }

                while (runner != null)
                {

                    if (key_tester(runner.key) == key_tester(key))
                    {

                        flag = true;

                        value = runner.data;

                        break;
                    }
                    runner = runner.next;
                }

                if (flag)
                {
                    return value;
                }
                else
                {
                    throw new CustomException("Unable To Found");
                }


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;





        }
        public Node<T, T2> get_main_Node()
        {
            return mainNode;
        }

    }
}
