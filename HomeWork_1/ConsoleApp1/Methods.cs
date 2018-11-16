using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Methods
    {
        /// <summary>
        /// Пауза в консоли
        /// </summary>
        public static void Pause() => Console.ReadKey();

        /// <summary>
        /// Вывод сообщения в консоли в указанной точке
        /// </summary>
        /// <param name="msg">Сообщение</param>
        /// <param name="x">Смещение по оси Х</param>
        /// <param name="y">Смещение по оси Y</param>
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }
}
