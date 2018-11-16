using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectSettings();

            //Считываем вопросы и ответы
            ClassArray arrayOfQuestins = new ClassArray("..\\..\\Questions.txt");
            ClassArray arrayOfAnswers = new ClassArray("..\\..\\Answers.txt");

            //Выбираем 5 случайных вопросов
            Random rnd = new Random();
            ClassArray array1 = new ClassArray(5);
            ClassArray array2 = new ClassArray(5);
            int count = 0;
            int point = 0;
            while ( count != 5)
            {
                int index = rnd.Next(0, 37);
                //Для того чтобы не повторялись вопросы, создаем условие проверки, что значение элемента массива не равно "Пусто". После того как выбрали вопрос и ответ, меняем значение на "Пусто".
                if (arrayOfQuestins[index] != "Пусто" & arrayOfAnswers[index] != "Пусто")
                {
                    array1[count] = arrayOfQuestins[index];
                    array2[count] = arrayOfAnswers[index];
                    arrayOfQuestins[index] = "Пусто";
                    arrayOfAnswers[index] = "Пусто";
                    count++;
                }
            }

            //Задаем вопросы и набираем баллы
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array1[i]);
                Console.Write("Верите?> ");
                string answer = Console.ReadLine();
                if (answer == array2[i]) point++;
            }

            Console.WriteLine($"Вы правыильно ответили на {point} вопросов. ПОЗДРАВЛЯЕМ!!!");

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
