using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /*1. Создать программу, которая будет проверять корректность ввода логина.
         Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры,
         и при этом цифра не может быть первой.*/
        static void Main(string[] args)
        {
            string login = Console.ReadLine();
            /*а) без использования регулярных выражений;*/
            Console.WriteLine($"Корректность логина - {WithoutRegex(login)}");
            /*б) **с использованием регулярных выражений.*/
            Console.WriteLine($"Корректность логина - {WithRegex(login)}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверки логина без регулярного выражения
        /// </summary>
        /// <param name="login">Проверяемый логин</param>
        static bool WithoutRegex(string login)
        {
            //Проверка длинны
            if (login.Length < 2 || login.Length > 10) return false;
            //Проверка 1го символа на число
            if (char.IsDigit(login[0])) return false;
            //Проверка элементов являются числом или буквой
            
                for (int i = 0; i < login.Length; i++)
                {
                    //Если не число и не буква - false
                    if (!char.IsLetterOrDigit(login[i])) return false;
                }
            return true;
        }

        /// <summary>
        /// Метод проверки логина с регулярным выражением
        /// </summary>
        /// <param name="login">Проверяемыый логин</param>
        static bool WithRegex(string login)
        {
            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            if (login_regex.Match(login).Success) return true; else return false;
        }
    }
}
