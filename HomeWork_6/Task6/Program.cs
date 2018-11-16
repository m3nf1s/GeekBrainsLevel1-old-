using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    /*6. ***В заданной папке найти во всех html файлах теги <img src=...> и вывести названия картинок.
     Использовать регулярные выражения.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileCache = Directory.GetFiles("Temp", "*.*", SearchOption.AllDirectories);
            foreach (var file in fileCache)
            {
                Regex reg = new Regex(@"<img src=(\D|\d)*/>");
                string text = File.ReadAllText(file);
                foreach (var s in reg.Matches(text))
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
