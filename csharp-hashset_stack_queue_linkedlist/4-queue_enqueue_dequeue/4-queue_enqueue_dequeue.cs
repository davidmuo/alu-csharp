using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);

        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: " + aQueue.Peek());

        aQueue.Enqueue(newItem);

        bool found = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"" + search + "\": " + found);

        if (found)
        {
            string item = "";
            while (item != search)
                item = aQueue.Dequeue();
        }

        return aQueue;
    }
}
