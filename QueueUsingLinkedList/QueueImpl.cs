using System;

namespace QueueUsingLinkedList;

public class QueueImpl
{
    private QueueNode front;
    private QueueNode rear;

    // Enqueue operation
    public void Enqueue(int data)
    {
        QueueNode newNode = new QueueNode(data);
        if (rear != null)
        {
            rear.Next = newNode;
        }
        rear = newNode;
        if (front == null)
        {
            front = rear;
        }
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        int dequeuedValue = front.Data;
        front = front.Next;
        if (front == null)
        {
            rear = null;
        }
        return dequeuedValue;
    }

    // Peek operation
    public int Peek()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        return front.Data;
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return front == null;
    }
}
