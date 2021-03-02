using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Until0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            2.  а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            Требуется подсчитать сумму всех нечётных положительных чисел. 
            Сами числа и сумму вывести на экран, используя tryParse.
            */

            int count = 0;
            int max_count = 100; //счетчик циклов для решения задачи не нужен, но пусть будет для безопасности
            int sum = 0;
            bool wrap_it = false;


            Console.WriteLine("Вводите целые числа через клавишу \"ENTER\"");

            while (!wrap_it)
            {
                if (count > max_count)
                {
                    Console.Clear();
                    Console.WriteLine("Введено слишком много значений...");
                    break;
                }
                int input;
                if (Int32.TryParse(Console.ReadLine(), out input))
                {
                    switch (Math.Sign(input))
                     {
                        case -1:
                            break;
                        case 0:
                            wrap_it = true;
                            Console.Clear();
                            Console.WriteLine($"Сумма положительных нечетных чисел составляет {sum}");
                            break;
                        default:
                            if ((input - 1) % 2 == 0)
                            {
                                sum += input;
                            }

                            break;
                     }
                

                }
                count += 1;

            }

            Console.ReadKey();
        }
    }
}