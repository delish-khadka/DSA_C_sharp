MaxHeap maxHeap = new MaxHeap();

// Insert elements into the heap
maxHeap.Insert(20);
maxHeap.Insert(15);
maxHeap.Insert(10);
maxHeap.Insert(7);
maxHeap.Insert(9);
maxHeap.Insert(8);
maxHeap.Insert(5);
maxHeap.Insert(4);
maxHeap.Insert(3);
// Print the heap
Console.WriteLine("Heap after inserting elements:");
maxHeap.PrintHeap();

// Extract the maximum value
Console.WriteLine("\nExtracting maximum values:");
while (!maxHeap.IsEmpty())
{
    Console.WriteLine("Max: " + maxHeap.ExtractMax());
    maxHeap.PrintHeap();
}