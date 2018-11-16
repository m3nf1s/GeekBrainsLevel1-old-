using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

//Написать программу, которая выводит на экран ваше имя, фамилию и город проживания
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Деревянко Андрей GU Задание 5 и 6";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Введите имя> ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию> ");
            string secondName = Console.ReadLine();
            Console.Write("Введите город в котором проживаете> ");
            string city = Console.ReadLine();
            
            
            //Сделать задание, только вывод организуйте в центре экрана
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Имя: {firstName} Фамилия: {secondName} Город: {city}");

            string msg = ($"Имя: {firstName} Фамилия: {secondName} Город: {city}");


            //Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
            //Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
            Methods.Print(msg, 30, 15);
            Methods.Pause();
            
        }   

    }
}
