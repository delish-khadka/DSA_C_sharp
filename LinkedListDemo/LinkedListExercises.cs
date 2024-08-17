using LinkedListDemo;

public class LinkedListExercises
{
    // Private member to hold the reference to an existing singly linked list
    private SinglyLinkedList _singlyLinkedList;

    // Constructor to initialize the LinkedListExercises class with an existing SinglyLinkedList instance
    public LinkedListExercises(SinglyLinkedList singlyLinkedList)
    {
        _singlyLinkedList = singlyLinkedList;
    }

    // Method to insert a new node at the beginning of the linked list
    public void InsertAtBegin(int data)
    {
        // Create a new node with the provided data
        Node newNode = new Node(data);
        
        // The new node's Next should point to the current head of the list
        newNode.Next = _singlyLinkedList.head;
        
        // Update the head of the list to be the new node
        _singlyLinkedList.head = newNode;     
    }

    // Method to insert a new node at a specific position in the linked list
    public void InsertAtSpecificPosition(int index, int value)
    {
        // Create a new node with the provided value
        Node newNode = new Node(value);
        int counter = 0;

        // If the position is 0, insert the node at the beginning
        if(index == 0)
        {
            newNode.Next = _singlyLinkedList.head;
            _singlyLinkedList.head = newNode; 
            return;
        }

        // Start from the head of the list
        Node temp = _singlyLinkedList.head;

        // Traverse to the node before the insertion point
        while (temp != null && counter < index - 1)
        {
            temp = temp.Next;
            counter++;
        }

        // If the desired position is beyond the list length, throw an exception
        if (temp == null)
        {
            throw new ArgumentException("Invalid position");
        }

        // Insert the new node: Set its Next to point to the current node at the index
        newNode.Next = temp.Next;
        
        // Update the previous node's Next to point to the new node
        temp.Next = newNode;
    }

    // Method to delete the first node in the linked list
    public void DeleteAtBeginning()
    {
        // If the list is not empty, update the head to the next node, effectively removing the first node
        Node temp = _singlyLinkedList.head;
        if (temp != null)
        {
            _singlyLinkedList.head = temp.Next;
        }
    }

    // Method to delete the last node in the linked list
    public void DeleteLastNode()
    {
        // If the list is empty, there's nothing to delete, so return
        if (_singlyLinkedList.head == null)
        {
            return;
        }

        // Start from the head of the list
        Node temp = _singlyLinkedList.head;

        // If the list has only one node, remove it by setting head to null
        if (temp.Next == null)
        {
            _singlyLinkedList.head = null;
            return;
        }

        // Traverse the list until you reach the second last node
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }

        // Set the second last node's Next to null, effectively removing the last node
        temp.Next = null;
    }

    // Method to delete a node at a given position in the linked list
    public void DeleteAtAPosition(int position)
    {
        // If the position is 0, delete the first node
        if (position == 0)
        {
            _singlyLinkedList.head = _singlyLinkedList.head.Next;
            return;
        }

        int count = 0;
        Node temp = _singlyLinkedList.head;

        // Traverse to the node before the one at the specified position
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        // If the node to delete exists (both the node at 'position-1' and the node at 'position')
        if (temp != null && temp.Next != null)
        {
            // Skip the node at the given position by linking the previous node to the node after it
            temp.Next = temp.Next.Next;
        }
    }

    public int LengthOfLinkedList() {
    // If the linked list is empty, return a length of 0
        if (_singlyLinkedList.head == null) {
            return 0;
        }
        
        // Initialize a counter to keep track of the length
        int lengthCount = 0;
        
        // Start traversing the list from the head node
        Node temp = _singlyLinkedList.head;
        
        // Traverse the list until you reach the end (i.e., temp becomes null)
        while (temp != null) {
            temp = temp.Next;  // Move to the next node
            lengthCount++;      // Increment the counter for each node visited
        }
        
        // Return the total length of the linked list
        return lengthCount;
    }

}
