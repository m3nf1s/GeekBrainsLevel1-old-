using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct SComplex
    {
        public double Im;//Действительная
        public double Re;//Вещественная
        //Конструктор
        public SComplex(double Im, double Re)
        {
            this.Im = Im;
            this.Re = Re;
        }
        //Сумма
        public SComplex Add(SComplex a)
        {
            SComplex result;
            result.Im = Im + a.Im;
            result.Re = Re + a.Re;
            return result;
        }
        //Вычитание
        public SComplex Sub(SComplex a)
        {
            SComplex result;
            result.Im = Im - a.Im;
            result.Re = Re - a.Re;
            return result;
        }
        //Умножение
        public SComplex Multy(SComplex a)
        {
            SComplex result;
            result.Im = Im * a.Im - Re * a.Re;
            result.Re = Im * a.Re + Re * a.Im;
            return result;
        }
        //Деление
        public SComplex Div(SComplex a)
        {
            SComplex result;
            result.Im = (Im * a.Im + Re * a.Re) / (Math.Pow(a.Im, 2) + Math.Pow(a.Re, 2));
            result.Re = (Re * a.Im - Im * a.Re) / (Math.Pow(a.Im, 2) + Math.Pow(a.Re, 2));
            return result;
        }
        //Вывод
        public void ShowStruck(string msg)
        {
            char sign;
            if (Re > 0) sign = '+'; else { sign = '-'; Re = Math.Abs(Re);}
            Console.WriteLine($"{msg}: {Im:0.#} {sign} {Re:0.#}i");
        }
    }
}