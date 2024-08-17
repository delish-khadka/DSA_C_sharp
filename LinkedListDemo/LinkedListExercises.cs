using LinkedListDemo;

public class LinkedListExercises{
    private SinglyLinkedList _singlyLinkedList;
    public LinkedListExercises(SinglyLinkedList singlyLinkedList)
    {
        _singlyLinkedList = singlyLinkedList;
    }
    public void InsertAtBegin(int data){
        Node newNode = new Node(data);
        //not using if because we have to insert at the head even if no nodes
        //if(_singlyLinkedList.head != null){ 
        newNode.Next = _singlyLinkedList.head;
        _singlyLinkedList.head = newNode;     
    }

    public void InsertAtSpecificPosition(int index, int value){
        Node newNode = new Node(value);
        int counter = 0;
        if(index == 0){
            newNode.Next = _singlyLinkedList.head;
            _singlyLinkedList.head = newNode; 
            return;
        }
        Node temp = _singlyLinkedList.head;
        

        // Traverse to the node before the insertion point
        while (temp != null && counter < index - 1)
        {
            temp = temp.Next;
            counter++;
        }

        // If position is beyond the list length
        if (temp == null)
        {
            throw new ArgumentException("Invalid position");
        }

        // Insert the new node
        newNode.Next = temp.Next;
        temp.Next = newNode;

    }

    public void DeleteAtBeginning(){
        Node temp = _singlyLinkedList.head;
        if (temp != null){
            _singlyLinkedList.head = temp.Next;
        }
    }

    public void DeleteLastNode() {
        if (_singlyLinkedList.head == null) {
            return;  // List is empty, nothing to delete
        }

        Node temp = _singlyLinkedList.head;

        if (temp.Next == null) {
            // List has only one node
            _singlyLinkedList.head = null;  // Remove the only node, making the list empty
            return;
        }

        // Traverse the list until you find the second last node
        while (temp.Next.Next != null) {
            temp = temp.Next;
        }

        // Set the second last node's Next to null, effectively removing the last node
        temp.Next = null;
    }

    public void DeleteAtAPosition(int position) {
        if (position == 0){
            _singlyLinkedList.head = _singlyLinkedList.head.Next;
            return;
        }
        int count = 0;
        Node temp = _singlyLinkedList.head;
        while (temp != null && count<position-1){
            temp = temp.Next;
            count++;
        }
        if(temp != null && temp.Next != null){
            temp.Next = temp.Next.Next;
        }
    }

    

}