using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ClassArray
    {
        public string[] array; // поле массив

        /// <summary>
        /// Конструктор инициализации массива
        /// </summary>
        /// <param name="length">Длина массива</param>
        public ClassArray(int length)
        {
            array = new string[length];
        }

        /// <summary>
        /// Конструктор, который создает массив и заполняет его данными из файла
        /// </summary>
        /// <param name="filename">Имя файла, в котором находятся данные</param>
        public ClassArray(string filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                int length = int.Parse(sr.ReadLine());
                array = new string[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = sr.ReadLine();
                }
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
        /// Вывод массива на экран
        /// </summary>
        public void ShowArray(string msg)
        {
            try
            {
                Console.WriteLine(msg);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{array[i]} ");
                }
                Console.WriteLine(); Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Метод записи массива в файл
        /// </summary>
        /// <param name="filename">Имя файла, в который будут записаны данные массива</param>
        public void WriteFile(string filename)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine(array.Length);
                for (int i = 0; i < array.Length; i++)
                    sw.WriteLine(array[i]);
                Console.WriteLine("Данные успешно сохранены");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }

        /// <summary>
        /// Индексируемое свойство
        /// </summary>
        /// <param name="i">Индекс массива</param>
        /// <returns>Возвращаемый элемент массива с заданным индексом</returns>
        public string this [int i]
        {
            get => array[i];
            set => array[i] = value;
        }
        
    }
}
