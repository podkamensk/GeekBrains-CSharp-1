using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbas
{
    class Program
    {
        static int Sum_digits(int number)
        //returns sum of digits as an integer
        {
            int sum_dig = 0;
            number = Math.Abs(number);

            for (int pwr = 0; pwr < 11; pwr += 1)  //11 - из-за диапазона int
            {
                sum_dig += Convert.ToInt32(Math.Floor(number / Math.Pow(10, pwr)) % 10);
            }
            return sum_dig;
        }

        static bool Is_good_numba(int number)
        {
        //returns if the number is "good" or not
            int sum_dig = Sum_digits(number);
            if (number % sum_dig == 0) return true;
            else return false;
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            */

            int num_goodnumbas = 0;
            int range_start = 1;
            int range_end = 1000000000;


            DateTime date_1 = DateTime.Now;

            date_1 = DateTime.Now;
            for (int i = range_start; i <= range_end; i += 1)            //концы включаем?
            {
                if (Is_good_numba(i) == true)
                    num_goodnumbas += 1;
            }
            DateTime date_2 = DateTime.Now;

            Console.WriteLine($"Число \"хороших\" чисел в интервале от {range_start} до {range_end} равно {num_goodnumbas}");
            Console.WriteLine($"Всего затрачено времени:   {date_2 - date_1}");     //Мой рекорд 00:14:17.6117062
            Console.ReadKey();


        }
    }
}
