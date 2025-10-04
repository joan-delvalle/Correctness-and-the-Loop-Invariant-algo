using System;
using System.Linq;

class Solution
{
    public static void insertionSort(int[] A)
    {
        int n = A.Length;

        for (int i = 1; i < n; i++)
        {
            int key = A[i];
            int j = i - 1;

            while (j >= 0 && A[j] > key)
            {
                A[j + 1] = A[j];
                j--;
            }

            A[j + 1] = key;
        }

        Console.WriteLine(string.Join(" ", A));
    }

    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar);
    }
}
