using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GuessGame
{
    public class Presenter
    {
        Game game;
        Form1 view;

        public Presenter(Form1 view)
        {
            this.view = view;
            game = New_Game();
            Update_Form(game, view);
        }

        static public Game New_Game()
        //Запускает новую игру, иницализируя и возвращая новый экземляр класса Game
        {
            Game gm = new Game(10);
            return gm;
        }

        static public void Update_Form(Game gm, Form1 vm)
        {
            vm.num_games_won = Game.games_won.ToString();
            vm.num_games = Game.game_count.ToString();
            vm.message = Game.reply;
            vm.tries_left = Convert.ToString(gm.max_tries - gm.num_try);
            vm.lowest = gm.range_1.ToString();
            vm.highest = gm.range_2.ToString();
            vm.current_try = (gm.num_try + 1).ToString();
        }

        public void Make_Turn()
        {
            if (this.game.RefineInput(this.view.guess))
            {
                this.game.GuessTry();
                Update_Form(this.game, this.view);
                if (this.game.end)
                {
                    game = New_Game();
                    Update_Form(this.game, this.view);
                }
            }
        } 
    }
}
