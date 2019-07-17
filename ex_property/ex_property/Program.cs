using System;
using static System.Console;

namespace ex_property
{
    class Birthday
    {
        private string name;
        private DateTime birth;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birth).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthday birthday = new Birthday();
            birthday.Name = "찬명";
            birthday.Birth = new DateTime(1996, 2, 28);
            WriteLine($"Name = {birthday.Name}");
            WriteLine($"birthday = {birthday.Birth}");
            WriteLine($"birthday = {birthday.Birth.ToShortDateString()}");
            WriteLine($"age = {birthday.Age}");
        }
    }
}
