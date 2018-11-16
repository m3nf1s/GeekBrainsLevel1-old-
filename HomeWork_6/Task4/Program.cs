using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task4
{
    /*4. **В файле могут встречаться номера телефонов, записанные в формате xx-xx-xx, xxx-xxx или xxx-xx-xx.
     Вывести все номера телефонов, которые содержатся в файле.*/
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("phone.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = null;
            Regex reg = null;
            try
            {
                sr = new StreamReader("phone.txt");
                reg = new Regex(@"(^\d{3}-\d{3})$|^(\d{2}(-\d\d){2})$|^(\d{3}(-\d\d){2})$");
                string text = sr.ReadToEnd();
                Console.WriteLine("Список всех номеров в файле");
                Console.WriteLine(text);
                Console.WriteLine("Список номер найденных по шаблону");
                string[] arrayStrings = text.Split(' ', '\n', '\r', '\t');
                foreach (var s in arrayStrings)
                {
                    foreach (var q in reg.Matches(s))
                    {
                        Console.WriteLine(q);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }
    }
}
