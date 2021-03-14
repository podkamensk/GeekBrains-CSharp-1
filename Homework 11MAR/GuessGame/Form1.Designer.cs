
namespace GuessGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.try_button = new System.Windows.Forms.Button();
            this.input_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tries_label = new System.Windows.Forms.Label();
            this.Try_label_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_highest = new System.Windows.Forms.Label();
            this.label_lowest = new System.Windows.Forms.Label();
            this.label_mess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_won = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // try_button
            // 
            this.try_button.Location = new System.Drawing.Point(278, 155);
            this.try_button.Name = "try_button";
            this.try_button.Size = new System.Drawing.Size(100, 54);
            this.try_button.TabIndex = 0;
            this.try_button.Text = "ПОПЫТКА #1";
            this.try_button.UseVisualStyleBackColor = true;
            this.try_button.Click += new System.EventHandler(this.try_button_Click);
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(278, 109);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(100, 20);
            this.input_box.TabIndex = 1;
            this.input_box.TextChanged += new System.EventHandler(this.input_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ВЫИГРАЛ ИГР:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            // 
            // Tries_label
            // 
            this.Tries_label.AutoSize = true;
            this.Tries_label.Location = new System.Drawing.Point(263, 243);
            this.Tries_label.Name = "Tries_label";
            this.Tries_label.Size = new System.Drawing.Size(66, 13);
            this.Tries_label.TabIndex = 4;
            this.Tries_label.Text = "ПОПЫТОК:";
            // 
            // Try_label_count
            // 
            this.Try_label_count.AutoSize = true;
            this.Try_label_count.Location = new System.Drawing.Point(368, 243);
            this.Try_label_count.Name = "Try_label_count";
            this.Try_label_count.Size = new System.Drawing.Size(10, 13);
            this.Try_label_count.TabIndex = 5;
            this.Try_label_count.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ДО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ОТ:";
            // 
            // label_highest
            // 
            this.label_highest.AutoSize = true;
            this.label_highest.Location = new System.Drawing.Point(434, 112);
            this.label_highest.Name = "label_highest";
            this.label_highest.Size = new System.Drawing.Size(10, 13);
            this.label_highest.TabIndex = 8;
            this.label_highest.Text = " ";
            // 
            // label_lowest
            // 
            this.label_lowest.AutoSize = true;
            this.label_lowest.Location = new System.Drawing.Point(210, 112);
            this.label_lowest.Name = "label_lowest";
            this.label_lowest.Size = new System.Drawing.Size(10, 13);
            this.label_lowest.TabIndex = 9;
            this.label_lowest.Text = " ";
            // 
            // label_mess
            // 
            this.label_mess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_mess.AutoSize = true;
            this.label_mess.Location = new System.Drawing.Point(293, 78);
            this.label_mess.Name = "label_mess";
            this.label_mess.Size = new System.Drawing.Size(76, 13);
            this.label_mess.TabIndex = 10;
            this.label_mess.Text = "Угадай число";
            this.label_mess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // label_won
            // 
            this.label_won.AutoSize = true;
            this.label_won.Location = new System.Drawing.Point(350, 272);
            this.label_won.Name = "label_won";
            this.label_won.Size = new System.Drawing.Size(10, 13);
            this.label_won.TabIndex = 12;
            this.label_won.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 429);
            this.Controls.Add(this.label_won);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_mess);
            this.Controls.Add(this.label_lowest);
            this.Controls.Add(this.label_highest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Try_label_count);
            this.Controls.Add(this.Tries_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.try_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button try_button;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tries_label;
        private System.Windows.Forms.Label Try_label_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_highest;
        private System.Windows.Forms.Label label_lowest;
        private System.Windows.Forms.Label label_mess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_won;
    }
}

