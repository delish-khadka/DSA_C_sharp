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


}