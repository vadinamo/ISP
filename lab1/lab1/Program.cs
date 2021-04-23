using System;

namespace lab1//крестики-нолики
{
    class MainClass
    {
        static void Outp(char[,] GameField)//функция вывода поля
        {
            Console.WriteLine(" ———————————");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(GameField[i, j] + " | ");
                }
                Console.Write("\n ———————————\n");
            }
        }
        static bool WinCheck(char[,] GameField)//функция проверки выигрыша
        {
            int spaces = 0;
            for (int i = 0; i < 3; i++)//подсчет количества пробелов
            {
                for (int j = 0; j < 3; j++)
                {
                    if (GameField[i, j] == ' ') spaces++;
                }
            }
            if (GameField[0, 0] == GameField[0, 1] && GameField[0, 1] == GameField[0, 2] && GameField[0, 1] != ' ')
            {
                Console.WriteLine(GameField[0, 1] + " Выиграл!");
                return true;
            }
            else if (GameField[0, 0] == GameField[1, 0] && GameField[1, 0] == GameField[2, 0] && GameField[1, 0] != ' ')
            {
                Console.WriteLine(GameField[1, 0] + " Выиграл!");
                return true;
            }
            else if (GameField[2, 0] == GameField[2, 1] && GameField[2, 1] == GameField[2, 2] && GameField[2, 1] != ' ')
            {
                Console.WriteLine(GameField[2, 1] + " Выиграл!");
                return true;
            }
            else if (GameField[0, 2] == GameField[1, 2] && GameField[1, 2] == GameField[2, 2] && GameField[1, 2] != ' ')
            {
                Console.WriteLine(GameField[1, 2] + " Выиграл!");
                return true;
            }
            else if (GameField[0, 0] == GameField[1, 1] && GameField[1, 1] == GameField[2, 2] && GameField[1, 1] != ' ')
            {
                Console.WriteLine(GameField[1, 1] + " Выиграл!");
                return true;
            }
            else if (GameField[2, 0] == GameField[1, 1] && GameField[1, 1] == GameField[0, 2] && GameField[1, 1] != ' ')
            {
                Console.WriteLine(GameField[1, 1] + " Выиграл!");
                return true;
            }
            else if (GameField[1, 0] == GameField[1, 1] && GameField[1, 1] == GameField[1, 2] && GameField[1, 1] != ' ')
            {
                Console.WriteLine(GameField[1, 1] + " Выиграл!");
                return true;
            }
            else if (GameField[0, 1] == GameField[1, 1] && GameField[1, 1] == GameField[2, 1] && GameField[1, 1] != ' ')
            {
                Console.WriteLine(GameField[1, 1] + " Выиграл!");
                return true;
            }
            else if (spaces == 0)//если пробелов нет и нет выигрышных комбинаций, то выводится ничья
            {
                Console.WriteLine("Ничья!");
                return true;
            }
            else return false;
        }
        static void PlayerTurn(char[,] GameField, char PlayerSymbol)//функция для хода игрока
        {
            int pick = 0;
            while (pick == 0)
            {
                Console.WriteLine("Выберите свободную клетку");
                while (!int.TryParse(Console.ReadLine(), out pick))//проверка ввода
                {
                    Console.WriteLine("Ошибка!");
                }
                if (pick == 1 && GameField[0, 0] == ' ') GameField[0, 0] = PlayerSymbol;
                else if (pick == 2 && GameField[0, 1] == ' ') GameField[0, 1] = PlayerSymbol;
                else if (pick == 3 && GameField[0, 2] == ' ') GameField[0, 2] = PlayerSymbol;
                else if (pick == 4 && GameField[1, 0] == ' ') GameField[1, 0] = PlayerSymbol;
                else if (pick == 5 && GameField[1, 1] == ' ') GameField[1, 1] = PlayerSymbol;
                else if (pick == 6 && GameField[1, 2] == ' ') GameField[1, 2] = PlayerSymbol;
                else if (pick == 7 && GameField[2, 0] == ' ') GameField[2, 0] = PlayerSymbol;
                else if (pick == 8 && GameField[2, 1] == ' ') GameField[2, 1] = PlayerSymbol;
                else if (pick == 9 && GameField[2, 2] == ' ') GameField[2, 2] = PlayerSymbol;
                else pick = 0;
            }
        }
        static void BotTurn(char[,] GameField, char bot)//фунция хода компьютера
        {
            int pick;
            for (; ; )
            {
                Random rnd = new Random();//создание объекта для генерации чисел
                pick = rnd.Next(1, 9);
                if (pick == 1 && GameField[0, 0] == ' ')
                {
                    GameField[0, 0] = bot;
                    break;
                }
                else if (pick == 2 && GameField[0, 1] == ' ')
                {
                    GameField[0, 1] = bot;
                    break;
                }
                else if (pick == 3 && GameField[0, 2] == ' ')
                {
                    GameField[0, 2] = bot;
                    break;
                }
                else if (pick == 4 && GameField[1, 0] == ' ')
                {
                    GameField[1, 0] = bot;
                    break;
                }
                else if (pick == 5 && GameField[1, 1] == ' ')
                {
                    GameField[1, 1] = bot;
                    break;
                }
                else if (pick == 6 && GameField[1, 2] == ' ')
                {
                    GameField[1, 2] = bot;
                    break;
                }
                else if (pick == 7 && GameField[2, 0] == ' ')
                {
                    GameField[2, 0] = bot;
                    break;
                }
                else if (pick == 8 && GameField[2, 1] == ' ')
                {
                    GameField[2, 1] = bot;
                    break;
                }
                else if (pick == 9 && GameField[2, 2] == ' ')
                {
                    GameField[2, 2] = bot;
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Нумерация клеток поля:");
            int n = 1;
            Console.WriteLine(" ———————————");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(n + " | ");
                    n++;
                }
                Console.Write("\n ———————————\n");
            }
            string pick = " ";
            bool a = false;
            while (a == false)
            {
                Console.WriteLine("X/O?");
                pick = Console.ReadLine();
                if (pick == "X" || pick == "O") a = true;
            }
            Convert.ToChar(pick);
            char PlayerOneSymbol, PlayeTwoSymbol;
            if (pick == "X")
            {
                PlayerOneSymbol = 'X';
                PlayeTwoSymbol = 'O';
            }
            else
            {
                PlayerOneSymbol = 'O';
                PlayeTwoSymbol = 'X';
            }
            a = false;
            while (a == false)
            {
                Console.WriteLine("Режим игры?\n1.С ботом.\n2.Второй игрок.");
                pick = Console.ReadLine();
                if (pick == "1" || pick == "2") a = true;
            }
            char[,] GameField;
            GameField = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GameField[i, j] = ' ';
                }
            }
            Outp(GameField);
            while (!WinCheck(GameField))
            {
                Console.WriteLine("\n\nХод игрока 1\n");
                PlayerTurn(GameField, PlayerOneSymbol);
                Outp(GameField);
                if (WinCheck(GameField)) break;
                if (pick == "1") BotTurn(GameField, PlayeTwoSymbol);
                else
                {
                    Console.WriteLine("\n\nХод игрока 2\n");
                    PlayerTurn(GameField, PlayeTwoSymbol);
                }
                Outp(GameField);
            }
        }
    }
}