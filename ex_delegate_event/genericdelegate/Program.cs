using System;
using static System.Console;

namespace ex_genericdelegate
{
    delegate int compare<T>(T a, T b);

    class Program
    {
        static int Ascend<T>(T a, T b) where T :IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int Descend<T>(T a, T b) where T :IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }
        static void Bubblesort<T>(T[] arr, compare<T> compare)
        {
            int i, j = 0;
            T tmp;
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

            WriteLine("Sorting");
            Bubblesort(arr, new compare<int>(Ascend));

            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{arr[i]} ");
            }

            string[] arr2 = { "abc", "def", "ghi", "jkl", "mno" };
            WriteLine("\nSorting");
            Bubblesort(arr2, new compare<string >(Descend));

            for (int i = 0; i < arr2.Length; i++)
            {
                Write($"{arr2[i]} ");
            }
        }
    }
}

