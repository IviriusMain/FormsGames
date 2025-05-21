namespace FormsGames
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private const string STRING_X = "";
        private const string STRING_O = "";
        private const string STRING_EMPTY = "";

        List<Button> ButtonList = [];

        bool IsX { get; set; } = true;

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtain button from sender
            var btn = (Button)sender;

            // Mark with X or O depending on whose turn it is
            if (btn.Text == STRING_EMPTY)
            {
                btn.Text = IsX ? STRING_X : STRING_O;
                btn.Enabled = false;
            }

            // Invert turns
            IsX = !IsX;

            // Check if there are any empty squares
            var hasEmptySquare = ButtonList.Any(button => button.Text == STRING_EMPTY);

            // Winner variables
            bool xWins = false;
            bool oWins = false;

            // List of cells for each case
            List<Button> cells;

            // Rows
            for (int i = 0; i < 3; i++)
            {
                // Populate cells with the current row
                cells = [ButtonList[0 + 3 * i], ButtonList[1 + 3 * i], ButtonList[2 + 3 * i]];
                RunAllChecks();

                // If someone has won, return
                if ((xWins || oWins) && xWins != oWins) return;
            }

            // Columns
            for (int i = 0; i < 3; i += 1)
            {
                // Populate cells with the current column
                cells = [ButtonList[0 + i], ButtonList[3 + i], ButtonList[6 + i]];
                RunAllChecks();

                // If someone has won, return
                if ((xWins || oWins) && xWins != oWins) return;
            }

            // Diagonal #1
            cells = [ButtonList[0], ButtonList[4], ButtonList[8]];
            RunAllChecks();
            if ((xWins || oWins) && xWins != oWins) return;

            // Diagonal #2
            cells = [ButtonList[2], ButtonList[4], ButtonList[6]];
            RunAllChecks();
            if ((xWins || oWins) && xWins != oWins) return;

            // If there aren't empty squares, return a tie
            if (!hasEmptySquare)
            {
                panel1.Visible = true;
                label2.Text = "Tie!";
                foreach (Button button in ButtonList)
                {
                    button.Enabled = false;
                }
            }

            // Method to check who won
            void RunAllChecks()
            {
                // X won
                xWins = cells.All(button => button.Text == STRING_X);

                // Y won
                oWins = cells.All(button => button.Text == STRING_O);

                // Return winner
                if ((xWins || oWins) && xWins != oWins) RunWinner(xWins);
            }
        }

        private void RunWinner(bool xWins)
        {
            panel1.Visible = true;
            label2.Text = $"{(xWins ? "X" : "O")} wins!";
            foreach (Button button in ButtonList)
            {
                button.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Reset the game
            foreach (Button button in ButtonList)
            {
                button.Text = STRING_EMPTY;
                button.Enabled = true;
            }
            panel1.Visible = false;
            IsX = true;
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            ButtonList = [.. Controls.OfType<Button>().Where(b => b.Name.Contains("button")).OrderBy(b => b.Name) ];
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }
    }
}