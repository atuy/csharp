using System;
using static System.Console;

namespace ex_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                Write("수를 입력하시오 : ");
                arr[i] = int.Parse(ReadLine());
            }
            WriteLine($"배열의 길이 {arr.Length}");
            WriteLine($"배열의 차원 {arr.Rank}");

            WriteLine("입력된 배열 : ");
            foreach(int num in arr)
            {
                Write($"{num} ");
            }
            WriteLine();

            Write("배열 인덱스 반환 : ");
            int input = int.Parse(ReadLine());
            WriteLine(Array.IndexOf(arr, input));

            Array.Sort(arr);
            WriteLine("정렬된 배열 : ");
            foreach (int num in arr)
            {
                Write($"{num} ");
            }
            WriteLine();

            Write("이진탐색으로 찾을 번호 : ");
            input = int.Parse(ReadLine());
            WriteLine(Array.BinarySearch(arr, input));

            int origin_length = arr.Length;
            Write("배열 사이즈 변경 : ");
            int size = int.Parse(ReadLine());
            Array.Resize<int>(ref arr, size);

            WriteLine("입력된 배열 : ");
            foreach (int num in arr)
            {
                Write($"{num} ");
            }
            WriteLine();

            for (int i = origin_length; i < arr.Length; i++)
            {
                Write("수를 입력하시오 : ");
                arr[i] = int.Parse(ReadLine());
            }
            WriteLine();

            WriteLine("입력된 배열 : ");
            foreach (int num in arr)
            {
                Write($"{num} ");
            }
            WriteLine();

            Array.Clear(arr, 4, 4);     //1,2,3,4,0,0,0,0,9
            WriteLine("삭제한 배열 : ");
            foreach (int num in arr)
            {
                Write($"{num} ");
            }
            WriteLine();

        }
    }
}
