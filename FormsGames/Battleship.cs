namespace FormsGames
{
    public partial class Battleship : Form
    {
        private readonly List<Button> clickedButtons = [];

        private readonly List<Button> redButtonsWithBoats = [];

        private readonly List<Button> blueButtonsWithBoats = [];

        private readonly Random random = new();

        bool IsPlayer1Turn { get; set; } = true;

        public Battleship() => InitializeComponent();

        private void Battleship_Load(object sender, EventArgs e) => InitializeGame();

        private void button1_Click(object sender, EventArgs e) => InitializeGame(); // Restart

        private void Battleship_Click(object? sender, EventArgs e)
        {
            if (clickedButtons.Contains((Button?)sender ?? new())) return;
            clickedButtons.Add((Button?)sender ?? new());
            UpdateGame();
        }

        private async void UpdateGame()
        {
            // Check if someone has won
            if (redButtonsWithBoats.All(clickedButtons.Contains) || blueButtonsWithBoats.All(clickedButtons.Contains))
            {
                // Check if blue has won (otherwise, red won as there's no tie in this game)
                bool blueWon = redButtonsWithBoats.All(clickedButtons.Contains);
                clickedButtons.Clear();

                // Restore all buttons
                foreach (Button btn in panel1.Controls)
                {
                    btn.Enabled = true;
                    clickedButtons.Add(btn);
                }
                foreach (Button btn in panel2.Controls)
                {
                    btn.Enabled = true;
                    clickedButtons.Add(btn);
                }

                // Show all buttons
                await Task.Delay(50);
                LoadButtonStates(false);
                await Task.Delay(50);

                // Show winner
                MessageBox.Show(blueWon ? "BLUE WINS!" : "RED WINS!");

                // Restart game
                InitializeGame();
            }
            else
            {
                // Invert turns
                IsPlayer1Turn = !IsPlayer1Turn;

                // Display new turns
                label1.Text = $"RED{(!IsPlayer1Turn ? " - ATTACK!" : string.Empty)}";
                label18.Text = $"BLUE{(IsPlayer1Turn ? " - ATTACK!" : string.Empty)}";

                LoadButtonStates(true);
            }
        }

        private void LoadButtonStates(bool allowButtonDisabling)
        {
            foreach (Button button in panel1.Controls)
            {
                LoadButtonStatesForIndividualButton(button, true, allowButtonDisabling);
            }
            foreach (Button button in panel2.Controls)
            {
                LoadButtonStatesForIndividualButton(button, false, allowButtonDisabling);
            }
        }

        private void LoadButtonStatesForIndividualButton(Button button, bool isRed, bool allowButtonDisabling)
        {
            if (allowButtonDisabling)
            {
                button.BackColor =
                    // Player 1's turn
                    (isRed ? IsPlayer1Turn : !IsPlayer1Turn) ?

                    // If the button hasn't been clicked, set it as red
                    !clickedButtons.Contains(button) ? isRed ? Color.FromArgb(255, 50, 50) : Color.FromArgb(50, 50, 255) :

                    // If it has been clicked and there's no boat, set it as light red/blue
                    !(isRed ? redButtonsWithBoats : blueButtonsWithBoats).Contains(button) ? isRed ? Color.FromArgb(255, 200, 200) : Color.FromArgb(200, 200, 255)

                    // If it has been clicked and there's a boat, set it as gray
                    : Color.FromArgb(50, 50, 50)

                    // If it's not player 1's turn, set it to white
                    : Color.White;
            }
            else
            {
                button.BackColor =
                    // If the button hasn't been clicked, set it as red
                    !clickedButtons.Contains(button) ? isRed ? Color.FromArgb(255, 50, 50) : Color.FromArgb(50, 50, 255) :

                    // If it has been clicked and there's no boat, set it as light red/blue
                    !(isRed ? redButtonsWithBoats : blueButtonsWithBoats).Contains(button) ? isRed ? Color.FromArgb(255, 200, 200) : Color.FromArgb(200, 200, 255)

                    // If it has been clicked and there's a boat, set it as gray
                    : Color.FromArgb(50, 50, 50);
            }
            button.Text =
                // If the button hasn't been clicked, set the content to an empty string
                !clickedButtons.Contains(button) ? string.Empty :

                // If the button has been clicked and there's no boat, set the content to a cross
                !(isRed ? redButtonsWithBoats : blueButtonsWithBoats).Contains(button) ? ""

                // If the button has been clicked and there's a boat, set the content to a target
                : "";
            button.ForeColor =
                // If the button hasn't been clicked, set the foreground color to black
                !clickedButtons.Contains(button) ? Color.Black :

                // If the button has been clicked and there's no boat, set the foreground color to black
                !(isRed ? redButtonsWithBoats : blueButtonsWithBoats).Contains(button) ? Color.Black

                // If the button has been clicked and there's a boat, set the foreground color to light red/blue
                : isRed ? Color.FromArgb(255, 200, 200) : Color.FromArgb(200, 200, 255);
            if (allowButtonDisabling) button.Enabled = isRed ? IsPlayer1Turn : !IsPlayer1Turn;
        }

        private void InitializeGame()
        {
            // Reset everything to default
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            IsPlayer1Turn = true;
            clickedButtons.Clear();
            redButtonsWithBoats.Clear();
            blueButtonsWithBoats.Clear();

            int ships = random.Next(4, 8);

            // Red buttons
            CreateButtons(true, ships);

            // Blue buttons
            CreateButtons(false, ships);
        }

        private void CreateButtons(bool isRed, int ships)
        {
            // Grid
            for (int i = 0; i < 16; i++)
            {
                var button = new Button
                {
                    Width = 75,
                    Height = 75,
                    Location = new Point(i % 4 * 83, i / 4 * 83),
                    Enabled = isRed,
                    BackColor = isRed ? Color.FromArgb(255, 50, 50) : Color.White,
                    Padding = new(2, 0, 0, 0),
                    Font = new Font("Segoe Fluent Icons", 36, FontStyle.Regular)
                };
                (isRed ? panel1 : panel2).Controls.Add(button);
                button.Click += Battleship_Click;
            }

            // Ships
            for (int j = 0; j <= ships; j++)
            {
                int f = random.Next(16);
                while ((isRed ? redButtonsWithBoats : blueButtonsWithBoats).Contains((isRed ? panel1 : panel2).Controls[f]))
                {
                    f = random.Next(16);
                }
                (isRed ? redButtonsWithBoats : blueButtonsWithBoats).Add((Button)(isRed ? panel1 : panel2).Controls[f]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}