using System;
using static System.Console;

namespace ex_try_catch_finally
{
    class Program
    {
        static int Div(int divisor, int divided)
        {
            try
            {
                WriteLine("div() 시작");
                return divisor / divided;
            }
            catch(Exception e)
            {
                WriteLine("div() 예외발생");
                throw e;
            }
            finally
            {
                WriteLine("div() 끝");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Write("수를 입력하시오 : ");
                int divisor = int.Parse(ReadLine());
                Write("나눌 수를 입력해주세요 : ");
                int divided = int.Parse(ReadLine());

                WriteLine($"{divisor} / {divided} = {Div(divisor, divided)}");
            }
            catch(FormatException e)
            {
                WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                WriteLine("에러 : " + e.Message);
            }
            finally
            {
                WriteLine("프로그램을 종료합니다");
            }
        }
    }
}
