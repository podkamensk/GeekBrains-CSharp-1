using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
  

namespace Messages
{
    static class Messages
    {
        static public void Print_Limit(string str, int limit)
        //prints out all words which are withing lenght limit
        {
            Regex lim = new Regex("[A-zёЁА-я0-9]{1,}");
            MatchCollection matches = lim.Matches(str);

           // Console.WriteLine("{0} matches found\n", matches.Count);

            foreach (Match match in matches)
            {
                if (match.ToString().Length <= limit)
                    Console.WriteLine(match.ToString());
            }
        } 

        static public string Remove_By_End_Char(string str, char endchar)
        //returns string with all the words ending with specified char removed from the input string
        {
            Regex exclusion = new Regex("[A-zёЁА-я0-9]{0,}[" + endchar.ToString() + "][ »«.,/\"'!?;:*<>()]");  //Пихаем char в Regex. \b - Word Boundary - работает только для латиницы. С кириллицей придется страдать следующим способом:
            str += ' '; //adding one space to catch the last word 
            MatchCollection matches = exclusion.Matches(str);

            int space_counter = 0;

            foreach (Match match in matches)           //Для каждого совпадения:
            {
                string space_string = string.Empty;
                str = str.Remove(match.Index, match.Length - 1);           //1. Исключаем слово-совпадение из строки
                space_counter += match.Length - 1;                         //2. Увеличиваем счетчик пробелов на длину совпадения -1
                for (int i = 0; i < match.Length - 1; i += 1)
                {
                    space_string += ' ';
                }
                str = str.Insert(0, space_string);                         //3. Вставляем в начало строки пробельную заглушку, чтобы индексы матчей не поехали
            }
            str = str.Remove(0, space_counter);                         //В конце убираем заглушку в начале и один ранее добавленный пробел в конце
            str = str.Remove(str.Length -1, 1);

            return str;

        }

        static public string The_Longest_Word(string str)
        //Returns the longest word in the string
        {
            string the_longest = string.Empty;
            int max_length = 0;
            Regex lim = new Regex("[A-zёЁА-я0-9]{1,}");
            MatchCollection matches = lim.Matches(str);

            foreach (Match match in matches)
            {
                if (max_length < match.Length)
                {
                    max_length = match.Length;
                    the_longest = match.ToString();
                }
            }

            return the_longest;
        }
        static public string String_Of_The_Longest(string str)
        //Returns string of the longest word using StringBuilder
        {
            StringBuilder str_to_bld = new StringBuilder();

            int max_length = 0;
            Regex lim = new Regex("[A-zёЁА-я0-9]{1,}");
            MatchCollection matches = lim.Matches(str);

            foreach (Match match in matches)
            {
                if (max_length < match.Length)
                {
                    str_to_bld.Clear();
                    max_length = match.Length;
                }
                if (max_length == match.Length)
                {
                    str_to_bld.Append(match.ToString() + " ");
                }
            }

            str_to_bld.Remove(str_to_bld.Length - 1, 1);
            return str_to_bld.ToString();
        }
        





    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения,  которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него 
            передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое 
            из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
            */

            string filedir = "message.txt";
            string message = File.ReadAllText(filedir);

            //Print out the message red from a file
            Console.WriteLine(message);
            Console.WriteLine("\n\n");

            //Test print with wordlength limit
            Messages.Print_Limit(message, 6);
            Console.WriteLine("\n\n");

            //Test Print Remove_By_End_Char
            string new_string = Messages.Remove_By_End_Char(message, 'е');
            Console.WriteLine(new_string);
            Console.WriteLine("\n\n");

            //Test Print The Longest Word
            Console.WriteLine(Messages.The_Longest_Word(message));
            Console.WriteLine("\n\n");

            //Test String Of The Longest
            Console.WriteLine(Messages.String_Of_The_Longest(message));
            Console.WriteLine("\n\n");

            Console.ReadLine();
        }
    }
}
