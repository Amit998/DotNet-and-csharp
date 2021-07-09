using System;


namespace HashTable
{
    class Iterator<T,T2>
    {

        Node<T, T2> mainNode, tempNode;

        public Iterator(Node<T,T2> node)
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
                    Console.WriteLine(mainNode.key+"->"+mainNode.data);
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
