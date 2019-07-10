using System;
using static System.Console;

namespace method
{
    class product
    {
        private int price = 100;
        public ref int getprice()
        {
            return ref price;
        }
        public void printprice()
        {
            WriteLine($"price = {price}");
        }
    }
    class Program
    {
        public static void swap(int x, int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
        }
        public static void refswap(ref int x, ref int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
        }
        public static void div(int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a % b;
        }

        public static int Sum(params int[] a)
        {
            int sum = 0;
            foreach(int num in a)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            WriteLine($" main a = {a} , b = {b}");
            swap(a, b);
            WriteLine($"call swap a = {a} , b = {b}");
            refswap(ref a, ref b);
            WriteLine($"call refswap a = {a} , b = {b}");
            WriteLine();
            WriteLine();

            int x = 40;
            int y = 6;
            div(x, y, out int re_1, out int re_2);
            WriteLine($"x = {x}, y = {y},result = {re_1} , {re_2}");
            WriteLine();
            WriteLine();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            WriteLine($"모든 arr의 합은 = {Sum(arr)}");

            WriteLine();
            WriteLine();
            product carrot = new product();
            ref int ref_local_price = ref carrot.getprice();
            int normal_local_price = carrot.getprice();
            carrot.printprice();
            WriteLine($"ref local price = {ref_local_price}"); ;
            WriteLine($"normal local price = {normal_local_price}"); 

            ref_local_price = 200;
            carrot.printprice();
            WriteLine($"ref local price = {ref_local_price}"); ;
            WriteLine($"normal local price = {normal_local_price}"); ;
        }
    }
}
