using System;

namespace lab7
{
    class Program
    {
        static void Compare(Rational frac1, Rational frac2)
        {
            if(frac1 > frac2) Console.WriteLine($"{frac1} > {frac2}");
            else if(frac1 < frac2) Console.WriteLine($"{frac1} < {frac2}");
            else  Console.WriteLine($"{frac1} = {frac2}");
        }
        
        static void Main()
        {
            Rational fraction1 = new Rational(5, 1);
            Rational fraction2 = new Rational(6, 8);
            Console.WriteLine($"{fraction1} + {fraction2} = {fraction1 + fraction2} ({(fraction1 + fraction2).ToFloat()})");
            Compare(fraction1, fraction2);
            Console.WriteLine();
            
            fraction1 = new Rational(-7, 49);
            fraction2 = new Rational(100, 50);
            Console.WriteLine($"{fraction1} - {fraction2} = {fraction1 - fraction2} ({(fraction1 - fraction2).ToFloat()})");
            Compare(fraction1, fraction2);
            Console.WriteLine();

            fraction1 = new Rational(2, 3);
            fraction2 = new Rational(-4, 2);
            Console.WriteLine($"{fraction1} * {fraction2} = {fraction1 * fraction2} ({(fraction1 * fraction2).ToFloat()})");
            Compare(fraction1, fraction2);
            Console.WriteLine();

            fraction1 = new Rational(7, 6);
            fraction2 = new Rational(7, 6);
            Console.WriteLine($"{fraction1} / {fraction2} = {fraction1 / fraction2} ({(fraction1 / fraction2).ToFloat()})");
            Compare(fraction1, fraction2);
            Console.WriteLine();
        }
    }
}