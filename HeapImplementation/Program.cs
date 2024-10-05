
// MaxHeap maxHeap = new MaxHeap();

// // Insert elements into the heap
// maxHeap.Insert(20);
// maxHeap.Insert(15);
// maxHeap.Insert(10);
// maxHeap.Insert(7);
// maxHeap.Insert(9);
// maxHeap.Insert(8);
// maxHeap.Insert(5);
// maxHeap.Insert(4);
// maxHeap.Insert(3);
// // Print the heap
// Console.WriteLine("Heap after inserting elements:");
// maxHeap.PrintHeap();

// // Extract the maximum value
// Console.WriteLine("\nExtracting maximum values:");
// while (!maxHeap.IsEmpty())
// {
//     Console.WriteLine("Max: " + maxHeap.ExtractMax());
//     maxHeap.PrintHeap();
// }

// Create a new MinHeap
MinHeap minHeap = new MinHeap();

// Insert values into the heap
minHeap.InsertMin(7);
minHeap.InsertMin(3);
minHeap.InsertMin(6);
minHeap.InsertMin(5);
minHeap.InsertMin(1);

// Print the current state of the heap
Console.WriteLine("Heap after inserting values:");
minHeap.PrintHeap(); // Implement a PrintHeap() function in MinHeap to visualize

// Extract the minimum value
Console.WriteLine("\nExtracting minimum value from the heap...");
int minValue = minHeap.ExtractMin();
Console.WriteLine($"Extracted min: {minValue}");

// Print the heap after extraction
Console.WriteLine("\nHeap after extracting the minimum value:");
minHeap.PrintHeap();

// Extract another minimum value
Console.WriteLine("\nExtracting another minimum value...");
minValue = minHeap.ExtractMin();
Console.WriteLine($"Extracted min: {minValue}");

// Print the heap again
Console.WriteLine("\nHeap after extracting another minimum value:");
minHeap.PrintHeap();