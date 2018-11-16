using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*7.    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
    class Program
    {
        static void Main(string[] args)
        {
            Question("Введите начало отсчета> ");
            int a = Read();
            Question("Введите конец отсчета> ");
            int b = Read();
            Question($"Числа от {a} до {b} - ");
            Message($"{ShowRecursion(a,b)}");
            Message($"Сумма чисел = {SumRecursion(a, b)}");
            Console.ReadKey();
        }
        /// <summary>
        /// Сумма чисел от a до b
        /// </summary>
        /// <param name="a">Начальная точка</param>
        /// <param name="b">Конечная точка</param>
        /// <returns></returns>
        static int SumRecursion(int a, int b)
        {
            int sum;
            if (a == b) return a;
            sum = SumRecursion(a + 1,b) + a;
            return sum;
        }
        /// <summary>
        /// Вывод на экран чисел от a до b
        /// </summary>
        /// <param name="a">Начальная точка</param>
        /// <param name="b">Конечная точка</param>
        /// <returns></returns>
        static int ShowRecursion(int a, int b)
        {
            if (a == b) return a;
            Console.Write($"{a} ");
            return ShowRecursion(a + 1, b);
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

        static void Question(string msg)
        {
            Console.Write(msg);
        }

        static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

        static int Read() => int.Parse(Console.ReadLine());
    }
}
