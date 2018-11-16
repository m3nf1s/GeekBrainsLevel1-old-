using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SumOfNumbers
    {
        public int Sum; // поле сумма
        /// <summary>
        /// Метод нахождения суммы с помошью TryPasre
        /// </summary>
        public void SumTryParse()
        {
            int number; //Число, которое суммируем
            bool @bool; // Проверка, смог ли компьютер конвертировать из строки в число
            Console.WriteLine("Нахождение суммы чисел. Для остановки введите 0");
            do
            {
                Console.Write("Введите число> ");
                @bool = int.TryParse(Console.ReadLine(), out number);
                Sum += number;
                if(!@bool) Console.WriteLine("Введено не число. Операция остановлена.");
            } while (number != 0 & @bool);
            Console.WriteLine($"Сумма чисел = {Sum}");
        }
        /// <summary>
        /// Метод нахождения суммы с помощью отлова ошибки
        /// </summary>
        public void SumTryCatch()
        {
            Console.WriteLine("Нахождение суммы чисел. Для остановки введите 0");
            int number;
            try
            {
                do
                {
                    Console.Write("Введите число> ");
                    number = int.Parse(Console.ReadLine());
                    Sum += number;

                } while (number != 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не число.Операция остановлена.");
            }
            finally
            {
                Console.WriteLine($"Сумма чисел = {Sum}");
            }
        }
    }
}
