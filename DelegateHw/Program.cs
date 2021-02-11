using System;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
