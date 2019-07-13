using System;
using static System.Console;

namespace type_casting
{
    class Program
    {
        class mammal
        {
            public void Nurse()
            {
                WriteLine("Nurse()");
            }
        }
        class Dog : mammal
        {
            public void Bark()
            {
                WriteLine("Bark()");
            }
        }
        class Cat : mammal
        {
            public void meow()
            {
                WriteLine("meow()");
            }
        }
        static void Main(string[] args)
        {
            mammal mal1 = new Dog();
            Dog dog;
            if (mal1 is Dog)
            {
                dog = (Dog)mal1;
                dog.Bark();
            }

            mammal mal2 = new Cat();

            Cat cat = mal2 as Cat;
            if (cat != null)
            {
                cat.meow();
            }

            Cat cat2 = mal1 as Cat;
            if (cat2 != null)
            {
                cat2.meow();
            }
            else
            {
                WriteLine("cat2 is not a cat");
            }
        }
    }
}
