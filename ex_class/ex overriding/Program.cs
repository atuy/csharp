using System;
using static System.Console;
namespace ex_overriding
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initalize()
            {
                WriteLine("Armored");
            }

        }
        class Ironman : ArmorSuite
        {
            public override void Initalize()
            {
                base.Initalize();
                WriteLine("repulsor rays armor");
            }
          
        }

        class Warmachine : ArmorSuite
        {
            public override void Initalize()
            {
                base.Initalize();
                WriteLine("double barrel cannons");
                WriteLine("micro rocket");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("creating armorsuite");

            ArmorSuite a = new ArmorSuite();
            a.Initalize();

            WriteLine("\nCreating ironman");
            Ironman b = new Ironman();
            b.Initalize();

            WriteLine("\nCreating warmachine");
            Warmachine c = new Warmachine();
            c.Initalize();
        }
    }
}
