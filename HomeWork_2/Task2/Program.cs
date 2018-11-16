using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Написать метод подсчета количества цифр числа.
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings();
            try
            {
                byte count = 0;
                Question("Введите число> ");
                int numb = Read();
                int buf = numb;
                while (buf % 10 != 0)
                {
                    buf /= 10;
                    count++;
                }
                Question($"В числе {numb} количество цифр = {count}");
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
