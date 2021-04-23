#include "pch.h"
#include "MathLibrary.h"

double __cdecl Factorial(double number)
{
    double result = 1;

    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
}

double __cdecl  Pow(double number, int power)
{
    double result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }

    return result;
}

int __stdcall  Module(int number)
{
	if (number > 0) return number;
	else return (0 - number);
}

double __cdecl  Sin(double number)
{
    double y = number;
    double s = -1;

    for (int i = 3; i <= 100; i += 2)
    {
        y += s * (Pow(number, i) / Factorial(i));
        s *= -1;
    }

    return y;
}

double __cdecl  Cos(double number)
{
    double result = 1;
    double s = -1;
    for (int i = 2; i <= 100; i += 2) {
        result += s * (Pow(number, i) / Factorial(i));
        s *= -1;
    }
    return result;
}

double __cdecl  Tan(double number)
{
    return (Sin(number) / Cos(number));
}

double __cdecl  Cot(double number)
{
    return (Cos(number) / Sin(number));
}

int __stdcall  Addition(int number1, int number2)
{
    return (number1 + number2);
}

int __stdcall  Difference(int number1, int number2)
{
    return (number1 - number2);
}

int __stdcall  Multiplication(int number1, int number2)
{
    return (number1 * number2);
}

int __stdcall  Devision(int number1, int number2)
{
    return (number1 / number2);
}
