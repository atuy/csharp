using System;
using static System.Console;

namespace ex_BasicAttribute
{
    class Sample
    {
        [Obsolete("Old메서드는 폐기되었습니다")]
        public void Old()
        {
            WriteLine("Old()");
        }
        public void New()
        {
            WriteLine("New()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.Old();
            sample.New();
        }
    }
}
