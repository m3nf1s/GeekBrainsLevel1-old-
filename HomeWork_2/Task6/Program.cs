using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
     Хорошим называется число, которое делится на сумму своих цифр.
     Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/
    class Program
    {
        static int ticks = 1000000000;
        static void Main(string[] args)
        {
            ConsoleSettings();            
            ForGoodNumbers();
            ForeachGoodNumbers();
            ForeachGoodNumbersSwitch();
            Console.ReadKey();
        }
        /// <summary>
        /// Вычисление количества "Хороших" чисел путем деления на 10
        /// </summary>
        static void ForGoodNumbers ()
        {
            int number, count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i < ticks; i++)
            {
                number = i;
                int sum = 0;
                do
                {
                    sum += number % 10;
                    number /= 10;
                } while (number != 0);
                if (i % sum == 0) count++;
            }
            var finish = DateTime.Now - start;
            Message($"Используя 'Деление на 10' у нас {count} хороших чисел. Время вычисления -  {finish}");
            
        }
        /// <summary>
        /// Вычисление количества "Хороших" с помощью foreach
        /// </summary>
        static void ForeachGoodNumbers()
        {
            string number;
            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i < ticks; i++)
            {
                number = i.ToString();
                int sum = 0;
                foreach (char s in number)
                {
                    sum += Convert.ToInt32(s) - Convert.ToInt32('0');
                }
                if (i % sum == 0) count++;
            }
            var finish = DateTime.Now - start;
            Message($"Используя 'foreach' у нас {count} хороших чисел. Время вычисления -  {finish}");

        }
        /// <summary>
        /// Вычисление количества "Хороших" с помощью foreach + switch
        /// </summary>
        static void ForeachGoodNumbersSwitch()
        {
            string number;
            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i < ticks; i++)
            {
                number = i.ToString();
                int sum = 0;
                foreach (char s in number)
                {
                    switch (s)
                    {
                        case '0':
                            sum += 0;
                            break;
                        case '1':
                            sum += 1;
                            break;
                        case '2':
                            sum += 2;
                            break;
                        case '3':
                            sum += 3;
                            break;
                        case '4':
                            sum += 4;
                            break;
                        case '5':
                            sum += 5;
                            break;
                        case '6':
                            sum += 6;
                            break;
                        case '7':
                            sum += 7;
                            break;
                        case '8':
                            sum += 8;
                            break;
                        case '9':
                            sum += 9;
                            break;
                        default:
                            Message("Oops");
                            break;
                    }
                }
                if (i % sum == 0) count++;
            }
            var finish = DateTime.Now - start;
            Message($"Используя 'foreach' + switch' у нас {count} хороших чисел. Время вычисления -  {finish}");

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

        static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
