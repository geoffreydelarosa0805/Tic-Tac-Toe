namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char turn = 'X';
        bool there_is_a_winner = true;
        int turn_count = 0;

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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
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
            turn_count++;

            checkforWinner();
        }

        private void checkforWinner()
        {
            bool there_is_a_winner = false;
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled)) there_is_a_winner = true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled)) there_is_a_winner = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled)) there_is_a_winner = true;
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled)) there_is_a_winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled)) there_is_a_winner = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled)) there_is_a_winner = true;
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled)) there_is_a_winner = true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled)) there_is_a_winner = true;

            if (there_is_a_winner)
            {
                string winner = "";

                Text = turn.ToString();

                if (turn == 'O')
                    winner = "Player X";
                else
                    winner = "Player O";

                MessageBox.Show(winner + " Wins", "Congratulations!");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show(" It's A Draw! Try Another Round.", "WOW! What A Match!");
            }
        }
    }
    
}