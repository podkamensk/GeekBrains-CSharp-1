using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOut
{
    class Program
    {

        static void Printout_align(string text, char hor_align, char vert_align)
        {
            //prints out a text on the console with respect to horizontal (l, c, r) and vertical (t, m, b) alignment settings.
            int x_pos = 0;
            int y_pos = 0;
            int text_len = text.Length;

            switch (hor_align)
            {
                case 'l':
                    x_pos = 0;
                    break;
                case 'c':
                    x_pos = (Console.WindowWidth - text_len) / 2;
                    break;
                case 'r':
                    x_pos = Console.WindowWidth - text_len;
                    break;
                default:
                    break;
            };

            switch (vert_align)
            {
                case 't':
                    y_pos = 0;
                    break;
                case 'm':
                    y_pos = Console.WindowHeight / 2;
                    break;
                case 'b':
                    y_pos = Console.WindowHeight;
                    break;
                default:
                    break;
            };

            Console.SetCursorPosition(x_pos, y_pos);
            Console.WriteLine(text);

        }




        static void Main(string[] args)
        {
            /* ПАТАРУШИН
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) *Сделать задание, только вывод организовать в центре экрана.
            в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string line = "Роман Патарушин, Дублин";
            Printout_align(line, 'c', 'm');
            Console.ReadKey();

        }
    }
}
