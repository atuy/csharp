using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace ex_simple_LINQ
{
    class Profile
    {
        public string Name { set; get; }
        public int Heught { get; set; }

    }
    class Product
    {
        public string Title { set; get; }
        public string Star { set; get; }
    }
    class ex_Class
    {
        public string Name { set; get; }
        public int[] Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numarr = new int[10];
            Random random = new Random();
            
            for(int i=0; i<10; i++)
            { 
                numarr[i] = random.Next(0,100);
                Write($"{numarr[i]} ");
            }
            WriteLine();

            var result = from n in numarr
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach(int i in result)
            {
                Write($"짝수 : {i} ");
            }
            WriteLine();
            WriteLine();
            WriteLine();
            Profile[] arr = 
            {
                new Profile() { Name = "정우성", Heught = 186 },
                new Profile() { Name = "김태희", Heught = 158 },
                new Profile() { Name = "고현정", Heught = 172 },
                new Profile() { Name = "이문세", Heught = 178 },
                new Profile() { Name = "하하", Heught = 171 }
            };
            Product[] arr_1 =
            {
                new Product(){ Title = "비트", Star="정우성"},
                new Product(){ Title = "CF 다수", Star="김태희"},
                new Product(){ Title = "아이리스", Star="김태희"},
                new Product(){ Title = "모래시계", Star="고현정"},
                new Product(){ Title = "Solo 예찬", Star="이문세"}
            };
            var profiles = from output in arr
                           where output.Heught < 175
                           orderby output.Heught
                           select new
                           {
                               Name = output.Name,
                               Inch = output.Heught * 0.393
                           };

            foreach(var output in profiles)
            {
                WriteLine($"{output.Name}, {output.Inch}");
            }
            WriteLine();
            WriteLine();
            var listprofile = from output in arr
                              orderby output.Heught
                              group output by output.Heught < 175 into g
                              select new { Groupkey = g.Key, profiles = g };

            foreach(var group in listprofile)
            {
                Write($"-175Cm 미만 ?: {group.Groupkey} ");
                WriteLine();
                foreach (var i in group.profiles)
                {
                    WriteLine($" {i.Name}, {i.Heught}");
                }
            }
            WriteLine();
            WriteLine();

            var list = from profile in arr
                       join product in arr_1 on profile.Name equals product.Star
                       select new
                       {
                           Name = profile.Name,
                           Work = product.Title,
                           Height = profile.Heught
                       };
            WriteLine("------내부 조인 결과-----");
            foreach (var i in list)
            {
                WriteLine($"이름 : {i.Name}, 작품 : {i.Work}, 키 : {i.Height}");
            }
            WriteLine();
            WriteLine();

            list = from profile in arr
                   join product in arr_1 on profile.Name equals product.Star into ps
                   from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없다" })
                   select new
                   {
                       Name = profile.Name,
                       Work = product.Title,
                       Height = profile.Heught
                   };
            WriteLine();
            WriteLine("------외부 조인 결과-----");
            foreach (var i in list)
            {
                WriteLine($"이름 : {i.Name}, 작품 : {i.Work}, 키 : {i.Height}");
            }
            WriteLine();
            WriteLine();

            ex_Class[] arrclass =
            {
                new ex_Class(){ Name="1반", Score=new int[]{ 99,80,70,24} },
                new ex_Class(){ Name="2반", Score=new int[]{ 60,45,87,72} },
                new ex_Class(){ Name="3반", Score=new int[]{ 92,30,85,94} },
                new ex_Class(){ Name="4반", Score=new int[]{ 90,8,0,17} },
            };

            var classes = from c in arrclass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach (var c in classes)
                WriteLine($"낙제 : {c.Name},  ({c.Lowest})");

        }
    }
}
