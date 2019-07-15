using System;
using static System.Console;
namespace structure
{
    struct point
    {
        public int x;
        public int y;
        public int z;

        public point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return string.Format($"{x} ,  {y} , {z}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            point a;
            a.x = 10;
            a.y = 20;
            a.z = 30;

            WriteLine(a.ToString());

            point b = new point(100, 200, 300);
            point c = b;
            c.z = 400;

            WriteLine(b.ToString());
            WriteLine(c.ToString());
        }
    }
}
