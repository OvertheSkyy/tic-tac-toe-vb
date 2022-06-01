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
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox2_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
           
        }

        private void insertBox3_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox4_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox5_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox6_Click(object sender, EventArgs e)
        {

            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox7_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox8_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox9_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox10_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox11_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox12_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox13_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox14_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox15_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox16_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox17_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox18_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox19_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox20_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
           
        }

        private void insertBox21_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox22_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox23_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
            
        }

        private void insertBox24_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
           
        }

        private void insertBox25_Click(object sender, EventArgs e)
        {
            Button ticTacToe = (Button)sender;
            if (yourTurn)
                ticTacToe.Text = "X";
            else
                ticTacToe.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe.Enabled = false;

            yourTurn_count++;

            checkForWinner();
       
        }

        private void checkForWinner()
        {
            bool someoneWonTheGame = false;

            //horizontal matches
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

            //vertical matches 
            else if ((insertBox1.Text == insertBox6.Text) && (insertBox6.Text == insertBox11.Text) && (!insertBox1.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox6.Text == insertBox11.Text) && (insertBox11.Text == insertBox16.Text) && (!insertBox6.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox11.Text == insertBox16.Text) && (insertBox16.Text == insertBox21.Text) && (!insertBox11.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox2.Text == insertBox7.Text) && (insertBox7.Text == insertBox12.Text) && (!insertBox2.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox7.Text == insertBox12.Text) && (insertBox12.Text == insertBox17.Text) && (!insertBox17.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox12.Text == insertBox17.Text) && (insertBox17.Text == insertBox22.Text) && (!insertBox12.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox3.Text == insertBox8.Text) && (insertBox8.Text == insertBox13.Text) && (!insertBox3.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox8.Text == insertBox13.Text) && (insertBox13.Text == insertBox18.Text) && (!insertBox8.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox13.Text == insertBox18.Text) && (insertBox18.Text == insertBox23.Text) && (!insertBox13.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox4.Text == insertBox9.Text) && (insertBox9.Text == insertBox14.Text) && (!insertBox4.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox9.Text == insertBox14.Text) && (insertBox14.Text == insertBox19.Text) && (!insertBox9.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox14.Text == insertBox19.Text) && (insertBox19.Text == insertBox24.Text) && (!insertBox14.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox5.Text == insertBox10.Text) && (insertBox10.Text == insertBox15.Text) && (!insertBox5.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox10.Text == insertBox15.Text) && (insertBox15.Text == insertBox20.Text) && (!insertBox10.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox15.Text == insertBox20.Text) && (insertBox20.Text == insertBox25.Text) && (!insertBox15.Enabled))
                someoneWonTheGame = true;

            //diagonal matches
            else if ((insertBox1.Text == insertBox7.Text) && (insertBox7.Text == insertBox13.Text) && (!insertBox1.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox7.Text == insertBox13.Text) && (insertBox13.Text == insertBox19.Text) && (!insertBox7.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox13.Text == insertBox19.Text) && (insertBox19.Text == insertBox25.Text) && (!insertBox13.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox2.Text == insertBox8.Text) && (insertBox8.Text == insertBox14.Text) && (!insertBox2.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox8.Text == insertBox14.Text) && (insertBox14.Text == insertBox20.Text) && (!insertBox8.Enabled))
                someoneWonTheGame = true;
            else if ((insertBox3.Text == insertBox9.Text) && (insertBox9.Text == insertBox15.Text) && (!insertBox3.Enabled))
                someoneWonTheGame = true;
            


            if (someoneWonTheGame)
            {

                disableInsertBox();

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
        
        private void disableInsertBox()
        {
            try
            {
                insertBox1.Enabled = false;
                insertBox2.Enabled = false;
                insertBox3.Enabled = false;
                insertBox4.Enabled = false;
                insertBox5.Enabled = false;
                insertBox6.Enabled = false;
                insertBox7.Enabled = false;
                insertBox8.Enabled = false;
                insertBox9.Enabled = false;
                insertBox10.Enabled = false;
                insertBox11.Enabled = false;
                insertBox12.Enabled = false;
                insertBox13.Enabled = false;
                insertBox14.Enabled = false;
                insertBox15.Enabled = false;
                insertBox16.Enabled = false;
                insertBox17.Enabled = false;
                insertBox18.Enabled = false;
                insertBox19.Enabled = false;
                insertBox20.Enabled = false;
                insertBox21.Enabled = false;
                insertBox22.Enabled = false;
                insertBox23.Enabled = false;
                insertBox24.Enabled = false;
                insertBox25.Enabled = false;
            }
            catch { }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            yourTurn = true;
            yourTurn_count = 0;
            try
            {
                insertBox1.Enabled = true;
                insertBox2.Enabled = true;
                insertBox3.Enabled = true;
                insertBox4.Enabled = true;
                insertBox5.Enabled = true;
                insertBox6.Enabled = true;
                insertBox7.Enabled = true;
                insertBox8.Enabled = true;
                insertBox9.Enabled = true;
                insertBox10.Enabled = true;
                insertBox11.Enabled = true;
                insertBox12.Enabled = true;
                insertBox13.Enabled = true;
                insertBox14.Enabled = true;
                insertBox15.Enabled = true;
                insertBox16.Enabled = true;
                insertBox17.Enabled = true;
                insertBox18.Enabled = true;
                insertBox19.Enabled = true;
                insertBox20.Enabled = true;
                insertBox21.Enabled = true;
                insertBox22.Enabled = true;
                insertBox23.Enabled = true;
                insertBox24.Enabled = true;
                insertBox25.Enabled = true;

                insertBox1.Text = "";
                insertBox2.Text = "";
                insertBox3.Text = "";
                insertBox4.Text = "";
                insertBox5.Text = "";
                insertBox6.Text = "";
                insertBox7.Text = "";
                insertBox8.Text = "";
                insertBox9.Text = "";
                insertBox10.Text = "";
                insertBox11.Text = "";
                insertBox12.Text = "";
                insertBox13.Text = "";
                insertBox14.Text = "";
                insertBox15.Text = "";
                insertBox16.Text = "";
                insertBox17.Text = "";
                insertBox18.Text = "";
                insertBox19.Text = "";
                insertBox20.Text = "";
                insertBox21.Text = "";
                insertBox22.Text = "";
                insertBox23.Text = "";
                insertBox24.Text = "";
                insertBox25.Text = "";
            }
            catch { }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}