using System;
using System.Collections;
using static System.Console;

namespace ex_indexer
{
    class My
    {
        private int[] arr;

        public My()
        {
            arr = new int[5];
        }
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                if(index >= arr.Length)
                {
                    Array.Resize<int>(ref arr, index + 1);
                    WriteLine($"Array resized : {arr.Length}");                    
                }
                arr[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            My list = new My();
            for(int i=0;i<5;i++)
            {
                list[i] = i;
            }
            for (int i = 0; i < list.Length; i++)
            {
                WriteLine(list[i]);
            }
        }
    }
}
