using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsClass
{
    struct Fraction
    {
        public int nmr, dnm;
        
        public double ToDecimal()
        {
            return Convert.ToDouble(nmr) / Convert.ToDouble(dnm);
        }

        public string Print()
        {   
            if (dnm == 0)
                return "Невозможно вывести";
            else if (nmr == 0)
                return "0";
            else if (nmr % dnm == 0)
                return $"{nmr / dnm}";
            else if (Math.Abs(nmr) >= Math.Abs(dnm))
                return $"{nmr/dnm} {Math.Abs((nmr % dnm))}/{Math.Abs(dnm)}";
            else
                return $"{nmr}/{dnm}";
        }

        public static Fraction Simplify(Fraction numb)
        {
            for (int i = 2; i <= numb.dnm; i += 1)
            {
                if (numb.nmr % i == 0 && numb.dnm % i == 0)
                {
                    numb.nmr = numb.nmr / i;
                    numb.dnm = numb.dnm / i;
                    i = 1;
                }
            }
            return numb;
           
        }
        public static Fraction Sum(Fraction a, Fraction b)
        {
            Fraction c;
            c.dnm = a.dnm * b.dnm;
            c.nmr = a.nmr * b.dnm + b.nmr * a.dnm;
            c = Simplify(c);
            return c;
        }
        public static Fraction Subtract(Fraction a, Fraction b)
        {
            Fraction c;
            c.dnm = a.dnm * b.dnm;
            c.nmr = a.nmr * b.dnm - b.nmr * a.dnm;
            c = Simplify(c);
            return c;
        }

        public static Fraction Multiply(Fraction a, Fraction b)
        {
            Fraction c;
            c.dnm = a.dnm * b.dnm;
            c.nmr = a.nmr * b.nmr;
            c = Simplify(c);
            return c;
        }
        public static Fraction Divide(Fraction a, Fraction b)
        {
            Fraction c;
            c.dnm = a.dnm * b.nmr;
            c.nmr = a.nmr * b.dnm;
            c = Simplify(c);
            return c;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            3.  *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
                * Добавить свойства типа int для доступа к числителю и знаменателю;
                * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
                ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
                *** Добавить упрощение дробей.
            */


            Fraction na;
            Fraction nb;
            Fraction nc;

            Console.WriteLine("Число А");
            Console.Write("Числитель: ");
            na.nmr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Знаменатель: ");
            na.dnm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nЧисло B");
            Console.Write("Числитель: ");
            nb.nmr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Знаменатель: ");
            nb.dnm = Convert.ToInt32(Console.ReadLine());

            na = Fraction.Simplify(na);
            nb = Fraction.Simplify(nb);

            Console.Clear();
            Console.WriteLine("A = {0}", na.Print());
            Console.WriteLine("B = {0}", nb.Print());

            Console.WriteLine(@"Выберите действие:
            1 - Сложение
            2 - Вычитание
            3 - Умножение
            4 - Деление");

            switch (Console.ReadLine())
            {
                case "1":
                    nc = Fraction.Sum(na, nb);
                    Console.WriteLine($"A + B = {nc.Print()}    ({nc.ToDecimal()})");
                    break;
                case "2":
                    nc = Fraction.Subtract(na, nb);
                    Console.WriteLine($"A - B = {nc.Print()}    ({nc.ToDecimal()})");
                    break;
                case "3":
                    nc = Fraction.Multiply(na, nb);
                    Console.WriteLine($"A x B = {nc.Print()}    ({nc.ToDecimal()})");
                    break;
                case "4":
                    nc = Fraction.Divide(na, nb);
                    Console.WriteLine($"A / B = {nc.Print()}    ({nc.ToDecimal()})");
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

            Console.ReadKey();
        }
    }
}
