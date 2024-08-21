using System;

namespace StackUsingLinkedList;

public class StackNode
{
    public int Data;
    public StackNode Next;

    public StackNode(int data)
    {
        Data = data;
        Next = null;
    }
}