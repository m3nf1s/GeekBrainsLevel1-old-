using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*Написать программу “Анкета”. Последовательно задаются вопросы(имя, фамилия, возраст,
    рост, вес). В результате вся информация выводится в одну строчку.*/

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деревянко Андрей GU Задание 1";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WindowWidth = 100;
            Console.Write("Введите имя> ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию> ");
            string secondName = Console.ReadLine();
            Console.Write("Введите возраст> ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите рост в см> ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите вес в кг> ");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Вывод склеиванием - Имя: " + firstName + " Фамилия: " + secondName + " Возраст: " + age + " Рост: "+ height + " Вес: " + weight); //используя склеивание;

            Console.WriteLine("Форматированный вывод - Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", firstName, secondName, age,height,weight); //используя форматированный вывод;

            Console.WriteLine($"Интерполяция строк - Имя: {firstName} Фамилия: {secondName} Возраст: {age} Рост: {height} Вес: {weight}"); //используя вывод со знаком $.

            Console.ReadKey();
        }
    }
}
