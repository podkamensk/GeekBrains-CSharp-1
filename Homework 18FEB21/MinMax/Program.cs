using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {

        static double My_min(params double[] list)
        //gets variable amount of doubles as arguments, returns finds min value
        {
            double min_val = list[0];

            for (int i = 1; i < list.Length; i += 1)
            {
                if (min_val > list[i]) 
                {
                    min_val = list[i];
                }
            }

            return min_val;
        }

        static double My_max(params double[] list)
        //gets variable amount of doubles as arguments, returns max value
        {
            double max_val = list[0];

            for (int i = 1; i < list.Length; i += 1)
            {
                if (max_val < list[i])
                {
                    max_val = list[i];
                }
            }

            return max_val;
        }
        
        static int Num_digits(int number)
        //returns number of digits as an integer
        {
            int num_dig = 0;

            for (int pwr = 0; pwr < 11; pwr += 1 )  //11 - из-за диапазона int
            {
                if (Math.Floor(Math.Abs(number / Math.Pow(10, pwr))) != 0)
                    num_dig += 1;
                else break;
            }
            return Math.Max(num_dig, 1);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            1. Написать метод, возвращающий минимальное из трёх чисел.
            2. Написать метод подсчета количества цифр числа.
            */



            Console.WriteLine("Проверка метода My_min");
            Console.WriteLine(My_min(0, -45, -345.54, 75349, 12, 0.2343) + "\n\n");
            Console.WriteLine("Проверка метода My_max");
            Console.WriteLine(My_max(0, -45, -345.54, 75349, 12, 0.2343) + "\n\n");
            Console.WriteLine("Проверка метода Num_digits");
            Console.WriteLine(Num_digits(-53578) + "\n\n");
            Console.ReadKey();











        }
    }
}
