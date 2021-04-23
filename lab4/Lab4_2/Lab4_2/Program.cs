using System;
using System.Runtime.InteropServices;

namespace Lab4_2
{
    class Program
    {
        [DllImport("dllmath.dll")]
        public static extern int Module(int num);
        [DllImport("dllmath.dll")]
        public static extern int Max(int num1, int num2);
        [DllImport("dllmath.dll")]
        public static extern int Min(int num1, int num2);
        [DllImport("dllmath.dll")]
        public static extern int Pow(int num, int level);
        [DllImport("dllmath.dll")]
        public static extern double Sin(double x);
        [DllImport("dllmath.dll")]
        public static extern double Cos(double x);
        [DllImport("dllmath.dll")]
        public static extern double Tg(double x);
        [DllImport("dllmath.dll")]
        public static extern double Ctg(double x);

        static int IntCheck()   //проверка ввода int
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Ошибка!");
            }
            return a;
        }

        static double DoubleCheck()   //проверка ввода int
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Ошибка!");
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("a(int)=");
            int a = IntCheck();
            Console.Write("b(int)=");
            int b = IntCheck();

            Console.WriteLine($"\n{a}^{b} = {Pow(a, b)}");
            Console.WriteLine($"Module ({a}): {Module(a)}");
            Console.WriteLine($"Module ({b}): {Module(b)}");
            Console.WriteLine($"{Max(a, b)} > {Min(a, b)}");

            Console.Write("\n\nc(double)=");
            double c = DoubleCheck();

            Console.WriteLine($"\nsin({c}) = {Sin(c)}");
            Console.WriteLine($"cos({c}) = {Cos(c)}");
            Console.WriteLine($"tg({c}) = {Tg(c)}");
            Console.WriteLine($"ctg({c}) = {Ctg(c)}");

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}