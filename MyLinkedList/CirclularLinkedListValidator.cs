using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    public static class CirclularLinkedListValidator 
    {
        /// <summary>
        /// The method checks if a LinkedList is circular.
        /// The method iterate over the LinkedList, and for every node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public static bool IsCircular<T>(LinkedList<T> linkedList)
        {
            if (linkedList.First == null)
                return false;
            LinkedListNode<T> nodePosition1 = linkedList.First;
            LinkedListNode<T> nodePosition2 = linkedList.First;
            while (nodePosition2 != null & nodePosition1 != null)
            {
                try
                {
                    nodePosition1 = nodePosition1.Next;
                    nodePosition1 = nodePosition2.Next.Next;
                    if (nodePosition1 == nodePosition2)
                        return true;
                }
                catch

                {
                    return false;
                }
            }
            return false;

        }

    }
}
