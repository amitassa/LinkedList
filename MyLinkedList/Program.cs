using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddFirst(6);
            linkedList.AddFirst(7);
            linkedList.AddFirst(8);
            linkedList.AddFirst(9);

            //linkedList.AddFirst(linkedList.Last);
            Console.WriteLine(CirclularLinkedListValidator.IsCircular(linkedList));
            Console.Read();
        }
    }
}
