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

    // Delete a node with a specific value
    public void Delete(int value)
    {
        // If the list is empty, there's nothing to delete, so return
        if (head == null) return;

        // If the head node contains the value to be deleted
        if (head.Data == value)
        {
            head = head.Next;  // Move head to the next node
            if (head != null) 
                head.Prev = null;  // If the new head is not null, update its Prev pointer to null
            return;  // Exit after deleting the head node
        }

        DoublyNode temp = head;
        
        // Traverse the list to find the node containing the value
        while (temp != null && temp.Data != value)
        {
            temp = temp.Next;  // Move to the next node
        }

        // If the node containing the value is found
        if (temp != null)
        {
            // If the node to delete is not the last node
            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;  // Update the next node's Prev pointer

            // If the node to delete is not the first node after head
            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;  // Update the previous node's Next pointer
        }
    }

}
