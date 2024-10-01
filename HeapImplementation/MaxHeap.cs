public class MaxHeap{

    public List<int> heap = new List<int>();

    //parent node
    private int Parent(int i) => (i - 1)/2;

    //left node 
    private int LeftChild(int i) => 2 * i + 1;

    //right node
    private int RightChild(int i) => 2 * i + 2;

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

    // Print the elements in the heap (for debugging purposes)
    public void PrintHeap()
    {
        Console.WriteLine(string.Join(", ", heap));
    }
}