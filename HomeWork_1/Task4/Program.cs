using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Написать программу обмена значениями двух переменных:

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деревянко Андрей GU Задание 4";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            //с использованием третьей переменной;
            Console.Write("Введите a> ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b> ");
            int b = int.Parse(Console.ReadLine());
            int buff = a;
            a = b;
            b = buff;
            Console.WriteLine($"a = {a} b = {b}");

            
            //без использования третьей переменной.
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} b = {b}");

            Console.ReadKey();

        }
    }
}
