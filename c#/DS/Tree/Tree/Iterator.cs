using System;


namespace Tree
{
    class Iterator
    {

        Queue mainNode, tempNode;

        public Iterator(Queue node)
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
                    Console.WriteLine(mainNode.deQueue());
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

            this.mainNode = tempNode;

        }

    }
}
