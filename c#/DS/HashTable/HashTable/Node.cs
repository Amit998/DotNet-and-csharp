using System;


namespace HashTable
{
    public class Node<T, T2>
    {
        public dynamic key;
        public T data;
        public dynamic tempValue;
        public bool isString = false;
        public Node<T, T2> next;
    }
}
