using System;

namespace LinkedListDemo
{
    // SinglyLinkedList class representing a singly linked list
    public class SinglyLinkedList
    {
        // The head of the linked list (points to the first node)
        public Node head;

        // Constructor to initialize the linked list with an empty head
        public SinglyLinkedList()
        {
            head = null;
        }

        // Method to insert a new node at the end of the linked list
        public void Insert(int data)
        {
            // Create a new node with the given data
            Node newNode = new Node(data);

            // If the list is empty, make the new node the head of the list
            if (head == null)
            {
                head = newNode;
                return;  // Exit the method as the insertion is done
            }

            // Otherwise, traverse to the end of the list
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;  // Move to the next node
            }

            // Set the last node's Next to the new node, inserting it at the end
            temp.Next = newNode;
        }

        // Method to print the data in the linked list
        public void PrintList()
        {
            // Start from the head of the list
            Node temp = head;

            // Traverse through the list until the end
            while (temp != null)
            {
                Console.Write(temp.Data + " ");  // Print the data of the current node
                temp = temp.Next;  // Move to the next node
            }

            Console.WriteLine();  // Print a new line after the entire list is printed
        }

        // Method to delete a node with a specific value
        public void Delete(int value)
        {
            // If the list is empty, there's nothing to delete, so return
            if (head == null) return;

            // If the head node contains the value, update the head to the next node
            if (head.Data == value)
            {
                head = head.Next;
                return;  // Exit the method after deleting the node
            }

            // Otherwise, traverse the list to find the node with the specified value
            Node temp = head;
            while (temp.Next != null && temp.Next.Data != value)
            {
                temp = temp.Next;  // Move to the next node
            }

            // If the node with the value is found, remove it by adjusting the pointers
            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;  // Skip the node to be deleted
            }
        }

        // Method to reverse the linked list
        public void Reverse()
        {
            Node prev = null;        // Previous node starts as null
            Node current = head;     // Current node starts at the head
            Node next = null;        // Next node starts as null

            // Traverse the list and reverse the links
            while (current != null)
            {
                next = current.Next;   // Save the next node
                current.Next = prev;   // Reverse the current node's pointer
                prev = current;        // Move prev and current one step forward
                current = next;
            }

            head = prev;  // Update the head to be the last node encountered
        }

        // Method to detect a loop in the linked list
        public bool HasLoop()
        {
            Node slow = head;  // Slow pointer starts at the head
            Node fast = head;  // Fast pointer also starts at the head

            // Traverse the list with two pointers: slow moves one step, fast moves two steps
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;         // Move slow pointer by one step
                fast = fast.Next.Next;    // Move fast pointer by two steps

                // If the two pointers meet, there is a loop in the list
                if (slow == fast)
                {
                    Console.WriteLine("LL has loop");
                    return true;  // Loop detected
                }
            }

            Console.WriteLine("LL does not has loop");
            return false;  // No loop detected
        }
    }
}
