using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /*1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
        * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.*/
        static void Main(string[] args)
        {
            ProjectSettings();

            Console.WriteLine("Программа, позволяющая найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.");
            Console.WriteLine();
            ClassArray array1 = new ClassArray(20, -10000, 10001);
            array1.ShowArray();
            int testpair = array1.PairOfDivThree();
            Console.WriteLine($"Количество пар = {testpair}");

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
