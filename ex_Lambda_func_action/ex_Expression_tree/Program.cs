﻿using System;
using static System.Console;
using System.Linq.Expressions;
namespace ex_Expression_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2);

            Expression param1 = Expression.Parameter(typeof(int));
            Expression param2 = Expression.Parameter(typeof(int));

            Expression rightExp = Expression.Subtract(param1, param2);

            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> expression = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>
                (exp, new ParameterExpression[]
                {
                    (ParameterExpression)param1, (ParameterExpression)param2
                });

            Func<int, int, int> func = expression.Compile();

            WriteLine($"1*2+(7-8) = {func(7, 8)}");

            WriteLine();
            WriteLine("---------------------------------------------------------------");
            WriteLine();

            Expression<Func<int, int, int>> expression1 = (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func1 = expression1.Compile();
            WriteLine($"1*2+(7-8) = {func1(7, 8)}");
        }
    }
}
