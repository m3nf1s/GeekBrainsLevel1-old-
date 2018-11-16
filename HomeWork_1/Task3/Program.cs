using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*Написать программу, которая подсчитывает расстояние между точками с координатами x1,
y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат
используя спецификатор формата .2f (с двумя знаками после запятой);*/

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деревянко Андрей GU Задание 3";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите x1> ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите y1> ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2> ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите y2> ");
            double y2 = double.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"r = {r:F2}");

            Console.WriteLine($"r = {Function(x1, y1, x2, y2):f2}");

            Console.ReadKey();
        }

        //Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
        static double Function(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 

    }
}
