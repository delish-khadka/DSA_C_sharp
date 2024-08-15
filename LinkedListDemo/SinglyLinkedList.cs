using System;

namespace LinkedListDemo;

public class SinglyLinkedList
{
    private Node head;

    public SinglyLinkedList()
    {
        head = null;
    }

    // Insert a new node at the end
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Print the linked list
    public void PrintList()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }

    // Delete a node with a specific value
    public void Delete(int value)
    {
        if (head == null) return;

        if (head.Data == value)
        {
            head = head.Next;
            return;
        }

        Node temp = head;
        while (temp.Next != null && temp.Next.Data != value)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    // Reverse the linked list
    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        head = prev;
    }

    // Detect a loop in the linked list
    public bool HasLoop()
    {
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }
        return false;
    }
}

