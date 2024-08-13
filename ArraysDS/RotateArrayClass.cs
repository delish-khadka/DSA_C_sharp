using System;

namespace ArraysDS;

public class RotateArrayClass
{
    public int[] RotateArrayToRight(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n; // In case k > n
        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
        return arr;
    }

    public int[] RotateArrayToLeft(int[] arr, int k){
        int n = arr.Length;
        k = k % n;
        //full rotation
        Reverse(arr, 0, n - 1);
        //rotation of k elements
        Reverse(arr, k - 1, n - 1);
        //rotation of elements except k elements
        Reverse(arr, 0, n - k - 1 );
        //alternatively --
        // Reverse the first k elements
        // Reverse(arr, 0, k - 1);

        // // Reverse the remaining elements
        // Reverse(arr, k, n - 1);

        // // Reverse the entire array
        // Reverse(arr, 0, n - 1);

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
