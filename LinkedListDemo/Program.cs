// See https://aka.ms/new-console-template for more information
using LinkedListDemo;

SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
singlyLinkedList.Insert(2);
singlyLinkedList.Insert(3);
singlyLinkedList.Insert(4);
singlyLinkedList.PrintList();

singlyLinkedList.Reverse();
singlyLinkedList.PrintList();

LinkedListExercises linkedListExercises = new(singlyLinkedList);
linkedListExercises.InsertAtBegin(1);
singlyLinkedList.PrintList();

