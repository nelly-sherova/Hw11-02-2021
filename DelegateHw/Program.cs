using System;
using System.Text.RegularExpressions;

namespace DelegateHw
{
    class Program
    {
        private static T Sum<T>(T num1, T num2)
        {
            return (dynamic)num1 + (dynamic)num2;
        }
        private static T Minus<T>(T num1, T num2)
        {
            return (dynamic)num1 - (dynamic)num2;
        }
        private static T Product<T>(T num1, T num2)
        {
            return (dynamic)num1 * (dynamic)num2;
        }
        private static T Division<T>(T num1, T num2)
        {
             if((dynamic)num2 == 0)
                throw new DivideByZeroException();
            else
                return (dynamic)num1 / (dynamic)num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
