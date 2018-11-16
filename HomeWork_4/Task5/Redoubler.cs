using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Redoubler
    {
        public int current; // Текущее значение
        public int finish; //Конечное значение

        /// <summary>
        /// Конструктор, генерирующий конечное значение
        /// </summary>
        public Redoubler()
        {
            Random rnd = new Random();
            current = 1;
            finish = rnd.Next(2,500);
        }

        /// <summary>
        /// Увеличивает значение на 1
        /// </summary>
        /// <returns></returns>
        public int Add() => ++current;
        /// <summary>
        /// Увеличивает значение в 2 раза
        /// </summary>
        /// <returns></returns>
        public int Multi() => current *= 2;
        /// <summary>
        /// Сбрасывает до 1
        /// </summary>
        /// <returns></returns>
        public int Reset() => current = 1;
        /// <summary>
        /// Возвращает текущее значение
        /// </summary>
        public int Current
        {
            get { return current; }
        }
        /// <summary>
        /// Возвращает конечное значение
        /// </summary>
        public int Finish
        {
            get { return finish; }
        }
    }
}
