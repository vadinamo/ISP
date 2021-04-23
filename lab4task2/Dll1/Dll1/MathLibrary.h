#pragma once

#ifdef MATH_EXPORTS
#define MATH_API __declspec(dllexport)
#else
#define MATH_API __declspec(dllimport)
#endif

extern "C" MATH_API int __stdcall  Module(int number);
extern "C" MATH_API double __cdecl  Factorial(double number);
extern "C" MATH_API double __cdecl  Sin(double number);
extern "C" MATH_API double __cdecl  Cos(double number);
extern "C" MATH_API double __cdecl  Tan(double number);
extern "C" MATH_API double __cdecl  Cot(double number);
extern "C" MATH_API double __cdecl  Pow(double number, int power);
extern "C" MATH_API int __stdcall  Addition(int number1, int number2);
extern "C" MATH_API int __stdcall  Difference(int number1, int number2);
extern "C" MATH_API int __stdcall  Multiplication(int number1, int number2);
extern "C" MATH_API int __stdcall  Devision(int number1, int number2);