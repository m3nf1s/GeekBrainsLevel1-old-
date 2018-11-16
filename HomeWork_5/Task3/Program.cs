using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать.
        а) с использованием методов C#
        б) *разработав собственный алгоритм
        Например:
        badc являются перестановкой abcd*/
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово> ");
            string s1 = Console.ReadLine();
            Console.Write("Введите второе слово> ");
            string s2 = Console.ReadLine();
            Reshuffle(s1,s2);

            Console.WriteLine($"{s1} и {s2} анаграмма - {Permutation(s1,s2)}");
            Console.ReadKey();
        }

        /// <summary>
        /// Сортировка строки
        /// </summary>
        /// <param name="s1">Строка, которую надо отсортировать</param>
        /// <returns></returns>
        static string Sort(string s1)
        {
            char[] charS1 = s1.ToLower().ToCharArray();
            char buff;
            for (int i = 0; i < charS1.Length - 1; i++)
                for (int j = i + 1; j < charS1.Length; j++)
                    if (charS1[i] > charS1[j])
                    {
                        buff = charS1[i];
                        charS1[i] = charS1[j];
                        charS1[j] = buff;
                    }
            string msg = new string(charS1);
            return msg;
        }

        /// <summary>
        /// Метод, который позволяет узнать перестановка или нет
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Reshuffle(string s1, string s2)
        {
            string str1 = Sort(s1);
            string str2 = Sort(s2);
            if (str1.Length != str2.Length) Console.WriteLine("Разная длина слов");
            else if (String.Compare(str1, str2) == 0) Console.WriteLine($"{s1} и {s2} - Анаграмма"); else Console.WriteLine($"{s1} и {s2} - Не анаграмма");
        }

        /// <summary>
        /// Перестановка или нет
        /// </summary>
        /// <param name="s">Строка 1</param>
        /// <param name="t">Строка 2</param>
        /// <returns></returns>
        static public bool Permutation(String s, String t)
        {
            if (s.Length != t.Length) return false;//сравниваем длину строк

            int[] unicodeArray = new int [65536];//выделяем массив равный кодировке Unicode

            //Заполняем массив Unicode первым словом. штдекс элемента массива равен кодовому знаку символа
            char[] charArrayS = s.ToLower().ToCharArray();
            foreach (int _char in charArrayS)
            {
                unicodeArray[_char]++;
            }
            //Вычитаем из массива Unicode втроое слово. Если в ячейке -1, то слова не являются перестановкой
            char[] charArrayT = t.ToLower().ToCharArray();
            foreach (int _char in charArrayT)
            {
                if (--unicodeArray[_char] < 0)
                    return false;
            }
            
            return true;
        }
    }
}
