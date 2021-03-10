using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static bool If_Anagram(string str_a, string str_b)
            //Checks if 2 strings are amagramic
        {
            if (str_a.Length == str_b.Length) //if different string lengths return false
            {
                int len = str_a.Length;
                for (int i = 0; i < len; i += 1)
                {
                    int num_a = 0;
                    int num_b = 0;
                    char ch = str_a[i];

                    for (int ii = 0; ii < len; ii += 1)
                    {
                        if (str_a[ii] == ch)
                            num_a += 1;
                        if (str_b[ii] == ch)
                            num_b += 1;
                    }
                    //if single case of numbers mismatch, return false
                    if (num_a != num_b)
                        return false;
                }
                return true;
            }
            else return false;
        }

        static string String_Refine(string str_raw)
            //Removes all spaces and special symbols from the string. Returns new string 
        {
            var str_ref = string.Empty;
            for (int i = 0; i < str_raw.Length; i += 1)
            {

                if (Char.IsLetterOrDigit(str_raw, i))
                    str_ref += str_raw[i];
            }
            return str_ref;
        }
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            Например:
            badc являются перестановкой abcd.
             */

            string str_a = "  pa!!ra11m  p3пampa m  ";
            string str_b = "пma1m3ap1ppa)(**(^$===ra   m";

            //Remving spaces and special symbols
            str_a = String_Refine(str_a);
            str_b = String_Refine(str_b);

            Console.WriteLine(str_a);
            Console.WriteLine(str_b);

            //Checking if anagmram
            if (If_Anagram(str_a, str_b))
                Console.WriteLine("Одна строка является результатом перестановки другой");
            else
                Console.WriteLine("Строки не являются результатом перестановки");

            Console.ReadKey();

        }
    }
}
