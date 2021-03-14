using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form, Viewer
    {

        Presenter presenter;

        public string guess { get => input_box.Text; }
        public string num_games { set => label2.Text = value; }
        public string lowest { set => label_lowest.Text = value; }
        public string highest { set => label_highest.Text = value; }
        public string tries_left { set => Try_label_count.Text = value; }
        public string message { set =>  label_mess.Text = value; }
        public string num_games_won { set =>  label_won.Text = value; }
        public string current_try { get; set; }


        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }



        private void try_button_Click(object sender, EventArgs e)
        {
            presenter.Make_Turn();
            try_button.Text = $"ПОПЫТКА #{current_try}";
            input_box.Text = string.Empty;
            input_box.Focus();
        }

        private void input_box_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
