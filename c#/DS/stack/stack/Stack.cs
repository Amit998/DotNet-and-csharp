using System;


namespace stack
{
    class Stack<T>
    {
        int count;
        StackClassNode<T> top;
        int stack_size = 200;

        public Stack()
        {
            top = null;
            this.count = 0;
        }
        public Stack(int size)
        {
            this.stack_size = size;
        }

        public bool StackOverFlow()
        {
            if (count >= stack_size)
            {
                return true;
            }
            return false;
        }

        public bool StackUnderFlow()
        {
            if (count < 1)
            {
                return true;
            }
            return false;
        }

        public void push(T data)
        {

            try
            {
                if (StackOverFlow())
                {
                    throw new CustomException("Stack Overflow");
                }
                Console.Write("inserted value " + data + "\n");
                StackClassNode<T> node = new StackClassNode<T>(data);
                node.next = top;
                top = node;
                count++;

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }





        }

        public void size()
        {
            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty Stack");
                }

                Console.WriteLine(count);

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void printStack()
        {
            StackClassNode<T> runner = top;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Stack");
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

        public dynamic pop()
        {


            StackClassNode<T> runner = top;
            T val;




            try
            {
                if (StackUnderFlow())
                {
                    throw new CustomException("StackUnderFlow");
                }

                if (runner == null)
                {
                    throw new CustomException("Empty");
                }


                count--;
                val = runner.data;
                top = runner.next;
                Console.Write("popped value " + val + "\n");

                return val;

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;

        }

        public bool contain(T data)
        {
            StackClassNode<T> runner = top;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty stack");
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
            }





            return false;
        }

        public dynamic peek()
        {

            try
            {
                if (count == 0)
                {
                    throw new CustomException("Empty stack");
                }
                return top.data;
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public StackClassNode<T> reveserAll()
        {

            StackClassNode<T> runner = top, prev = null;

            try
            {
                if (runner == null)
                {
                    throw new CustomException("Empty Stack");
                }

                while (runner != null)
                {
                    StackClassNode<T> next = runner.next;

                    runner.next = prev;
                    prev = runner;

                    runner = next;

                }

                top = prev;



            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return top;

        }

        public StackClassNode<T> get_Node()
        {
            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Stack");
                }



            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return top;
        }

    }
}
