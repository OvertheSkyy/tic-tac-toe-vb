using System;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class ticTacToe : Form
    {
        bool yourTurn = true;

        public ticTacToe()
        {
            InitializeComponent();
        }

        private void ticTacToe_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not your ordinary tictactoe mate...");
        }

        private void insertBox1_Click(object sender, EventArgs e)
        {
            Button ticTacToe1 = (Button)sender;
            if (yourTurn)
                ticTacToe1.Text = "X";
            else
                ticTacToe1.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe1.Enabled = false;
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
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button ticTacToe14 = (Button)sender;
            if (yourTurn)
                ticTacToe14.Text = "X";
            else
                ticTacToe14.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe14.Enabled = false;
        }
        private void insertBox15_Click(object sender, EventArgs e)
        {
            Button ticTacToe15 = (Button)sender;
            if (yourTurn)
                ticTacToe15.Text = "X";
            else
                ticTacToe15.Text = "O";

            yourTurn = !yourTurn;
            ticTacToe15.Enabled = false;
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
        }
    }
}

