using System;
using static System.Console;
using System.Globalization;
namespace ex_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Good mornimg";

            WriteLine(a);
            WriteLine();

            WriteLine("indexof 'good' : {0}", a.IndexOf("Good"));
            WriteLine("indexof 'o' : {0}", a.IndexOf("o"));
            WriteLine();

            WriteLine("startwith 'Good' = {0}", a.StartsWith("Good"));
            WriteLine("startwith 'Mornimg' = {0}", a.StartsWith("mornimg"));
            WriteLine();

            WriteLine("Contains 'evening' = {0}", a.Contains("evening"));
            WriteLine("Contains 'morning' = {0}", a.Contains("morning"));
            WriteLine();

            WriteLine("replaced mornimg with evenimg = {0}", a.Replace("mornimg", "evenimg"));
            WriteLine();

            WriteLine("tolower() : {0}", "ABC".ToLower());
            WriteLine("toupwer() : {0}", "abc".ToUpper());
            WriteLine("insert() : {0}", "happy friday".Insert(5,"sunny"));
            WriteLine("remove() : {0}", "i don't love you".Remove(2,6));
            WriteLine("trim() : {0}", " no spaces ".Trim());
            WriteLine();

            //format
            string result = string.Format("{0}DEF", "ABC");
            WriteLine(result);

            result = string.Format("{0,-10}DEF", "ABC");
            WriteLine(result);

            result = string.Format("{0,10}DEF", "ABC");
            WriteLine(result);
            WriteLine();

            string str = "{0,-20},{1,15},{2,30}";
            WriteLine(str, "publisher", "author", "title");
            WriteLine(str, "marvel", "stan lee", "iron man");
            WriteLine(str, "hanbit", "park", "c# 7.0 programming");
            WriteLine();

            WriteLine("10진수:{0:D}",123);
            WriteLine("10진수:{0:D5}",123);
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("숫자 자리수 : {0:n}", 123456789);
            WriteLine("숫자 자리수 : {0:n0}", 123456789);
            WriteLine();

            CultureInfo ko = new CultureInfo("ko-KR");
            DateTime dt = new DateTime(2019, 07, 03, 22, 15, 22);
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", ko));
            WriteLine(dt.ToString("yy-M-d h:m:s (ddd)", ko));
            WriteLine();
            WriteLine(DateTime.Now.ToLongDateString());
            WriteLine(DateTime.Now.ToLongTimeString());
            WriteLine(DateTime.Now.ToLocalTime());

        }
    }
}
