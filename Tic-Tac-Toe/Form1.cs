namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char turn = 'X';

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Text = turn.ToString();
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }

            btn9.Enabled = false;
        }
    }
}