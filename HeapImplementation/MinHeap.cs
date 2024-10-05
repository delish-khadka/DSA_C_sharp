using System;

namespace HeapImplementation;

public class MinHeap
{
    private List<int> Heap = new List<int>();
    private int Parent(int i) => (i-1)/2;
    private int LeftChild(int i) => 2*i+1;
    private int RightChild(int i) => 2*i+2;

    public void InsertMin(int i){
        Heap.Add(i);
        int index = Heap.Count - 1;

        while(index > 0 && Heap[Parent(index)] > Heap[index]){
            Swap(index, Parent(index));
            index = Parent(index);
        }
    }
    private void Swap(int i, int j){
        int temp = Heap[i];
        Heap[i] = Heap[j];
        Heap[j] = temp;
    }
}
