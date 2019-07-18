using System;
using System.Collections;
using static System.Console;

namespace ex_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            WriteLine("Array list");
            for(int i=0;i<5;i++)
            {
                list.Add(i);
            }

            foreach(object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            list.Insert(2, 2);
            foreach (object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();


            list.Add("abc");
            list.Add("def");

            for(int i=0;i<list.Count;i++)
            {
                Write($"{list[i]} ");
            }
            WriteLine();
            WriteLine();
            WriteLine();

            WriteLine("queue");
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            que.Enqueue(6);

            while(que.Count>0)
            {
                Write($"{que.Dequeue()} ");
            }
            WriteLine();
            WriteLine();
            WriteLine();

            WriteLine("stack");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count>0)
            {
                Write(stack.Pop());
            }
            WriteLine();
            WriteLine();
            WriteLine();

            WriteLine("Hashtable");
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);


        }
    }
}
