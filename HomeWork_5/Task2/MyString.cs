using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyString
    {
            /// <summary>
            /// Метод выводит только те слова сообщения, которые содержат не более чем length букв.
            /// </summary>
            /// <param name="message">Входящая строка</param>
            /// <param name="length">Длина слова</param>
            /// <returns>Возвращает список слов, которые длиннее заданной длины</returns>
            public static string ShorterThan(string message, int length)
            {
                string newLine = "";
                foreach (var word in message.Split(new char[] { ' ', ',', '.', '!', '?', '<', '>', '(', ')', '\n', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (length > word.Length) newLine = newLine + word + " "; //Если заданная длина больше длины слова, то добавляем его
                }
                return newLine;

            }

            /// <summary>
            /// Метод удаляет из сообщения все слова, которые заканчиваются на символ letter.
            /// </summary>
            /// <param name="message">Входящая строка</param>
            /// <param name="letter">Заданный символ </param>
            /// <returns>Возвращает список слов, которые не заканчиваются на указанный символ</returns>
            public static string RemoveThatEndsOn(string message, char letter)
            {
                string newLine = "";
                foreach (var s in message.Split(new char[] { ' ', ',', '.', '!', '?', '<', '>', '(', ')', '\n', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!s.EndsWith(letter.ToString())) newLine += " " + s;
                }

                return newLine;
            }

            /// <summary>
            /// Метод находит самое длинное слово сообщения.
            /// </summary>
            /// <param name="message">Входящая строка</param>
            /// <returns>Возвращает самое длинное слово из входящей строки</returns>
            public static string LongestWord(string message)
                {
                    var words = message.Split(new char[] { ' ', ',', '.', '!', '?', '<', '>', '(', ')', '\n', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    var longestWord = "";
                    foreach (var word in words)
                    {
                        if (word.Length > longestWord.Length) longestWord = word; //Если длина слова больше, длины самого большого, то это длинное слово
                    }
                    return longestWord;
                }


        /// <summary>
        /// Метод находит самые длинные слова сообщения.
        ///  </summary>
        ///  <param name="message">Входящая строка</param>
        ///  <returns>Возвращает список самых длинных слов из входящей строки</returns>
        public static string LongestWords(string message)
        {
            var longestWords = "";
            var lengthOfTheLongestWord = 0;
            var words = message.Split(new char[] { ' ', ',', '.', '!', '?', '<', '>', '(', ')', '\n', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                        if (word.Length > lengthOfTheLongestWord) lengthOfTheLongestWord = word.Length;
            }
            foreach (var word in words)
            {
                if (word.Length == lengthOfTheLongestWord) longestWords += word;

            }
            return longestWords;

        }

    }

}
