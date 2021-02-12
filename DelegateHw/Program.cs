using System;
using System.Text.RegularExpressions;

namespace DelegateHw
{
    class Program
    {
        delegate T Operation<T> (T num1, T num2);
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
            Operation<double> operations;
            Console.Write("number_1 = "); double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("operation: "); char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("number_2 = "); double.TryParse(Console.ReadLine(), out double num2);
            switch (oper)
            {
                case '+':
                    operations = Sum;
                    Console.WriteLine($"{num1} + {num2} = {operations?.Invoke(num1, num2)}");
                break;
                case '-':
                    operations = Minus;
                    Console.WriteLine($"{num1} - {num2} = {operations?.Invoke(num1, num2)}");
                break;
                case '*':
                    operations = Product;
                    Console.WriteLine($"{num1} * {num2} = {operations?.Invoke(num1, num2)}");
                break;
                case '/':
                    operations = Division;
                    Console.WriteLine($"{num1} / {num2} = {operations?.Invoke(num1, num2)}");
                break;
                default:
                    Console.WriteLine("Неправильный символ!");
                break;
            }
        }
    }
}
