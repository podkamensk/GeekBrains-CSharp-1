using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ПАТАРУШИН
            4. Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной;
	        б) *без использования третьей переменной.
            */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string a;
            string b;
            string inter;

            Console.Write("a = ");
            a = Console.ReadLine();
            Console.Write("b = ");
            b = Console.ReadLine();

            Console.WriteLine("\n\nВжух!\n\n");

            //Swap with buffer var
            inter = a;
            a = b;
            b = inter;
            Console.WriteLine("Меняем переменные через промежуточную: a = {0}, b = {1}\n", a, b);

            //Swap back without buffer var
            (a, b) = (b, a);
            Console.WriteLine("Меняем переменные обратно уже без промежуточной(*): a = {0}, b = {1}\n", a, b);

            Console.ReadKey();
        }
    }
}
