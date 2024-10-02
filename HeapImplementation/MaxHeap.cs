public class MaxHeap{

    public List<int> heap = new List<int>();

    //parent node
    private int Parent(int i) => (i - 1)/2;

    //left node 
    private int LeftChild(int i) => 2 * i + 1;

    //right node
    private int RightChild(int i) => 2 * i + 2;

    // Check if the heap is empty
    public bool IsEmpty() => heap.Count == 0;

    public void Insert(int value){
        // Add the value to the end of the list (bottom of the heap)
        heap.Add(value);
        int index = heap.Count - 1;

        //heapify up
        while(index > 0 && heap[Parent(index)] < heap[index]){
            Swap(index,Parent(index));
            index = Parent(index);
        }
    }

    private void Swap(int a, int b){
        int temp = heap[a];
        heap[a] = heap[b];
        heap[b] = temp;
    }

    // Extract the maximum value (the root) from the heap
    public int ExtractMax()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty!");

        int max = heap[0];  // The root (maximum value)
        heap[0] = heap[heap.Count - 1];  // Move the last element to the root
        heap.RemoveAt(heap.Count - 1);   // Remove the last element

        // Heapify-down: move the new root down to restore heap property
        HeapifyDown(0);

        return max;  // Return the maximum value
    }

    // Heapify-down to maintain the max-heap property
    private void HeapifyDown(int i)
    {
        int largest = i;
        int left = LeftChild(i);
        int right = RightChild(i);

        // Check if left child is larger than the current node
        if (left < heap.Count && heap[left] > heap[largest])
            largest = left;

        // Check if right child is larger than the current largest
        if (right < heap.Count && heap[right] > heap[largest])
            largest = right;

        // If the largest is not the current node, swap and heapify-down further
        if (largest != i)
        {
            Swap(i, largest);
            HeapifyDown(largest);
        }
    }

    // Print the elements in the heap (for debugging purposes)
    public void PrintHeap()
    {
        Console.WriteLine(string.Join(", ", heap));
    }
}