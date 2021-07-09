using System;

namespace linkedList
{
    class Iterator<T>
    {

        LinkedListNode<T> mainNode,tempNode;

        public Iterator(LinkedListNode<T> node)
        {
            this.mainNode = node;
            this.tempNode = node;
        }
        public Iterator()
        {
           
        }
        public void next()
        {
            try
            {
                if (mainNode == null)
                {
                    throw new CustomException("Empty");
                }


                if (mainNode != null)
                {
                    Console.WriteLine(mainNode.data);
                    mainNode = mainNode.next;
                    

                }
                else
                {
                    throw new CustomException("Empty Node");
               
                }


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }

        public void reset()
        {
            mainNode = tempNode;
           
        }

    }
}
