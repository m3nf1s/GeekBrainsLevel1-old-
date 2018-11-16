using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Деревянко Андрей GeekUniversity Урок 3. Методы. От структур к объектам. Исключения
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectSettings();


            Console.WriteLine("Пример работы структуры и класса 'Комплексные числа'");
            //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
            SComplex struck1 = new SComplex(2.3, 2.7);
            SComplex struck2 = new SComplex(5.1, 4.9);
            SComplex resultStruck = struck1.Add(struck2);
            resultStruck.ShowStruck("Сумма");
            resultStruck = struck1.Sub(struck2);
            resultStruck.ShowStruck("Вычитание");
            resultStruck = struck1.Multy(struck2);
            resultStruck.ShowStruck("Умножение");
            resultStruck = struck1.Div(struck2);
            resultStruck.ShowStruck("Деление");
            Console.WriteLine("----------------------");
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
            CComplex class1 = new CComplex(2.3, 2.7);
            CComplex class2 = new CComplex(5.1, 4.9);
            CComplex resultClass = class1.Add(class2);
            resultClass.ShowClass("Сумма");
            resultClass = class1.Sub(class2);
            resultClass.ShowClass("Вычитание");
            resultClass = class1.Multy(class2);
            resultClass.ShowClass("Умножение");
            resultClass = class1.Div(class2);
            resultClass.ShowClass("Деление");
            Console.WriteLine("----------------------");
            
            /*2.а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).
            Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран; Используя tryParse;*/
            SumOfNumbers sum1 = new SumOfNumbers();
            sum1.SumTryParse();
            /*б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
            данные.При возникновении ошибки вывести сообщение.*/
            SumOfNumbers sum2 = new SumOfNumbers();
            sum2.SumTryCatch();
            Console.WriteLine("----------------------");

            Console.WriteLine("Пример работы класса дробь и упрощение дробей");
            /*3.*Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.
            Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
            программу, демонстрирующую все разработанные элементы класса.
            * Добавить упрощение дробей.*/
            Fraction fr1 = new Fraction(1, 6);
            Fraction fr2 = new Fraction(-3, 2);
            Fraction resultSum = fr1.Sum(fr2);
            Fraction.Print("Результат суммы:", fr1,fr2, resultSum);
            Fraction resultSub = fr1.Sub(fr2);
            Fraction.Print("Результат вычитания:", fr1,fr2,resultSub);
            Fraction resultMulty = fr1.Multy(fr2);
            Fraction.Print("Результат умножения:", fr1,fr2,resultMulty);
            Fraction resultDiv = fr1.Div(fr2);
            Fraction.Print("Результат деления:",fr1,fr2,resultDiv);
            Console.ReadKey();
        }

        static void ProjectSettings()
        {
            Console.Title = "Деревянко Андрей GeekUniversity Урок 3 Классы и методы";
            Console.BufferHeight = 30;
            Console.BufferWidth = 120;
            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
