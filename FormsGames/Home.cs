namespace FormsGames
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TicTacToe().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Hangman().Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Battleship().Show();
            Close();
        }
    }
}