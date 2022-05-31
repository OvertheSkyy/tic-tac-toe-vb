using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        bool yourTurn = true;

        byte yourTurn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void insertBox1_Click_1(object sender, EventArgs e)
        {
            Button ticTacToe1 = (Button)sender;
            if (yourTurn)
                ticTacToe1.Text = "X";
            else
                ticTacToe1.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe1.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox2_Click(object sender, EventArgs e)
        {
            Button ticTacToe2 = (Button)sender;
            if (yourTurn)
                ticTacToe2.Text = "X";
            else
                ticTacToe2.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe2.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox3_Click(object sender, EventArgs e)
        {
            Button ticTacToe3 = (Button)sender;
            if (yourTurn)
                ticTacToe3.Text = "X";
            else
                ticTacToe3.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe3.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox4_Click(object sender, EventArgs e)
        {
            Button ticTacToe4 = (Button)sender;
            if (yourTurn)
                ticTacToe4.Text = "X";
            else
                ticTacToe4.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe4.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox5_Click(object sender, EventArgs e)
        {
            Button ticTacToe5 = (Button)sender;
            if (yourTurn)
                ticTacToe5.Text = "X";
            else
                ticTacToe5.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe5.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox6_Click(object sender, EventArgs e)
        {

            Button ticTacToe6 = (Button)sender;
            if (yourTurn)
                ticTacToe6.Text = "X";
            else
                ticTacToe6.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe6.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox7_Click(object sender, EventArgs e)
        {
            Button ticTacToe7 = (Button)sender;
            if (yourTurn)
                ticTacToe7.Text = "X";
            else
                ticTacToe7.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe7.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox8_Click(object sender, EventArgs e)
        {
            Button ticTacToe8 = (Button)sender;
            if (yourTurn)
                ticTacToe8.Text = "X";
            else
                ticTacToe8.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe8.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox9_Click(object sender, EventArgs e)
        {
            Button ticTacToe9 = (Button)sender;
            if (yourTurn)
                ticTacToe9.Text = "X";
            else
                ticTacToe9.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe9.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox10_Click(object sender, EventArgs e)
        {
            Button ticTacToe10 = (Button)sender;
            if (yourTurn)
                ticTacToe10.Text = "X";
            else
                ticTacToe10.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe10.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox11_Click(object sender, EventArgs e)
        {
            Button ticTacToe11 = (Button)sender;
            if (yourTurn)
                ticTacToe11.Text = "X";
            else
                ticTacToe11.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe11.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox12_Click(object sender, EventArgs e)
        {
            Button ticTacToe12 = (Button)sender;
            if (yourTurn)
                ticTacToe12.Text = "X";
            else
                ticTacToe12.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe12.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox13_Click(object sender, EventArgs e)
        {
            Button ticTacToe13 = (Button)sender;
            if (yourTurn)
                ticTacToe13.Text = "X";
            else
                ticTacToe13.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe13.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox14_Click(object sender, EventArgs e)
        {
            Button ticTacToe14 = (Button)sender;
            if (yourTurn)
                ticTacToe14.Text = "X";
            else
                ticTacToe14.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe14.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox15_Click(object sender, EventArgs e)
        {
            Button ticTacToe14 = (Button)sender;
            if (yourTurn)
                ticTacToe14.Text = "X";
            else
                ticTacToe14.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe14.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox16_Click(object sender, EventArgs e)
        {
            Button ticTacToe16 = (Button)sender;
            if (yourTurn)
                ticTacToe16.Text = "X";
            else
                ticTacToe16.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe16.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox17_Click(object sender, EventArgs e)
        {
            Button ticTacToe17 = (Button)sender;
            if (yourTurn)
                ticTacToe17.Text = "X";
            else
                ticTacToe17.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe17.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox18_Click(object sender, EventArgs e)
        {
            Button ticTacToe18 = (Button)sender;
            if (yourTurn)
                ticTacToe18.Text = "X";
            else
                ticTacToe18.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe18.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox19_Click(object sender, EventArgs e)
        {
            Button ticTacToe19 = (Button)sender;
            if (yourTurn)
                ticTacToe19.Text = "X";
            else
                ticTacToe19.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe19.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox20_Click(object sender, EventArgs e)
        {
            Button ticTacToe20 = (Button)sender;
            if (yourTurn)
                ticTacToe20.Text = "X";
            else
                ticTacToe20.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe20.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox21_Click(object sender, EventArgs e)
        {
            Button ticTacToe21 = (Button)sender;
            if (yourTurn)
                ticTacToe21.Text = "X";
            else
                ticTacToe21.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe21.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox22_Click(object sender, EventArgs e)
        {
            Button ticTacToe22 = (Button)sender;
            if (yourTurn)
                ticTacToe22.Text = "X";
            else
                ticTacToe22.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe22.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox23_Click(object sender, EventArgs e)
        {
            Button ticTacToe23 = (Button)sender;
            if (yourTurn)
                ticTacToe23.Text = "X";
            else
                ticTacToe23.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe23.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox24_Click(object sender, EventArgs e)
        {
            Button ticTacToe24 = (Button)sender;
            if (yourTurn)
                ticTacToe24.Text = "X";
            else
                ticTacToe24.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe24.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void insertBox25_Click(object sender, EventArgs e)
        {
            Button ticTacToe25 = (Button)sender;
            if (yourTurn)
                ticTacToe25.Text = "X";
            else
                ticTacToe25.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe25.Enabled = false;

            yourTurn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool someoneWonTheGame = false;

            if ((insertBox1.Text == insertBox2.Text) && (insertBox2.Text == insertBox3.Text) && (!insertBox1.Enabled))
                someoneWonTheGame = true;
            if ((insertBox2.Text == insertBox3.Text) && (insertBox3.Text == insertBox4.Text) && (!insertBox2.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox3.Text == insertBox4.Text) && (insertBox4.Text == insertBox5.Text) && (!insertBox3.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox6.Text == insertBox7.Text) && (insertBox7.Text == insertBox8.Text) && (!insertBox6.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox7.Text == insertBox8.Text) && (insertBox8.Text == insertBox9.Text) && (!insertBox7.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox8.Text == insertBox9.Text) && (insertBox9.Text == insertBox10.Text) && (!insertBox8.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox11.Text == insertBox12.Text) && (insertBox12.Text == insertBox13.Text) && (!insertBox11.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox12.Text == insertBox13.Text) && (insertBox13.Text == insertBox14.Text) && (!insertBox12.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox13.Text == insertBox14.Text) && (insertBox14.Text == insertBox15.Text) && (!insertBox13.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox16.Text == insertBox17.Text) && (insertBox17.Text == insertBox18.Text) && (!insertBox16.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox17.Text == insertBox18.Text) && (insertBox18.Text == insertBox19.Text) && (!insertBox17.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox18.Text == insertBox19.Text) && (insertBox19.Text == insertBox20.Text) && (!insertBox18.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox21.Text == insertBox22.Text) && (insertBox22.Text == insertBox23.Text) && (!insertBox21.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox22.Text == insertBox23.Text) && (insertBox23.Text == insertBox24.Text) && (!insertBox22.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox23.Text == insertBox24.Text) && (insertBox24.Text == insertBox25.Text) && (!insertBox23.Enabled))
                someoneWonTheGame = true;

            if (someoneWonTheGame)
            {
                string winner = "";
                if (yourTurn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Won the game!", "WINNER!!");
            }
            else
            {
                if (yourTurn_count == 25)
                    MessageBox.Show("No winner!", "DRAW!");
            }
            }
        }
    }

