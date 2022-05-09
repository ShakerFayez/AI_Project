using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        bool turn = true;//true = x turn, false = y turn
        bool there_is_a_winner = false;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(turn is true)
            {
                button1.Text = "X";
                button1.BackColor = Color.Red;
                turn = false;
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "O";
                button1.BackColor = Color.Blue;
                turn = true;
                button1.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button7.Text = "X";
                button7.BackColor = Color.Red;
                turn = false;
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                button7.BackColor = Color.Blue;
                turn = true;
                button7.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button4.Text = "X";
                button4.BackColor = Color.Red;
                turn = false;
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "O";
                button4.BackColor = Color.Blue;
                turn = true;
                button4.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button9.Text = "X";
                button9.BackColor = Color.Red;
                turn = false;
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "O";
                button9.BackColor = Color.Blue;
                turn = true;
                button9.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button6.Text = "X";
                button6.BackColor = Color.Red;
                turn = false;
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                button6.BackColor = Color.Blue;
                turn = true;
                button6.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button3.Text = "X";
                button3.BackColor = Color.Red;
                turn = false;
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                button3.BackColor = Color.Blue;
                turn = true;
                button3.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button8.Text = "X";
                button8.BackColor = Color.Red;
                turn = false;
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                button8.BackColor = Color.Blue;
                turn = true;
                button8.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button5.Text = "X";
                button5.BackColor = Color.Red;
                turn = false;
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                button5.BackColor = Color.Blue;
                turn = true;
                button5.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn is true)
            {
                button2.Text = "X";
                button2.BackColor = Color.Red;
                turn = false;
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "O";
                button2.BackColor = Color.Blue;
                turn = true;
                button2.Enabled = false;
            }
            turn_count++;
            Check_for_winner();
            Check_Draw();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is created under the creative License of ME!! ", "About");
        }

        private void contactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Via E-mail: Blabla@Blablabla.com\nVia phone: 01234567890", "Contact developer");
        }
        private void Check_Draw()
        {
            if (turn_count == 9 && !there_is_a_winner) 
            {
                    MessageBox.Show("Draw", "There's a Draw");
                
            }
        }
        private void Check_for_winner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                MessageBox.Show("Player " + button1.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("Player " + button4.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("Player " + button7.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("Player " + button1.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("Player " + button2.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("Player " + button3.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("Player " + button1.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("Player " + button3.Text + " is the winner", "There's a winner");
                there_is_a_winner = true;
            }
            Disable();
        }
        private void Disable()
        {
            if (there_is_a_winner)
            {
                try
                {
                    {
                        foreach (Control c in Controls)
                        {
                            Button b = (Button)c;
                            b.Enabled = false;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
