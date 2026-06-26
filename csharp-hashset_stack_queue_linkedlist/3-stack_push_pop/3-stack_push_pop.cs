using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);

        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: " + aStack.Peek());

        bool found = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + found);

        if (found)
        {
            string item = "";
            while (item != search)
                item = aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}
