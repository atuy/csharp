using System;
using static System.Console;

namespace ex_usingCallback
{
    delegate int compare(int a, int b);

    class Program
    {
        static int Ascend(int a, int b)
        {
            if(a > b)
            {
                return 1;
            }
            else if(a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int Descend(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        static void Bubblesort(int[] arr, compare compare)
        {
            int i, j, tmp = 0;
            for(i=0;i<arr.Length-1;i++)
            {
                for(j=0;j<arr.Length-(i+1);j++)
                {
                    if( compare (arr[j], arr[j+1])>0)
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

            WriteLine("Sorting");
            Bubblesort(arr, new compare(Ascend));

            for(int i=0;i<arr.Length;i++)
            {
                Write($"{arr[i]} ");
            }

            int[] arr2 = { 7, 2, 8, 9, 10, 11 };
            WriteLine("\nSorting");
            Bubblesort(arr2, new compare(Descend));

            for (int i = 0; i < arr2.Length; i++)
            {
                Write($"{arr2[i]} ");
            }
        }
    }
}
