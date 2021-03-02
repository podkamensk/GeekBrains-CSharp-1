using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexStruct
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            1.  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                в) Добавить диалог с использованием switch демонстрирующий работу класса.
            */

            Complex na;
            Complex nb;

            Console.WriteLine("Число А");
            Console.Write("Дейстивительная часть: ");
            na.re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Мнимая часть: ");
            na.im = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\nЧисло B");
            Console.Write("Дейстивительная часть: ");
            nb.re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Мнимая часть: ");
            nb.im = Convert.ToDouble(Console.ReadLine());

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
                    Console.WriteLine("A + B = " + Complex.Sum(na, nb).Print());
                    break;
                case "2":
                    Console.WriteLine("A - B = " + Complex.Subtract(na, nb).Print());
                    break;
                case "3":
                    Console.WriteLine("A x B = " + Complex.Multiply(na, nb).Print());
                    break;
                case "4":
                    Console.WriteLine("A / B = " + Complex.Divide(na, nb).Print());
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }

            Console.ReadKey();

        }
    }
}
