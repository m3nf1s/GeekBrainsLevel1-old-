using System;
using System.IO;


namespace Task4
{
    class Matrix
    {
        private int[,] matrix { get; set; } //Поле матрица

        /// <summary>
        /// Конструктор инициализирующий матрицу
        /// </summary>
        /// <param name="xLength">Количество столбцов</param>
        /// <param name="yLength">Количество строк</param>
        public Matrix(int xLength, int yLength)
        {
            matrix = new int[xLength,yLength];
        }

        /// <summary>
        /// Конструктор инициализирующий матрицу
        /// </summary>
        /// <param name="xLength">Количество столбцов</param>
        /// <param name="yLength">Количество строк</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        public Matrix(int xLength, int yLength, int min, int max) : this (xLength,yLength)
        {
            Random rnd = new Random();
            for (int i = 0; i < xLength; i++)
            for (int j = 0; j < yLength; j++)
            {
                matrix[i, j] = rnd.Next(min, max + 1);
            }
        }

        /// <summary>
        /// Конструктор создающий матрицу из файла
        /// </summary>
        /// <param name="fileName">Имя файла, в котором находятся данные для матрицы</param>
        public Matrix(string fileName)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                int xLength = int.Parse(sr.ReadLine());
                int yLength = int.Parse(sr.ReadLine());
                matrix = new int[xLength,yLength];
                for (int i = 0; i < xLength; i++)
                    for (int j = 0; j < yLength; j++)
                        matrix[i, j] = int.Parse(sr.ReadLine());
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
        /// Метод возвращающий сумму матрицы
        /// </summary>
        /// <returns>Сумма</returns>
        public int SumOfMatrix()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

            return sum;
        }

        /// <summary>
        /// Метод возвращий сумму всех элементов матрицы больше заданного
        /// </summary>
        /// <param name="bigNumber">Пороговое число</param>
        /// <returns>Сумма</returns>
        public int SumOfMatrix(int bigNumber)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] > bigNumber) sum += matrix[i, j];
            }
            return sum;
        }

        /// <summary>
        /// Свойство возвращающее минимальный элемент
        /// </summary>
        public int Min
        {
            get
            {
                int min = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i, j] < min)
                            min = matrix[i, j];
                return min;
            }
        }

        /// <summary>
        /// Свойство возвращающее максимальный элемент
        /// </summary>
        public int Max
        {
            get
            {
                int max = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                return max;
            }
        }

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        public void ShowMatrix(string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Запись матрицы в текстовый файл
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void WriteMatrix(string fileName)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fileName);
                sw.WriteLine(matrix.GetLength(0));
                sw.WriteLine(matrix.GetLength(1));
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        sw.WriteLine(matrix[i, j]);
                Console.WriteLine("Запись была выполнена успешно");
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
        /// Нахождение индекса максимального элемента матрицы
        /// </summary>
        /// <param name="index">Переменная, в которой будет храниться индекс</param>
        /// <returns></returns>
        public string IndexOfMax(out string index)
        {
            int max = matrix[0, 0];
            index = "0 0";
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    index = $"{i} {j}";
                }
            return index;
        }
    }
}
