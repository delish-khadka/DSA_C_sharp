using System;

namespace ArraysDS;

public class RotateArrayClass
{
    public int[] RotateArray(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n; // In case k > n
        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
        return arr;
    }

private void Reverse(int[] arr, int start, int end)
{
    while (start < end)
    {
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}

}
