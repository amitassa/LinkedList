using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    public static class CirclularLinkedListValidator 
    {
        public static bool IsCircular<T>(LinkedList<T> linkedList)
        {
            if (linkedList.Count == 0)
                return false;
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
