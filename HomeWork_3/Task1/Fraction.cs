using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Fraction
    {
        public int numerator; //Поле числитель
        public uint denominator; //Поле знаменатель, uint потому что рациональное число

        //Конструктор
        public Fraction(int numerator, uint denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        //Сумма
        public Fraction Sum(Fraction a)
        {
            Fraction x = new Fraction(0,0);
            x.numerator = numerator * (int) a.denominator + a.numerator * (int) denominator;
            x.denominator = denominator * a.denominator;
            return x;
        }
        //Вычитание
        public Fraction Sub(Fraction a)
        {
            Fraction x = new Fraction(0, 0);
            x.numerator = numerator * (int)a.denominator - a.numerator * (int)denominator;
            x.denominator = denominator * a.denominator;
            return x;
        }
        //Умножение
        public Fraction Multy(Fraction a)
        {
            Fraction x = new Fraction(0,0);
            x.numerator = numerator * a.numerator;
            x.denominator = denominator * a.denominator;
            return x;
        }
        //Деление
        public Fraction Div(Fraction a)
        {
            Fraction x = new Fraction(0,0);
            if (a.numerator < 0)
            {
                x.numerator = numerator * -(int)a.denominator;
                x.denominator = denominator * (uint)(-a.numerator);
            }
            else
            {
                x.numerator = numerator * (int) a.denominator;
                x.denominator = denominator * (uint) a.numerator;
            }
            return x;
        }
        //Наибольший общий делитель алгоритмом Евклида
        public static int Nod(Fraction x)
        {
            int tempNum = Math.Abs(x.numerator);
            int tempDenom = (int)x.denominator;
            while (tempNum != 0 & tempDenom != 0)
            {
                if (tempNum > tempDenom) tempNum %= tempDenom; else tempDenom %= tempNum;
            }
            return tempNum + tempDenom;
        }
        /// <summary>
        /// Вывод на экран дроби с упрощением 
        /// </summary>
        /// <param name="a">Дробь которую мы хотим вывести на экран и для нахождения НОД</param>
        /// <param name="msg">Сообщение которое будем выводить</param>
        public static void Print (string msg, Fraction b, Fraction c, Fraction a)
        {
            //отлов ошибки
            try
            {
                int nod = Nod(a);//нахождение НОД
                int dig = a.numerator / (int)a.denominator; //Целая часть
                a.numerator /= nod;//Упрощаем числитель
                int temp = (int)a.denominator / nod;//Упрощаем знаменатель
                //Вывод на экран
                Console.WriteLine(dig == 0 //Если целая часть = 0
                    ? $"{msg} {b.numerator}/{b.denominator} и {c.numerator}/{c.denominator} = {a.numerator % temp}/{temp}" //Выводим без целой части - true
                    : $"{msg} {b.numerator}/{b.denominator} и {c.numerator}/{c.denominator} = {dig} {Math.Abs(a.numerator % temp)}/{temp}");//Выводим с целой частью - false
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //Вывод ошибки 
            }
        }
    }
}
