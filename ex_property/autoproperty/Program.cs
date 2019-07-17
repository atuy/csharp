using System;
using static System.Console;

namespace autoproperty
{
    class Birth
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Birth birthday = new Birth();
            
            WriteLine($"Name = {birthday.Name}");
            WriteLine($"birthday = {birthday.Birthday}");
            WriteLine($"birthday = {birthday.Birthday.ToShortDateString()}");
            WriteLine($"age = {birthday.Age}");

            birthday.Name = "찬명";
            birthday.Birthday = new DateTime(1996, 2, 28);
            WriteLine($"Name = {birthday.Name}");
            WriteLine($"birthday = {birthday.Birthday}");
            WriteLine($"birthday = {birthday.Birthday.ToShortDateString()}");
            WriteLine($"age = {birthday.Age}");
        }
    }
}
