using System;

namespace StackUsingLinkedList;

public class Stack
{
    private StackNode top;

    // Push operation
    public void Push(int data)
    {
        StackNode newNode = new StackNode(data);
        newNode.Next = top;
        top = newNode;
    }

    // Pop operation
    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        int poppedData = top.Data;
        top = top.Next;
        return poppedData;
    }

    // Peek operation
    public int Peek()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        return top.Data;
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == null;
    }
}
