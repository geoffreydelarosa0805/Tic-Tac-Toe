namespace Tic_Tac_Toe
{
    public partial class Form_TicTacToeGame : Form
    {
        char turn = 'X';
        int turn_count = 0;

        public Form_TicTacToeGame()
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

            turn_count++;
            btn1.Enabled = false;

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

            turn_count++;
            btn2.Enabled = false;

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

            turn_count++;
            btn3.Enabled = false;

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

            turn_count++;
            btn4.Enabled = false;

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

            turn_count++;
            btn5.Enabled = false;

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

            turn_count++;
            btn6.Enabled = false;

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

            turn_count++;
            btn7.Enabled = false;

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

            turn_count++;
            btn8.Enabled = false;

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

            turn_count++;
            btn9.Enabled = false;

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

                if (turn == 'X')
                    winner = "Player O";
                else
                    winner = "Player X";

                MessageBox.Show(winner + " Wins", "Congratulations!");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show(" It's A Draw! Try Another Round.", "WOW! What A Match!");
            }
        }

        private void MnStp_Restart_Click(object sender, EventArgs e)
        {
            turn_count = 0;

            try
            {
                foreach (Control b in Controls)
                {
                    Button a = (Button)b;
                    a.Enabled = true;
                    a.Text = "";
                }
            }
            catch
            {

            }
        }

        private void MnStp_Continue_Click(object sender, EventArgs e)
        {
            MnStp_Continue.Select();
        }

        private void MnStp_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a game in which two players seek in alternate turns to complete a row, a column, or a diagonal with either three O's or three X's drawn in the spaces of a grid of nine squares.", "Tic Tac Toe Game");
        }
    } 
}