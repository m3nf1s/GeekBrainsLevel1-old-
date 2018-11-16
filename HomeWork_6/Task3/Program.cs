using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*3. Подсчитать количество студентов:
    а) учащихся на 5 и 6 курсах;++
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    в) отсортировать список по возрасту студента;++
    г) *отсортировать список по курсу и возрасту студента.*/
    class Program
    {
        static void Main(string[] args)
        {
            int bakalav = 0;
            int magistr = 0;
            int learnFiveSixCourse = 0;

            List<Student> list = new List<Student>(); // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("students.csv", Encoding.GetEncoding(1251));
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(';');
                        // Добавляем в список новый экземпляр класса Student
                        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                        // Одновременно подсчитываем количество бакалавров и магистров
                        if (int.Parse(s[6]) < 5) bakalav++; else magistr++;
                        if (int.Parse(s[6]) >= 5) learnFiveSixCourse++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        // Выход из Main
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr?.Close();
            }

            foreach (var student in list)
            {
                
            }
            
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalav);
            foreach (var st in list)
            {
                Console.Write($"{st.firstName} {st.lastName} {st.course} {st.age} {st.city}");
                Console.WriteLine();
            }
            Console.WriteLine($"Учатся на 5 и 6 курсе - {learnFiveSixCourse}");

            list.Sort(new Comparison<Student>(SortAge));
            foreach (var st in list)
            {
                Console.Write($"{st.age} {st.firstName} {st.lastName} {st.course}  {st.city}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        // Создаем метод для сравнения для экземпляров
        static int MyDelegat(Student st1, Student st2) => String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки

        static int SortAge(Student st1, Student st2)
        {
            string st1Buffer = st1.age.ToString();
            string st2Buffer = st2.age.ToString();
            return String.Compare(st1Buffer,st2Buffer);
        }

    }
}