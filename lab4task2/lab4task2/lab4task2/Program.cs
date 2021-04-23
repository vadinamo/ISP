using System;
using System.Runtime.InteropServices;

namespace lab4task2
{
    class Program
    {
        [DllImport(Dll1.dll)]
        public static extern int Module(int number);
        [DllImport(Dll1.dll)]
        public static extern double Factorial(double number);
        [DllImport(Dll1.dll)]
        public static extern double Sin(double number);
        [DllImport(Dll1.dll)]
        public static extern double Cos(double number);
        [DllImport(Dll1.dll)]
        public static extern double Tan(double number);
        [DllImport(Dll1.dll)]
        public static extern double Cot(double number);
        [DllImport(Dll1.dll)]
        public static extern double Pow(double number, int power);
        [DllImport(Dll1.dll)]
        public static extern int Addition(int number1, int number2);
        [DllImport(Dll1.dll)]
        public static extern int Difference(int number1, int number2);
        [DllImport(Dll1.dll)]
        public static extern int Multiplication(int number1, int number2);
        [DllImport(Dll1.dll)]
        public static extern int Devision(int number1, int number2);
        static void Main(string[] args)
        {
            Console.WriteLine($"|-10| = {Module(-10)}");
            Console.WriteLine($"!10 = {Factorial(10)}");
            Console.WriteLine($"sin(4) = {Sin(4)}");
            Console.WriteLine($"cos(4) = {Cos(4)}");
            Console.WriteLine($"tg(4) = {Tan(4)}");
            Console.WriteLine($"ctg(4) = {Cot(4)}");
            Console.WriteLine($"2^8 = {Pow(2, 8)}");
            Console.WriteLine($"134 + 221 = {Addition(134, 221)}");
            Console.WriteLine($"134 - 221 = {Difference(134, 221)}");
            Console.WriteLine($"134 * 221 = {Multiplication(134, 221)}");
            Console.WriteLine($"7212 / 4 = {Devision(7212, 4)}");
        }
    }
}
