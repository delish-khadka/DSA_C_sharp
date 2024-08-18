using System;

namespace DoublyLinkedListDemo;

public class DoublyNode
{
    public int Data{get;set;}
    public DoublyNode Prev{get;set;}
    public DoublyNode Next{get;set;}

    public DoublyNode(int data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}
