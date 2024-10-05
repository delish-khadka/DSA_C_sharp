using System;
using System.Collections.Generic;  // Required for List<T>

public class MinHeap
{
    private List<int> Heap = new List<int>();
    
    private int Parent(int i) => (i - 1) / 2;
    private int LeftChild(int i) => 2 * i + 1;
    private int RightChild(int i) => 2 * i + 2;

    // Insert a value into the min-heap
    public void InsertMin(int value)
    {
        Heap.Add(value);  // Add value to the end of the list
        int index = Heap.Count - 1;

        // Heapify up (bubble up) to restore the min-heap property
        while (index > 0 && Heap[Parent(index)] > Heap[index])
        {
            Swap(index, Parent(index));
            index = Parent(index);
        }
    }

    // Swap two elements in the heap
    private void Swap(int i, int j)
    {
        int temp = Heap[i];
        Heap[i] = Heap[j];
        Heap[j] = temp;
    }

    // Extract the minimum value from the heap
    public int ExtractMin()
    {
        if (Heap.Count == 0)
        {
            throw new InvalidOperationException("No values in Heap");
        }

        int min = Heap[0];  // The root (minimum value)
        Heap[0] = Heap[Heap.Count - 1];  // Move the last element to the root
        Heap.RemoveAt(Heap.Count - 1);   // Remove the last element

        // Only heapify-down if there are elements left in the heap
        if (Heap.Count > 0)
        {
            HeapifyDown(0);
        }

        return min;
    }

    // Heapify-down to restore the heap property
    private void HeapifyDown(int i)
    {
        int smallest = i;
        int left = LeftChild(i);
        int right = RightChild(i);

        // Check if left child is smaller
        if (left < Heap.Count && Heap[smallest] > Heap[left])
        {
            smallest = left;
        }

        // Check if right child is smaller
        if (right < Heap.Count && Heap[smallest] > Heap[right])
        {
            smallest = right;
        }

        // If the smallest is not the current node, swap and recurse
        if (smallest != i)
        {
            Swap(i, smallest);
            HeapifyDown(smallest);
        }
    }
    // Print the elements in the heap (for debugging purposes)
    public void PrintHeap()
    {
        Console.WriteLine(string.Join(", ", Heap));
    }
}
