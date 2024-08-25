using System;

namespace QueueUsingLinkedList;

public class QueueNode
{
    public int Data;
    public QueueNode Next;

    public QueueNode(int data)
    {
        Data = data;
        Next = null;
    }
}
