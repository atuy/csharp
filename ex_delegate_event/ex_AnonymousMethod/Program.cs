using System;
using static System.Console;

namespace ex_AnonymousMethod
{
    delegate int Compare(int a, int b);
    class Program
    {
        static void Bubblesort(int[] arr, Compare compare)
        {
            int i, j = 0;
            int tmp;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = 0; j < arr.Length - (i + 1); j++)
                {
                    if (compare(arr[j], arr[j + 1]) > 0)
                    {
                        tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 5, 4, 10, 6, 9 };
            WriteLine("Sorting...");

            Bubblesort(arr, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;


            });
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{arr[i]} ");
            }
            WriteLine();

            int[] arr2 = { 7, 2, 8, 10, 11, 3 };
            WriteLine("Sorting...");
            Bubblesort(arr2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;


            });

            for (int i = 0; i < arr2.Length; i++)
            {
                Write($"{arr2[i]} ");
            }
        }
    }
}
