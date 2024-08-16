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

    public void InsertAtSpecificPosition(){}


}