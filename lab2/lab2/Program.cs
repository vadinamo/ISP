/* 
 1.Дана строка, состоящая из строчных английских букв. Заменить в ней все буквы, стоящие после гласных, на следующие по алфавиту
   (z заменяется на a). +
 2.Получить текущее время и дату в двух разных форматах и вывести на экран количество нулей, единиц, …, девяток в их записи. +
 3.Рассчитать максимальную степень двойки, на которую делится произведение подряд идущих чисел от a до b (числа целые 64-битные
   без знака).
 */
using System;

namespace lab2
{
    class MainClass
    {
        public static void StringTask() //Задание на строки
        {
            string enteredString = "";
            bool check = false;
            while (!check)
            {
                check = true;
                Console.WriteLine("Enter your string:");
                enteredString = Console.ReadLine();

                for (int num = 0; num < enteredString.Length; num++) //проверка ввода строчных букв
                {
                    if (((char)enteredString[num]) < 97 || ((char)enteredString[num]) > 122)
                    {
                        check = false;
                        break;
                    }
                }
            }
            string stringCopy = enteredString;

            for (int num = 0; num < enteredString.Length - 1; num++) //Замена букв, стоящих после гласных
            {
                if (enteredString[num] == 'a' || enteredString[num] == 'e' || enteredString[num] == 'i' || enteredString[num] == 'o' || enteredString[num] == 'u' || enteredString[num] == 'y')
                {
                    if (num < enteredString.Length && enteredString[num + 1] == 'z')
                    {
                        stringCopy = stringCopy.Remove(num + 1, 1);
                        stringCopy = stringCopy.Insert(num + 1, "a");
                    }
                    else if (num < enteredString.Length)
                    {
                        stringCopy = stringCopy.Remove(num + 1, 1);
                        string replace = Convert.ToString((char)(enteredString[num + 1] + 1));
                        stringCopy = stringCopy.Insert(num + 1, replace);
                    }
                }
            }
            Console.WriteLine(stringCopy);
        }

        public static void NumberСounter(string date1, string date2)
        {
            for (int number = 0; number < 10; number++)
            {
                int count = 0;

                for (int num = 0; num < date1.Length; num++)
                {
                    if (date1[num] == (char)number + 48) count++;
                }

                for (int num = 0; num < date2.Length; num++)
                {
                    if (date2[num] == (char)number + 48) count++;
                }

                Console.WriteLine("Count of " + number + " : " + count);
            }
        }

        public static void DateTask() //Задание на дату и время
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            string dateFormat = date.ToLongDateString() + " " + date.ToShortTimeString();
            Console.WriteLine(dateFormat);
            NumberСounter(Convert.ToString(date), dateFormat);
        }

        public static ulong degreeCalculating(ulong number)
        {
            ulong degree = 0;
            while (number != 0)
            {
                number /= 2;
                degree += number;
            }
            return degree;
        }

        public static void NumberTask()
        {
            ulong lowerLimit, upperLimit;
            Console.Write("Lower limit = ");

            while (!ulong.TryParse(Console.ReadLine(), out lowerLimit))
            {
                Console.Write("Error!\nLowerimit = ");
            }
            char* arr = new char;
            Console.Write("Upper limit = ");

            while (!ulong.TryParse(Console.ReadLine(), out upperLimit) || upperLimit <= lowerLimit)
            {
                Console.Write("Error!\nUpper limit = ");
            }
            if (lowerLimit != 0) lowerLimit--;
            Console.Write("Max degree is " + (degreeCalculating(upperLimit) - degreeCalculating(lowerLimit)));
        }

        public static void Main()
        {
            DateTask();
            StringTask();
            NumberTask();
        }
    }
}