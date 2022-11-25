using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char Turn = 'O';
        int x_wins = 0, o_wins = 0;
        byte moves = 0;
        bool Easter_Egg = false;
        public bool Win(object sender) { 
            Button b1=sender as Button;
            return (
               ( b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "")||
                (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "")||
                (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""));
        }
        public Form1()
        {
            MessageBox.Show("The first Move Will be Considered 'O'\n"+"Enjoy The Game\n");
            InitializeComponent();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moves = 0;
            Turn = 'O';
            tableLayoutPanel1.Enabled = true;
            /// reseting the text of all the buttons
            b1.Text = ""; 
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            /// reseting the Colors of all the buttons
            b1.BackColor= Color.White;
            b2.BackColor= Color.White;
            b3.BackColor= Color.White;
            b4.BackColor= Color.White;
            b5.BackColor= Color.White;
            b6.BackColor= Color.White;
            b7.BackColor= Color.White;
            b8.BackColor= Color.White;
            b9.BackColor= Color.White;
            ///enabling all the buttons again
            b1.Enabled=true;
            b2.Enabled=true;
            b3.Enabled=true;
            b4.Enabled=true;
            b5.Enabled=true;
            b6.Enabled=true;
            b7.Enabled=true;
            b8.Enabled=true;
            b9.Enabled=true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Mostafa Mahmoud. ");

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button bt=sender as Button;
            if (Turn == 'O')
            {
                bt.BackColor = Color.DarkOrange;
                bt.Text = "O";
                bt.Enabled = false;
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show((Turn.ToString().ToUpper() + " Wins !!"));
                    o_wins++;
                    OCounter.Text = o_wins.ToString();
                    tableLayoutPanel1.Enabled = false;
                }
                else if (moves == 8)
                {
                    MessageBox.Show("Draw :D");
                    tableLayoutPanel1.Enabled = false;
                }

                Turn = 'X';

            }
            else {
                bt.BackColor = Color.Wheat;
                bt.Text = "X";
                bt.Enabled=false;
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show((Turn.ToString().ToUpper() + " Wins !!"));
                    x_wins++;
                    XCounter.Text=x_wins.ToString();
                    tableLayoutPanel1.Enabled = false;
                }
                else if (moves == 8) {
                    MessageBox.Show("Draw :D");
                    tableLayoutPanel1.Enabled = false;
                }
                Turn = 'O';
            }
            moves++;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void XCounter_Click(object sender, EventArgs e)
        {
            XCounter.Text = "0";
            x_wins = 0;
            if (!Easter_Egg) {
                MessageBox.Show("You Just Caught Me XD\n" + "You can use this button to reset the Counter ");
                Easter_Egg = true;
            }
        }

        private void OCounter_Click(object sender, EventArgs e)
        {
            OCounter.Text = "0";
            o_wins = 0;
            if (!Easter_Egg) {
                MessageBox.Show("You Just Caught Me XD\n" + "You can use this button to reset the Counter ");
                Easter_Egg = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
