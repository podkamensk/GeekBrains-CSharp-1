using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ПАТАРУШИН
            а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double height;
            double weight;
            double weight_perfect;
            double imt;
            double imt_perfect = 23;
            double tolerance = 0.04;


            Console.Write("Введите рост, см:   ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вес, кг:   ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            //imt calculation
            imt = weight / (height * height) * 10000;
            weight_perfect = imt_perfect * height * height/ 10000;

            Console.WriteLine($"Ваш ИМТ составляет {imt:f1}\nПри вашем росте ваш идеальный вес составляет {weight_perfect:f1}");

            //overweight/underweight conclusion
            if (imt < imt_perfect*(1 - tolerance))
            {
            Console.WriteLine($"У вас недобор веса. До идеальной формы необходимо набрать ещё {Math.Abs(weight - weight_perfect):f1} кг");
            }
            else if (imt >= imt_perfect * (1 - tolerance) && imt < imt_perfect)
            {
            Console.WriteLine($"Вы в отличной форме. До идеального веса недостает всего {Math.Abs(weight - weight_perfect):f2} кг");
            }
            else if (imt >= imt_perfect && imt < imt_perfect * (1 + tolerance))
            {
            Console.WriteLine($"Вы в отличной форме. До идеального веса достаточно скинуть еще {Math.Abs(weight - weight_perfect):f2} кг");
            }
            else
            {
            Console.WriteLine($"У вас лишний вес. До идеальной формы необходимо похудеть на {Math.Abs(weight - weight_perfect):f1} кг");
            }
 
            Console.ReadLine();
        }
    }
}
