using System;
using static System.Console;

namespace gereric_class
{
    class Sample<T>
    {
        private T[] arr;

        public Sample()
        {
            arr = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                if(index>=arr.Length)
                {
                    Array.Resize<T>(ref arr, index + 1);
                    WriteLine($"사이즈 재설정 : {arr.Length}");
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
            Sample<string> str_list = new Sample<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for(int i=0;i<str_list.Length;i++)
            {
                WriteLine(str_list[i]);
            }

            WriteLine();

            Sample<int> int_list = new Sample<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;
            int_list[4] = 5;

            for (int i = 0; i < int_list.Length; i++)
            {
                WriteLine(int_list[i]);
            }

        }
    }
}
