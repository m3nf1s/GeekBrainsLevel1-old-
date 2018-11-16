using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Написать метод возвращающий минимальное из трех чисел.
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings();
            int min;
            try
            {
                Question("Введите a> ");
                int a = Read();
                Question("Введите b> ");
                int b = Read();
                Question("Введите c> ");
                int c = Read();
                min = a > b ? b : a;
                min = min > c ? c : min;
                Console.WriteLine($"Минимальное число = {min}");
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
