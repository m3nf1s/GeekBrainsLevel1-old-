using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*2. *Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
     Сделать меню с различными функциями и представьте пользователю выбор для какой функции и на каком отрезке находить минимум.
     Используйте массив делегатов.*/
    class Program
    {
        static void Main(string[] args)
        {
            ProjectSettings();
            Delegate[] array = new Delegate[4] {SquadFunc, LineFunc, Hyperbole, PowFunc};
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите нужную вам функцию: 1 - Квадратная 2 - Линейная 3 - Гипербола 4 - Степенная");
                Console.Write("> ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Введите начальное значение функции> ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите конечное значение функции> ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите шаг с которым будет вычисляться функция> ");
                double c = double.Parse(Console.ReadLine());
                Save("test.bin", array[index - 1], x, b, c);
                Console.WriteLine($"Минимальный y = {Load("test.bin")}");
                Console.WriteLine("Для продолжения нажмите любую клавишу. Для выхода Escape");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }


        delegate double Delegate(double x);
        static double SquadFunc(double x) => 2 * Math.Pow(x, x) - 5 * 3 + 3;
        static double LineFunc(double x) => 6 * x + 3;
        static double Hyperbole(double x) => 5 / x;
        static double PowFunc(double x) => Math.Pow(5, x);

        static void Save(string fileName, Delegate del, double x, double b, double count)
        {
            while (x <= b)
            {
                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    while (x <= b)
                    {
                        bw.Write(del(x));
                        x += count;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    bw?.Close();
                    fs?.Close();
                }
            }
        }

        static double Load(string fileName)
        {
            FileStream fs = null;
            BinaryReader br = null;
            double min = double.MaxValue;
            try
            {
                fs = new FileStream(fileName, FileMode.Open,FileAccess.Read);
                br = new BinaryReader(fs);
                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    double number = br.ReadDouble();
                    if (number < min) min = number;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                br?.Close();
                fs?.Close();
            }
            return min;
        }

        static void ProjectSettings()
        {
            Console.SetWindowSize(100,40);
        }


    }
}
