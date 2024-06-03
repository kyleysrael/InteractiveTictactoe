using UserNamespace;

namespace tic_tac_toe
{
    public partial class Main : Form
    {
        int turn = 0;
        TicTacToe ticTacToe = new TicTacToe();
        char getWin;
        string dump;
        int dumpi;

        Button[,] buttons;
        private Administrator admin;

        private void InitializeButtons()
        {
            buttons = new Button[3, 3] { { btn1, btn2, btn3 }, { btn4, btn5, btn6 }, { btn7, btn8, btn9 } };
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ticTacToe.Board[i, j] = ' ';
                }
            }
        }

        private void Normalize()
        {
            for (int i = 0; i < ticTacToe.Board.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToe.Board.GetLength(1); j++)
                {
                    ticTacToe.Board[i, j] = ' ';

                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Text = "";
                }
            }
        }

        public Main(Administrator admin)
        {
            InitializeComponent();
            InitializeButtons();
            InitializeBoard();
            this.admin = admin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn1.BackColor = Color.FromArgb(239, 146, 127);
                btn1.Text = "X";
                btn1.Enabled = false;
                this.ticTacToe.Board[0, 0] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");

                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn1.BackColor = Color.FromArgb(221, 127, 159);
                btn1.Text = "O";
                btn1.Enabled = false;
                this.ticTacToe.Board[0, 0] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn2.BackColor = Color.FromArgb(239, 146, 127);
                btn2.Text = "X";
                btn2.Enabled = false;
                this.ticTacToe.Board[0, 1] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn2.BackColor = Color.FromArgb(221, 127, 159);
                btn2.Text = "O";
                btn2.Enabled = false;
                this.ticTacToe.Board[0, 1] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn3.BackColor = Color.FromArgb(239, 146, 127);
                btn3.Text = "X";
                btn3.Enabled = false;
                this.ticTacToe.Board[0, 2] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn3.BackColor = Color.FromArgb(221, 127, 159);
                btn3.Text = "O";
                btn3.Enabled = false;
                this.ticTacToe.Board[0, 2] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn4.BackColor = Color.FromArgb(239, 146, 127);
                btn4.Text = "X";
                btn4.Enabled = false;
                this.ticTacToe.Board[1, 0] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn4.BackColor = Color.FromArgb(221, 127, 159);
                btn4.Text = "O";
                btn4.Enabled = false;
                this.ticTacToe.Board[1, 0] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn5.BackColor = Color.FromArgb(239, 146, 127);
                btn5.Text = "X";
                btn5.Enabled = false;
                this.ticTacToe.Board[1, 1] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn5.BackColor = Color.FromArgb(221, 127, 159);
                btn5.Text = "O";
                btn5.Enabled = false;
                this.ticTacToe.Board[1, 1] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn6.BackColor = Color.FromArgb(239, 146, 127);
                btn6.Text = "X";
                btn6.Enabled = false;
                this.ticTacToe.Board[1, 2] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn6.BackColor = Color.FromArgb(221, 127, 159);
                btn6.Text = "O";
                btn6.Enabled = false;
                this.ticTacToe.Board[1, 2] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn7.BackColor = Color.FromArgb(239, 146, 127);
                btn7.Text = "X";
                btn7.Enabled = false;
                this.ticTacToe.Board[2, 0] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn7.BackColor = Color.FromArgb(221, 127, 159);
                btn7.Text = "O";
                btn7.Enabled = false;
                this.ticTacToe.Board[2, 0] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn8.BackColor = Color.FromArgb(239, 146, 127);
                btn8.Text = "X";
                btn8.Enabled = false;
                this.ticTacToe.Board[2, 1] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn8.BackColor = Color.FromArgb(221, 127, 159);
                btn8.Text = "O";
                btn8.Enabled = false;
                this.ticTacToe.Board[2, 1] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.turn % 2 == 0)
            {
                btn9.BackColor = Color.FromArgb(239, 146, 127);
                btn9.Text = "X";
                btn9.Enabled = false;
                this.ticTacToe.Board[2, 2] = 'x';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'x')
                {
                    MessageBox.Show("X wins!");
                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.Normalize();
                }
            }
            else
            {
                btn9.BackColor = Color.FromArgb(221, 127, 159);
                btn9.Text = "O";
                btn9.Enabled = false;
                this.ticTacToe.Board[2, 2] = 'o';

                this.getWin = this.ticTacToe.IsWinner(this.ticTacToe.Board, turn);
                if (this.getWin == 'o')
                {
                    MessageBox.Show("O wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.Normalize();
                }
            }

            this.turn++;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Normalize();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public abstract class BoardGame
        {
            protected char[,] Board;

            public abstract char IsWinner(char[,] letter, int num);
        }

        public class TicTacToe : BoardGame
        {
            public char[,] Board { get; private set; }
            public TicTacToe()
            {
                Board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            }

            public override char IsWinner(char[,] letter, int num)
            {
                if (num > 2)
                {
                    if ((letter[0, 0] == letter[0, 1]) && (letter[0, 1] == letter[0, 2]))
                    {
                        return letter[0, 0];
                    }
                    else if ((letter[1, 0] == letter[1, 1]) && (letter[1, 1] == letter[1, 2]))
                    {
                        return letter[1, 0];
                    }
                    else if ((letter[2, 0] == letter[2, 1]) && (letter[2, 1] == letter[2, 2]))
                    {
                        return letter[2, 0];
                    }
                    else if ((letter[0, 0] == letter[1, 0]) && (letter[1, 0] == letter[2, 0]))
                    {
                        return letter[0, 0];
                    }
                    else if ((letter[0, 1] == letter[1, 1]) && (letter[1, 1] == letter[2, 1]))
                    {
                        return letter[0, 1];
                    }
                    else if ((letter[0, 2] == letter[1, 2]) && (letter[1, 2] == letter[2, 2]))
                    {
                        return letter[0, 2];
                    }
                    else if ((letter[0, 0] == letter[1, 1]) && (letter[1, 1] == letter[2, 2]))
                    {
                        return letter[0, 0];
                    }
                    else if ((letter[0, 2] == letter[1, 1]) && (letter[1, 1] == letter[2, 0]))
                    {
                        return letter[0, 2];
                    }
                    else
                    {
                        return 'n';
                    }
                }
                else
                {
                    return 'n';
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm(admin).Show();
        }
    }
}