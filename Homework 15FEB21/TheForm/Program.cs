using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForm
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ПАТАРУШИН
            1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            а) используя  склеивание;
	        б) используя форматированный вывод;
	        в) используя вывод со знаком $.
            */

            /*
            2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            string first_name;
            string last_name;
            double age;
            double height;
            double weight;
            double imt;


            Console.Write("Введите имя:   ");
            first_name = Console.ReadLine();

            Console.Write("Введите фамилию:   ");
            last_name = Console.ReadLine();

            Console.Write("Введите возраст, лет:   ");
            age = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите рост, см:   ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вес, кг:   ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            //Output 1
            Console.WriteLine(first_name + " " + last_name + ", " + age + " лет, " + height + " см, " + weight + " кг\n\n");
            //Output 2
            Console.WriteLine("{0} {1}, {2:f0} лет, {3:f0} см, {4:f1} кг\n\n", first_name, last_name, age, height, weight);
            //Output 3
            Console.WriteLine("{0} {1}, {2:C0} лет, {3:C0} см, {4:C1} кг\n\n", first_name, last_name, age, height, weight);

            //imt calculation and output
            imt = weight / (height * height) * 10000;
            Console.WriteLine("Ваш ИМТ: {0:f2}", imt);

            Console.ReadLine();

        }
    }
}
