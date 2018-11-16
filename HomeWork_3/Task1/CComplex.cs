using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CComplex
    {
        public double Im; //Поле Действительная часть    
        public double Re; //Поле Мнимая часть

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="Im">Значение действительной части</param>
        /// <param name="Re">Значение мнимой части</param>
        public CComplex (double Im, double Re)
        {
            this.Im = Im;
            this.Re = Re;
        }
        /// <summary>
        /// Сумма 2х комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число, которое будем прибавлять</param>
        /// <returns></returns>
        public CComplex Add(CComplex a)
        {
            CComplex result = new CComplex(0,0);
            result.Im = Im + a.Im;
            result.Re = Re + a.Re;
            return result;
        }
        /// <summary>
        /// Разность 2х комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число, которое будем вычитать</param>
        /// <returns></returns>
        public CComplex Sub(CComplex a)
        {
            CComplex result = new CComplex(0, 0);
            result.Im = Im - a.Im;
            result.Re = Re - a.Re;
            return result;
        }
        /// <summary>
        /// Умножение 2х комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число, на которое будем умножать</param>
        /// <returns></returns>
        public CComplex Multy(CComplex a)
        {
            CComplex result = new CComplex(0, 0);
            result.Im = Im * a.Im - Re * a.Re;
            result.Re = Im * a.Re + Re * a.Im;
            return result;
        }
        /// <summary>
        /// Деление 2х комплексных чисел
        /// </summary>
        /// <param name="a">Комплексное число, на которое будем делить</param>
        /// <returns></returns>
        public CComplex Div(CComplex a)
        {
            CComplex result = new CComplex(0, 0);
            result.Im = (Im * a.Im + Re * a.Re) / (Math.Pow(a.Im, 2) + Math.Pow(a.Re, 2));
            result.Re = (Re * a.Im - Im * a.Re) / (Math.Pow(a.Im, 2) + Math.Pow(a.Re, 2));
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public void ShowClass(string msg)
        {
            char sign;
            if (Re > 0) sign = '+'; else { sign = '-'; Re = Math.Abs(Re); }
            Console.WriteLine($"{msg}: {Im:0.#} {sign} {Re:0.#}i");
        }
    }
}