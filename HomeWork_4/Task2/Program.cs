using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
            /*2.а) Дописать класс для работы с одномерным массивом.
            * Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.++
            * Создать свойство Sum, которые возвращают сумму элементов массива,++
            * метод Inverse, меняющий знаки у всех элементов массива,++
            * Метод Multi, умножающий каждый элемент массива на определенное число,++
            * свойство MaxCount, возвращающее количество максимальных элементов.++
            * В Main продемонстрировать работу класса.
            * б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.++*/
        static void Main(string[] args)
        {
            ProjectSettings();
            
            Console.WriteLine("Демонстрация работы класса массив");
            Console.WriteLine();

            ClassArray arrayStreamReader = new ClassArray("..\\..\\TestArray.txt"); //Массив из файла;
            arrayStreamReader.ShowArray("Массив созданный из файла");

            ClassArray array2 = new ClassArray(10, 7,7); //Массив с заданным шагом
            array2.ShowArray("Массив созданный с заданным шагом");

            array2.Multi(10);
            array2.ShowArray("Массив умноженный на число 10");//умножение

            Console.WriteLine($"Сумма элементов массива = {array2.SumOfArray}"); //Сумма

            array2.Inverse(); //Инверсия
            array2.ShowArray("Инверсированный массив");
            
            ClassArray array3 = new ClassArray(20,0,20);
            array3.ShowArray("Массив в котором будет поиск максимального элемента");
            Console.WriteLine($"Максимальный элемент = {array3.Max}. Количство максимальных элементов = {array3.MaxCount}");//Макс кол-во Max

            array2.WriteFile("..\\..\\TestWrite.txt"); //Запись массива в файл

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
