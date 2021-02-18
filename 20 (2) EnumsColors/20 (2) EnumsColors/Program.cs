using System;

namespace _20__2__EnumsColors
{
    enum Color : int
    {
        White = 1,
        Black = 2,
        Green = 3,
        Blue = 4
    }
    static class Kolorvipor
    {
        public static void MathOp(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(stroka);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            Console.WriteLine("Введи один из цветов строки: White, Black, Green, Blue:");
            string zvet = Console.ReadLine();

            if ((zvet == "White") || (zvet == "Black") || (zvet == "Blue") || (zvet == "Green"))
            {
                switch (zvet)
                {
                    case "White":
                        Kolorvipor.MathOp(stroka, (int)Color.White);
                        break;
                    case "Black":
                        Kolorvipor.MathOp(stroka, (int)Color.Black);
                        break;
                    case "Blue":
                        Kolorvipor.MathOp(stroka, (int)Color.Blue);
                        break;
                    case "Green":
                        Kolorvipor.MathOp(stroka, (int)Color.Green);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка!! Такого цвета нет!!!");
            }
            Console.ReadLine();
        }
    }
}
