using System;
using System.IO;
using static System.Console;
namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            WriteLine("Original date: 0x{0:X16}", someValue );

            Stream output = new FileStream("test.dat", FileMode.Create);
            byte[] wbytes = BitConverter.GetBytes(someValue);

            Write("{0,-13} : ", "Byte array");

            foreach(byte i in wbytes)
            {
                Write("{0:x2} ", i);
            }
            WriteLine();

            output.Write(wbytes, 0, wbytes.Length);
            output.Close();

            Stream input = new FileStream("test.dat", FileMode.Open);
            byte[] rbyte = new byte[8];

            int n = 0;
            while( input .Position <input.Length)
            {
                rbyte[n++] = (byte)input.ReadByte();
            }

            long read = BitConverter.ToInt64(rbyte, 0);
            WriteLine("{0,-13}  : 0x{1:X16} ", "read date", read);
            input.Close();
        }
    }
}
