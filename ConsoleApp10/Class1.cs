using System;
using ConsoleApp10;

namespace App
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(10);
            arr.ShowArr();

            int less = arr.Less(5);
            Console.WriteLine($"Less than {less}");

            int greater = arr.Greater(10);
            Console.WriteLine($"Greater than {greater}");

            int equal = arr.EqualToValue(10);
            Console.WriteLine($"Equal to {equal}");

            int distr = arr.CountDistinct();
            Console.WriteLine($"Count District {distr}");


            arr.ShowEven();
            arr.ShowOdd();

        }
    }
}
