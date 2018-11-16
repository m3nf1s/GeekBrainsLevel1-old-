using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double,double).
     Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).*/
    class Program
    {
        delegate double Del (double operand1, double operand2);
        /// <summary>
        /// Функция a*x^2
        /// </summary>
        /// <param name="operand1">a</param>
        /// <param name="operand2">x</param>
        /// <returns></returns>
        static double Func1(double operand1, double operand2) => operand1 * operand2 * operand2;
        /// <summary>
        /// Функция a*sin(x)
        /// </summary>
        /// <param name="operand1">a</param>
        /// <param name="operand2">x</param>
        /// <returns></returns>
        static double Func2(double operand1, double operand2) => operand1 * Math.Sin(operand2);
        /// <summary>
        /// Вывод функции таблицой
        /// </summary>
        /// <param name="x">Делигат</param>
        /// <param name="operand1">Переменная a</param>
        /// <param name="operand2">Переменная x</param>
        /// <param name="lastPoint">До какой точки будет вычисляться функция</param>
        static void Table(Del x, double operand1, double operand2, double lastPoint)
        {
            Console.WriteLine("----- X ------ Y ----");
            while (operand2 <= lastPoint)
            {
                Console.WriteLine("|{0,8:0.000} | {1,8:0.000}|", operand2, x(operand1, operand2));
                operand2++;
            }
            Console.WriteLine(new string('-',21));
        }
        static void Main(string[] args)
        {
            ProjectSetting();
            Console.WriteLine("Функция a*x^2");
            Table(Func1, 10, -5, 5);
            Console.WriteLine("Функция a*sin(x)");
            Table(Func2, 3, -5, 5);
            Console.ReadKey();
        }
        static void ProjectSetting()
        {
            Console.SetWindowSize(80,50);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        

    }
}
