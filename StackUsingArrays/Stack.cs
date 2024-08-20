public class Stack
{
    private int[] elements;
    private int top;
    private int maxSize;

    public Stack(int size)
    {
        elements = new int[size];
        maxSize = size;
        top = -1;
    }

    // Push operation
    public void Push(int value)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        elements[++top] = value;
    }

    // Pop operation
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        return elements[top--];
    }

    // Peek operation
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        return elements[top];
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }
}
