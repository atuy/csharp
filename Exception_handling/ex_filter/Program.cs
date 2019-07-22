using System;
using static System.Console;

namespace ex_filter
{
    class ExceptionFiltering : Exception
    {
        public int ErrorNo
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("0 ~ 10 까지 수를 입력하시오 : ");
                try
                {
                    int num = int.Parse(ReadLine());

                    if (num < 0 || num > 10)
                    {
                        throw new ExceptionFiltering()
                        {
                            ErrorNo = num
                        };

                    }
                    else
                    {
                        WriteLine($"output : {num}");
                    }
                }
                catch (ExceptionFiltering e) when (e.ErrorNo < 0)
                {
                    WriteLine("Negative input is not allowed");
                }
                catch (ExceptionFiltering e) when (e.ErrorNo > 10)
                {
                    WriteLine("too big num");
                }
            }
        }
    }
}
