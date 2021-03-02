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
            3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            */

            int count = 0;
            int max_count = 100; //счетчик циклов для решения задачи не нужен, но пусть будет для безопасности
            int sum = 0;
            bool wrap_it = false;


            Console.WriteLine("Вводите целые числа через клавишу \"ENTER\"");

            while (wrap_it == false)
            {   
                if (count > max_count)
                {
                    Console.Clear();
                    Console.WriteLine("Введено слишком много значений...");
                    break;
                }

                int input = Convert.ToInt32(Console.ReadLine());
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
                        if ( (input - 1) % 2 == 0)
                        {
                            sum += input;
                        }

                        break;

                }
                count += 1;

            }

             Console.ReadKey();
        }
    }
}
