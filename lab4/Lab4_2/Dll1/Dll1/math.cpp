#include "pch.h"
#include "math.h"

int __stdcall Module(int number)
{
	if (number >= 0)
	{
		return number;
	}
	else
	{
		return 0 - number;
	}
}

int __stdcall Max(int number1, int number2)
{
	if (number1 > number2)
	{
		return number1;
	}
	else
	{
		return number2;
	}
}

int __stdcall Min(int number1, int number2)
{
	if (number1 < number2)
	{
		return number1;
	}
	else
	{
		return number2;
	}
}

int __stdcall Pow(int number, int power)
{
	if (power == 1)
	{
		return number;
	}
	else
	{
		return (number * Pow(number, power--));
	}
}

double __cdecl Sin(double number)
{
	double num1 = number, num2 = 1, sin = number;

	for (int i = 0; i < 10; i++)
	{
		num1 *= -1;
		num1 *= number;
		num1 *= number;
		num1 /= ++num2;
		num1 /= ++num2;
		sin += num1;
	}

	return sin;
}

double __cdecl Cos(double number)
{
	double num1 = 1, num2 = 0, cos = 1;

	for (int i = 0; i < 10; i++)
	{
		num1 *= -1;
		num1 *= number;
		num1 *= number;
		num1 /= ++num2;
		num1 /= ++num2;
		cos += num1;
	}

	return cos;
}

double __cdecl Tg(double number)
{
	if (Cos(number) != 0)
	{
		return Sin(number) / Cos(number);
	}
	else
	{
		return NULL;
	}
}

double __cdecl Ctg(double number)
{
	if (Sin(number) != 0)
	{
		return Cos(number) / Sin(number);
	}
	else
	{
		return NULL;
	}
}