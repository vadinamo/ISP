#pragma once

#ifdef MATH_EXPORTS
#define MATH_API __declspec(dllexport)
#else
#define MATH_API __declspec(dllimport)
#endif

extern "C" MATH_API int __stdcall Module(int number);
extern "C" MATH_API int __stdcall Max(int number1, int number2);
extern "C" MATH_API int __stdcall Min(int number1, int number2);
extern "C" MATH_API int __stdcall Pow(int number, int power);
extern "C" MATH_API double __cdecl Sin(double number);
extern "C" MATH_API double __cdecl Cos(double number);
extern "C" MATH_API double __cdecl Tg(double number);
extern "C" MATH_API double __cdecl Ctg(double number);