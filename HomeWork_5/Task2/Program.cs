using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /*2. Разработать методы для решения следующих задач. Дано сообщение:
        а) Вывести только те слова сообщения, которые содержат не более чем n букв;
        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
        в) Найти самое длинное слово сообщения;
        г) Найти все самые длинные слова сообщения.
        Постараться ​​разработать ​​класс​ ​MyString.*/
        static void Main(string[] args)
        {
            ProjectSetting();

            string msg = File.ReadAllText("sample.txt", Encoding.GetEncoding(1251));
            Console.WriteLine($"{MyString.ShorterThan(msg, 3)}");
            Console.WriteLine($"{MyString.RemoveThatEndsOn(msg,'й')}");
            Console.WriteLine($"{MyString.LongestWord(msg)}");
            Console.WriteLine($"{MyString.LongestWord(msg)}");

            //string msg2 = File.ReadAllText("hobbit.txt", Encoding.GetEncoding(1251));
            //Console.WriteLine(MyString.ShorterThan(msg2, 5));
            //Console.WriteLine(MyString.LongestWord(msg2));
            //Console.WriteLine(MyString.LongestWords(msg2));

            Console.ReadKey();
        }

        static void ProjectSetting()
        {
            Console.SetWindowSize(150,80);
            Console.BufferHeight = 2000;
        }
    }
}
