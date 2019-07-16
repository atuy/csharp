using System;
using static System.Console;
using System.IO;

namespace ex_interface
{
    interface ILogger
    {
        void WriteLog(string messge);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string messge)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()} , {messge}");
        }
    }
    class Filelogger : ILogger
    {
        private StreamWriter writer;

        public Filelogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string messge)
        {
            writer.WriteLine($"{DateTime.Now.ToShortTimeString()} , {messge}");
        }
    }

    class monitor
    {
        private ILogger logger;
        public monitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while(true)
            {
                Write("온도를 입력해 주세요 :");
                string temper = ReadLine();
                if (temper =="")
                {
                    break;
                }
                logger.WriteLog("현재온도 : " + temper);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            monitor a = new monitor(new Filelogger(@"C:\Users\Home\source\repos\atuy\csharp\interface\interface\mylog.txt")); //\을 표현 할려면 \\으로 표현해야 하지만 @을 붙이면 한번만으로 표현할 수 있다
            a.start();
        }
    }
}
