using System;
using static System.Console;
namespace ex_derivedInterface
{
    class Program
    {
        interface ILogger
        {
            void WriteLog(string message);
        }
        interface IFormat : ILogger
        {
            void WriteLog(string formnat, params Object[] args);
        }
        class ConsoleLogger : IFormat
        {
            public void WriteLog(string message)
            {
                WriteLine($"{DateTime.Now.ToLocalTime()} , {message}");
            }
            public void WriteLog(string formnat, params Object[] args)
            {
                String message = String.Format(formnat, args);
                WriteLine($"{DateTime.Now.ToLocalTime()} , {message}");
            }
        }

        static void Main(string[] args)
        {
            IFormat a = new ConsoleLogger();
            a.WriteLog("the world is flat");
            a.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }

    }
}
