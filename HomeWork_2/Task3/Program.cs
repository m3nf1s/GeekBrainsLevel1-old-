using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings();
            try
            {
                int numb, sum = 0;
                do
                {
                    Question("Введите число> ");
                    numb = Read();
                    if (numb > 0 & numb % 2 == 1) sum += numb;
                } while (numb != 0);
                Question($"Сумма нечетных положительных чисел = {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
        static void ConsoleSettings()
        {
            Console.BufferHeight = 30;
            Console.BufferWidth = 150;
            Console.WindowHeight = 30;
            Console.WindowWidth = 150;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Деревянко Андрей GeekUniversity Домашняя работа №2";
        }

        static int Read() => int.Parse(Console.ReadLine());

        static void Question(string msg)
        {
            Console.Write(msg);
        }
    }
}
