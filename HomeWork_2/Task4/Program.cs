using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
     На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
     Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
     С помощью цикла do while ограничить ввод пароля тремя попытками.*/
    class Program
    {
        static bool flag;
        static void Main(string[] args)
        {
            ConsoleSettings();
            string trueLogin = "root";
            string truePassword = "GeekBrains";
            Check(trueLogin, truePassword);
            if (flag) Console.WriteLine($"Авторизация - {flag}. Добро пожаловать {trueLogin}"); else Console.WriteLine($"Авторизация - {flag}. Повторите попытку позже");
            Console.ReadKey();
        }

        static void Check (string log, string pas)
        {
            int count = 0;
            do
            {
                Question("Введите логин> ");
                string login = Console.ReadLine();
                Question("Введите пароль> ");
                string password = Console.ReadLine();
                if (log == login & pas == password) flag = true; else { Console.WriteLine("Неверный логин или пароль."); count++; }
            } while (!flag & count != 3);
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
    }
}
