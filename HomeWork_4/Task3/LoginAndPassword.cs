using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class LoginAndPassword
    {
        public string[] arrayOfLogins { set; get; } // Массив логинов
        public string[] arrayOfPasswords { set; get; } //Массив паролей

        /// <summary>
        /// Конструктор, который считывает логины и пароли из файла
        /// </summary>
        /// <param name="fileName">Имя файла, в котором находятся логины и пароли</param>
        public LoginAndPassword(string fileName)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                int length = int.Parse(sr.ReadLine());
                arrayOfLogins = new string[length];
                arrayOfPasswords = new string[length];
                for (int i = 0; i < length; i++)
                    arrayOfLogins[i] = sr.ReadLine();
                for (int i = 0; i < length; i++)
                    arrayOfPasswords[i] = sr.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        public void Checking()
        {
            bool flag = false; //Флаг
            int count = 0;
            do
            {
                Console.Write("Введите login> ");
                string login = Console.ReadLine();
                Console.Write("Введите password> ");
                string password = Console.ReadLine();
                for (int i = 0; i < arrayOfLogins.Length; i++)
                    for (int j = 0; j < arrayOfPasswords.Length; j++)
                        //Сравниваем введеный логин и пароль с элементами соответствующих массивов и индексы элементов
                        if (login == arrayOfLogins[i] & password == arrayOfPasswords[j]& i == j) { flag = true; Console.WriteLine($"Добро пожаловать {login}"); }

                if (!flag & count != 3)
                {
                    count++;
                    if (count <3) Console.WriteLine("Введен не правильно логин или пароль"); else Console.WriteLine("Превышено количество попыток");
                }
            } while (!flag & count != 3);
        }
    }
}
