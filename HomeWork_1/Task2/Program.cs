using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле
I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах*/


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деревянко Андрей GU Задание 2";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите рост в метрах> ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите вес в кг> ");
            double weight = double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            Console.WriteLine($"Индекс массы тела = {index:F}");
            Console.ReadKey();
        }
    }
}
