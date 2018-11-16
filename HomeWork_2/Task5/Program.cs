using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;*/
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings();
            try
            {
                double difference = 0;
                string notice = "";
                Question("Введите рост в метрах> ");
                double height = Read();
                Question("Введите вес в килограммах> ");
                double weight = Read();
                if (height < 0 || weight < 0) Message("Введены не верные данные");
                    else
                    {
                    double index = weight / Math.Pow(height, 2);
                    if (index > 0 & index < 16) notice = "Выраженный дефицит массы тела";
                        else if (index >= 16 & index < 18.5) notice = "Недостаточная (дефицит) массы тела";
                            else if (index >= 18.5 & index < 25) notice = "Норма";
                                else if (index >= 25 & index < 30) notice = "Избыточная масса тела (предожирение)";
                                    else if (index >= 30 & index < 35) notice = "Ожирение";
                                        else if (index >= 35 & index < 40) notice = "Ожирение резкое";
                                            else if (index > 40) notice = "Очень резкое ожирение";
                                                else Message("Что-то пошло не так");
                    /*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
                    if (index < 18.5) difference = (18.5 * Math.Pow(height, 2)) - weight;
                        else if (index >= 25) difference = weight - (25 * Math.Pow(height, 2));
                    Message($"Ваш ИМТ = {index:F2}. У вас {notice}. Вам необходимо похудеть/поправиться на {difference} кг");
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
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

        static double Read() => double.Parse(Console.ReadLine());
    }
}
