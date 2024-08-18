using System;

namespace DoublyLinkedListDemo;

public class DoublyLinkedList
{
    public DoublyNode head;
    public DoublyLinkedList()
    {
        head = null;
    }

    public void Insert(int data){
        DoublyNode doublyNode = new DoublyNode(data);
        if(head == null){
            head = doublyNode;
            return;
        }
        DoublyNode temp = head;
        while(temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = doublyNode;
        doublyNode.Prev = temp;
    }

    public void PrintDoublyLinkedList(){
        if(head == null){
            return;
        }
        DoublyNode temp = head;
        while(temp!=null){
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
    }

    public void ReverseDoublyLinkedList(){
        DoublyNode current = head;
        DoublyNode temp = null;

        while (current != null)
        {
            // Swap the Next and Prev pointers for each node
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;

            // Move to the next node in the original order
            current = current.Prev;
        }

        // After the loop, temp will be pointing to the new head
        if (temp != null)
        {
            head = temp.Prev;
        }
    }
}
