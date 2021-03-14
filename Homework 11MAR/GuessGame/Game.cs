using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Game
    {
        public int max_tries;
        public int num_try;
        public int range_1;
        public int range_2;
        int target;         //загаданное число генерируется при инициализации игры и хранится внутри класса без внешнего доступа
        int guess;          //сюда заносится ответ игрока
        public bool end;    //Флаг, что текущая игра окончена, чтобы презентер вызвал новую instance Game()
        public static int game_count = -1;
        public static int games_won = 0;
        public static string reply = string.Empty;

        //КОНСТРУКТОР КЛАССА С ПЕРЕГРУЗКОЙ
        public Game(int maxtries, int range_start, int range_end, int target_number)
        {
            this.max_tries = maxtries;
            this.num_try = 0;
            this.guess = -1;
            this.end = false;
            this.range_1 = range_start;
            this.range_2 = range_end;
            this.target = target_number;

            Game.game_count += 1;
        }

        public Game(int maxtries, int range_start, int range_end) : this(maxtries, range_start, range_end, 0)  //Конструктор с перегрузками
        {
            Random random = new Random();
            this.target = random.Next(range_start, range_end);
        }

        public Game(int maxtries) : this(maxtries, 1, 100)
        {
        }

        public Game() : this(6)
        {
        }

        public bool RefineInput(string input)
        //ПРОВЕРЯЕТ ПРИНИМАЕМУЮ СТРОКУ НА ЦЕЛОЕ ЧИСЛО ВНУТРИ ДИАПАЗОНА С КОНЦАМИ
        {
            return (Int32.TryParse(input, out this.guess) && this.guess >= this.range_1 && this.guess <= this.range_2);      
        }



        public void GuessTry()
        //ПРОВЕРЯЕТ ПРИНИМАЕМОЕ ЧИСЛО НА ВЫШЕ/НИЖЕ/ВЫИГРАЛ. Обновляет поля end, games_won при попадении, уточняет диапазон при промахе. Обновляет стринговое поле reply
        {
            this.num_try += 1;
            if (this.guess == this.target)   //Угадал
            {
                this.end = true;
                games_won += 1;
                reply = "Молодец! Играй еще!";
            }
            else if (this.num_try >= this.max_tries)   //Не угадал, и попытки кончились
            {
                this.end = true;
                reply = "Ай! Попытки кончились.. Играй заново!";
            }
            else //Не угадал, но попытки остались
            {
                if (this.guess > this.target)
                {
                    this.range_2 = this.guess - 1;
                    reply = "НИЖЕ!";
                }
                else
                {
                    this.range_1 = this.guess + 1;
                    reply = "ВЫШЕ!";
                }
                this.end = false;
            }
        }


    }
}
