using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            if (i == index)
            {
                myLList.Remove(current);
                return;
            }

            i++;
            current = current.Next;
        }
    }
}
