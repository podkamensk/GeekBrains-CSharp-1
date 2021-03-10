using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public delegate double Fun(double x, double j);

    class Program
    {   

        public static void Table(Fun F, double a, double x, double b)
        //Выыод значений функции в диапазоне
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MySin(double a, double x)
        {
            return a*Math.Sin(x);
        }
        public static double MySqr(double a, double x)
        {
            return a * x * x;
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
            Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            */

            // Демонстрация фунции a*sin(x)
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(MySin), 4, -2, 2);

            // Демонстрация фунции a*sqr(x)
            Console.WriteLine("Таблица функции a*sqr(x):");
            Table(new Fun(MySqr), 4, -2, 2);


            Console.ReadKey();
        }
    }
}
