using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2Switch
{
    class Program
    {
        static bool @bool;
        static int pick;

        #region Программа
        static void Main(string[] args)
        {
            do
            {
                ConsoleSettings();
                Menu();
                try
                {
                    pick = IntRead();
                    if (pick >= 0 & pick <= 7)
                    {
                        switch (pick)
                        {
                            case 1:
                                Task1();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 2:
                                Task2();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 3:
                                Task3();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 4:
                                Task4();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 5:
                                Task5();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 6:
                                Task6();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 7:
                                Task7();
                                Retrun();
                                if (pick == 0) goto case 0;
                                else break;
                            case 0:
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели не число. Выволнение остановлено");
                }
            } while (@bool & pick == 0);
            Console.Clear();
            Message("Спасибо за уделенное внимание :)");
            Console.ReadKey();
        }
        #endregion

        #region Задача 1
        /*----------------------------------------------------------------*/
        /// <summary>
        /// Написать метод возвращающий минимальное из трех чисел.
        /// </summary>
        static void Task1()
        {
            TaskScreen();
            Message("Находение наименьшего числа\n");
            int min;
            try
            {
                Message("Введите a> ");
                int a = IntRead();
                Message("Введите b> ");
                int b = IntRead();
                Message("Введите c> ");
                int c = IntRead();
                min = a > b ? b : a;
                min = min > c ? c : min;
                Console.WriteLine($"Минимальное число = {min}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. Выволнение остановлено");
            }
        }
        #endregion

        #region Задача 2
        /*----------------------------------------------------------------*/
        /// <summary>
        ///Написать метод подсчета количества цифр числа.
        /// </summary>
        static void Task2()
        {
            TaskScreen();
            Message("Вычисление количества цифр в числе \n");
            try
            {
                byte count = 0;
                Message("Введите число> ");
                int numb = IntRead();
                int buf = numb;
                while (buf % 10 != 0)
                {
                    buf /= 10;
                    count++;
                }
                Message($"В числе {numb} количество цифр = {count}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. Выволнение остановлено");
            }
        }
        #endregion

        #region Задача 3
        
        /// <summary>
        /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        static void Task3()
        {
            TaskScreen();
            Message("Сумма нечетных положительных чисел, которые вводятся с клавиатуры. Чтобы остановить ввод нажмите '0' (ноль)\n");
            try
            {
                int numb, sum = 0;
                do
                {
                    Message("Введите число> ");
                    numb = IntRead();
                    if (numb > 0 & numb % 2 == 1) sum += numb;
                } while (numb != 0);
                Message($"Сумма нечетных положительных чисел = {sum}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. Выволнение остановлено");
            }
        }
        #endregion

        #region Задача 4
        /*--------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Реализовать метод проверки логина и пароля.
        /// </summary>
        /*На вход подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
        Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        С помощью цикла do while ограничить ввод пароля тремя попытками.*/
        static bool flag;
        static void Task4()
        {
            TaskScreen();
            Message("Проверка логина и пароль \n");
            string trueLogin = "root";
            string truePassword = "GeekBrains";
            Check(trueLogin, truePassword);
            if (flag) Message($"Авторизация - {flag}. Добро пожаловать {trueLogin}\n"); else Message($"Авторизация - {flag}. Повторите попытку позже. \n");
        }
        static void Check(string log, string pas)
        {
            int count = 0;
            do
            {
                Message("Введите логин> ");
                string login = Console.ReadLine();
                Message("Введите пароль> ");
                string password = Console.ReadLine();
                if (log == login & pas == password) flag = true; else { Message("Неверный логин или пароль. \n"); count++; }
            } while (!flag & count != 3);
        }
        #endregion

        #region Задача 5
        /*--------------------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        ///Нахождение индекса массы тела              
        /// </summary>
        /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
          б)Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
        static void Task5()
        {
            TaskScreen();
            Message("Нахождение индекса массы тела\n");
            try
            {
                double difference = 0;
                string notice = "";
                Message("Введите рост в метрах> ");
                double height = DoubRead();
                Message("Введите вес в килограммах> ");
                double weight = DoubRead();
                if (height <= 0 || weight <= 0) Message("Введены не верные данные\n");
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
                                                else Message("Что-то пошло не так \n");
                    if (index < 18.5) difference = (18.5 * Math.Pow(height, 2)) - weight;
                        else if (index >= 25) difference = weight - (25 * Math.Pow(height, 2));
                    Message($"Ваш ИМТ = {index:F2}. У вас {notice}. Вам необходимо похудеть/поправиться на {difference} кг. \n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. Выволнение остановлено");
            }
        }
        #endregion

        #region Задача 6

        /*--------------------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        ///Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
        /// </summary>
        /*Хорошим называется число, которое делится на сумму своих цифр.
          Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/
        static int ticks = 100000000;
        static void Task6()
        {
            
            TaskScreen();
            Message("Нахождение 'Хороших' чисел, которые делятся на сумму своих цифр\n");
            ForGoodNumbers();
            ForeachGoodNumbers();
            ForeachGoodNumbersSwitch();
        }
        /// <summary>
        /// Вычисление количества "Хороших" чисел путем деления на 10
        /// </summary>
        static void ForGoodNumbers()
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
            Message($"Используя 'Деление на 10' у нас {count} хороших чисел от 1 до {ticks}. Время вычисления -  {finish} \n");
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
            Message($"Используя 'foreach' у нас {count} хороших чисел от 1 до {ticks}. Время вычисления -  {finish} \n");

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
            Message($"Используя 'foreach' + switch' у нас {count} хороших чисел от 1 до {ticks}. Время вычисления -  {finish}\n");
        }
        #endregion

        #region Задача 7
        /*--------------------------------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Разработка рекурсивных методов
        /// </summary>
        /* 7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
             б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
        static void Task7()
        {
            TaskScreen();
            Message("Вывод всех чисел в промежутке и нахождение их суммы через рекурсию\n");
            Message("Введите начало отсчета> ");
            int a = IntRead();
            Message("Введите конец отсчета> ");
            int b = IntRead();
            Message($"Числа от {a} до {b} - ");
            Message($"{ShowRecursion(a, b)}\n");
            Message($"Сумма чисел = {SumRecursion(a, b)}\n");
        }
        /// <summary>
        /// Сумма чисел от a до b
        /// </summary>
        /// <param name="a">Начальная точка</param>
        /// <param name="b">Конечная точка</param>
        /// <returns></returns>
        static int SumRecursion(int a, int b)
        {
            int sum;
            if (a <= b)
            {
                if (a == b) return a;
                sum = SumRecursion(a + 1, b) + a;
                return sum;
            }
            else
            {
                if (a == b) return b;
                sum = SumRecursion(a, b + 1) + b;
                return sum;
            }

        }
        /// <summary>
        /// Вывод на экран чисел от a до b
        /// </summary>
        /// <param name="a">Начальная точка</param>
        /// <param name="b">Конечная точка</param>
        /// <returns></returns>
        static int ShowRecursion(int a, int b)
        {
            if (a <= b)
            {
                if (a == b) return a;
                Console.Write($"{a} ");
                return ShowRecursion(a + 1, b);
            }
            else
            {
                if (a == b) return b;
                Console.Write($"{b} ");
                return ShowRecursion(a, b + 1);
            }
        }
        #endregion

        #region Блок дополнительных методов
        /// <summary>
        /// Стартовые настройки консоли
        /// </summary>
        static void ConsoleSettings()
        {
            Console.BufferHeight = 30;
            Console.BufferWidth = 150;
            Console.WindowHeight = 30;
            Console.WindowWidth = 150;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Деревянко Андрей GeekUniversity Домашняя работа №2";
        }
        /// <summary>
        /// Главное меню
        /// </summary>
        static void Menu()
        {
            Console.Clear();
            Message("Урок 2. Управляющие конструкции.\n"+
                    "1. Минимальное значение из 3х чисел\n"+
                    "2. Подсчет количества цифр числа\n"+
                    "3. Сумма нечетных положительных чисел\n"+
                    "4. Проверки логина и пароля\n"+
                    "5. Вычисление индексам массы тела\n"+
                    "6. Вычисление 'Хороших чисел'\n"+
                    "7. Работа с рекурсией\n"+
                    "Любое значение - выход\n"+
                    "Выбери нужный вам пункт> ");
        }
        /// <summary>
        /// Настройки экрана задачи
        /// </summary>
        static void TaskScreen()
        {
            Console.Title = $"Задание {pick}";
            Console.Clear();
        }
        /// <summary>
        /// Чтение целочисленного числа int с консоли
        /// </summary>
        /// <returns>Число типа int</returns>
        static int IntRead() => int.Parse(Console.ReadLine());
        /// <summary>
        /// Чтение вещественного числа Double с консоли
        /// </summary>
        /// <returns>Число типа int</returns>
        static double DoubRead() => double.Parse(Console.ReadLine());
        /// <summary>
        /// Вывод сообщения на консоль
        /// </summary>
        /// <param name="msg">Сообщение</param>
        static void Message(string msg)
        {
            Console.Write(msg);
        }
        /// <summary>
        /// Возвращение после выполнения задая на главное меню
        /// </summary>
        static void Retrun()
        {
            Message("Вернуться в меню (0 - да)?> ");
            @bool = int.TryParse(Console.ReadLine(), out pick);
        }

        #endregion
    }
}
