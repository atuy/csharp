using System;
using static System.Console;

namespace ex_class
{
    class Program
    {

        class cat
        {
            public string name;
            public string color;

            public cat()
            {
                name = "";
                color = "";
            }
            public cat(string _namem, string _color)
            {
                name = _namem;
                color = _color;
            }
            public void meow()
            {
                WriteLine($"{name} : 야옹");
            }
        }
        static void Main(string[] args)
        {
            cat kitty = new cat();
            kitty.name = "키티";
            kitty.color = "하양";
            kitty.meow();
            WriteLine($"{kitty.name} : {kitty.color}");
            WriteLine();

            cat nero = new cat();
            nero.name = "네로";
            nero.color = "검정";
            nero.meow();
            WriteLine($"{nero.name} : {nero.color}");
            WriteLine();

            cat nabi = new cat("나비", "갈색");
            nabi.meow();
            WriteLine($"{nabi.name} : {nabi.color}");
            WriteLine();

        }
    }
}
