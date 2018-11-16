using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        /*4. *а) Реализовать класс для работы с двумерным массивом. 
         * Реализовать конструктор, заполняющий массив случайными числами. ++
         * Создать методы, которые возвращают сумму всех элементов массива,++
         * сумму всех элементов массива больше заданного,++
         * свойство, возвращающее минимальный элемент массива, ++
         * свойство, возвращающее максимальный элемент массива, ++
         * метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out) ++
         **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл. ++*/
        static void Main(string[] args)
        {
            ProjectSettings();

            Console.WriteLine("Пример работы класса Матрица");
            Console.WriteLine();

            Matrix testMatrix = new Matrix(3,3,-10,10);
            testMatrix.ShowMatrix("Матрица размером 3х3 заполненая случайными числами от -10 до 10");


            Console.WriteLine($"Сумма элементов матрицы = {testMatrix.SumOfMatrix()}");;

            Console.WriteLine($"Сумма элементов матрицы больше 6 = {testMatrix.SumOfMatrix(6)}");
            testMatrix.IndexOfMax(out string index);
            Console.WriteLine($"Минимальный элемент матрицы = {testMatrix.Min}, Максимальный элемент матрицы = {testMatrix.Max}, Индекс максимального элемента = {index}");
            Console.WriteLine();

            Matrix streamMatrix = new Matrix("..\\..\\Matrix.txt");
            streamMatrix.ShowMatrix("Матрица заполненая из файла");

            testMatrix.WriteMatrix("..\\..\\TestMatrix.txt");

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
