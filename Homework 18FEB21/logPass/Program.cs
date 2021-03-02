using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logPass
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ПАТАРУШИН
            Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            */


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string login = "root";
            string password = "GeekBrains";
            string login_input;
            string password_input;
            int max_tries = 3;
            int num_tries = 0;
            bool authorizaion = false;

            do
            {
                login_input = string.Empty;
                password_input = string.Empty;
                Console.Write("Введите логин:   ");
                login_input = Console.ReadLine();
                Console.Write("Введите пароль:   ");
                password_input = Console.ReadLine();

                if (login == login_input && password == password_input)
                {
                    Console.WriteLine("Авторизация прошла успешно!");
                    authorizaion = true;
                }
                else
                {
                    num_tries += 1;
                    Console.WriteLine($"Ошибка авторизации! Попыток осталось: {max_tries - num_tries}\n\n\n");
                }
            } while (num_tries < max_tries && authorizaion == false);


            if (authorizaion == true)
            {
                Console.WriteLine("Добро пожаловать");
            }
            else
            {
                Console.WriteLine("Обратитесь к администратору для восстановления доступа");
            }

            Console.ReadLine();

        }
    }
}
