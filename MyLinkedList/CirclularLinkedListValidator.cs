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
            if (linkedList.Count == 0)
                return false;
            //
            LinkedList<T> linkedListDuplicate = new LinkedList<T>(linkedList);
            LinkedList<T> linkedListBackup = new LinkedList<T>(linkedList);
            while (linkedListBackup.Count != 0)
            {
                while (linkedListDuplicate.Count != 0)
                {
                    if (linkedListDuplicate.First == linkedListBackup.First)
                        return true;
                    linkedListDuplicate.RemoveFirst();
                }
                linkedListDuplicate = new LinkedList<T>(linkedList);
                linkedListBackup.RemoveFirst();
            }
            return false;

        }
    }
}
