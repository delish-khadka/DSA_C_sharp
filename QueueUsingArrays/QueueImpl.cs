using System;

namespace QueueUsingArrays;

public class QueueImpl
{
    private int[] elements;
    private int front;
    private int rear;
    private int maxSize;
    private int count;

    public QueueImpl(int size)
    {
        elements = new int[size];
        maxSize = size;
        front = 0;
        rear = -1;
        count = 0;
    }

    // Enqueue operation
    public void Enqueue(int value)
    {
        if (count == maxSize)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }
        rear = (rear + 1) % maxSize;
        elements[rear] = value;
        count++;
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        int dequeuedValue = elements[front];
        front = (front + 1) % maxSize;
        count--;
        return dequeuedValue;
    }

    // Peek operation
    public int Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        return elements[front];
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return count == 0;
    }
}

