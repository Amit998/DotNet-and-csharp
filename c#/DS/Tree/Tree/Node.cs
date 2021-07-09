using System;


namespace Tree
{
    class Node
    {
        public dynamic value, mainValue;
        public Node left, right;
        public dynamic int_value;
        public bool isString = false;


        public Node(dynamic initial)
        {
            isString = initial is string;
            value = isString ? get_asci_value_of_string(initial) : initial;
            mainValue = initial;
            right = left = null;

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

    }
}
