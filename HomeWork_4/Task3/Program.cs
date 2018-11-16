using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /*3.Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.*/
        static void Main(string[] args)
        {
            ProjectSettings();

            LoginAndPassword test = new LoginAndPassword("LogAndPas.txt");
            test.Checking();

            Console.ReadKey();
        }

        static void ProjectSettings()
        {
            Console.SetWindowSize(130, 40);
            Console.SetBufferSize(130, 150);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Деревянко Андрей GeekUniversity Урок 4: Массивы.Текстовые файлы";
        }
    }
}
