using System;
using System.IO;
using static System.Console;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter input = new StreamWriter(new FileStream("test.txt", FileMode.Create));

            input.WriteLine(int.MaxValue);
            input.WriteLine("good morning");
            input.WriteLine(uint.MaxValue);
            input.WriteLine("안녕하세요");
            input.WriteLine(double.MinValue);

            input.Close();

            StreamReader output = new StreamReader(new FileStream("test.txt", FileMode.Open));

            WriteLine($"File Size : {output.BaseStream.Length} byte");

            while (output.EndOfStream == false)
            {
                WriteLine(output.ReadLine());
            }

            output.Close();
        }
    }
}
