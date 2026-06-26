using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            if (current.Value == value)
                return index;

            index++;
            current = current.Next;
        }

        return -1;
    }
}
