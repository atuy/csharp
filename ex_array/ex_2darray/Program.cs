using System;
using static System.Console;

namespace ex_2darray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1);j++)
                {
                    Write($"[{i}, {j}] : {arr[i,j]} ");
                }
                WriteLine();
            }

            int[,,] arr_3 = new int[,,] {
                {{ 1, 2 }, { 3, 4 }, { 5,6} }, {{1,4},{2,5},{ 3,6} },{{6,5 } ,{4,3},{2,1} },{{ 6,3},{5,2},{ 4,1} }
            };
            for(int i=0;i<arr_3.GetLength(0);i++)
            {
                for(int j=0;j<arr_3.GetLength(1);j++)
                {
                    Write("{ ");
                    for(int k=0;k<arr_3.GetLength(2);k++)
                    {
                        Write($"{arr_3[i, j, k]} ");
                    }
                    Write(" }");
                }
                WriteLine();
            }



        }
    }
}
