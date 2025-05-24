using System.Diagnostics;
using System.Text;

namespace FormsGames
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }

        private static List<string> GetWords()
        {
            // Static list of words
            var words = "copil;copac;magazin;alfabet;fruct;ananas;pneumonie;ciulama;castravete;castron;mucegai;funie".ToUpper();

            // Obtain each individual word
            List<string> wordsList = [.. words.Split(';')];

            // Create holder list for final words
            List<string> newWords = [];

            foreach (string word in wordsList)
            {
                // Holder for the final word
                string newWord = string.Empty;

                // For each character except for the last one, expand it
                foreach (var c in word[..^1]) // Everything except the last character
                {
                    newWord += $"{c}   ";
                }

                // The last character
                newWord += $"{word[^1]}";

                // Add the final word to the list
                newWords.Add(newWord);
            }

            return newWords;
        }

        string ExpectedWord { get; set; } = string.Empty;

        string CurrentWord { get; set; } = string.Empty;

        readonly List<string> Letters = [.. "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Select(c => c.ToString())];

        int Attempts { get; set; } = 0;

        private string GetDummyWord()
        {
            // Word holder
            string dummyWord = string.Empty;

            // For each letter except the last, add a placeholder
            foreach (var c in ExpectedWord.Replace("   ", string.Empty)[..^1])
            {
                dummyWord += "_   ";
            }

            // Add the last placeholder
            dummyWord += "_";

            // Return the dummy word
            return dummyWord;
        }

        private void Initialize()
        {
            Attempts = 0;

            panel1.Controls.Clear();

            var i = new Random().Next(GetWords().Count);

            ExpectedWord = GetWords()[i];
            CurrentWord = GetDummyWord();

            foreach (var c in Letters)
            {
                var btn = new Button()
                {
                    Width = 40,
                    Height = 40,
                    Location = new(45 * (Letters.IndexOf(c) % 10), 45 * (Letters.IndexOf(c) / 10)),
                    Text = c.ToString(),
                    Font = new(FontFamily.Families.FirstOrDefault(font => font.Name == "Segoe UI") ?? FontFamily.GenericSansSerif, 12, FontStyle.Bold)
                };
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);
            }

            textBox1.Text = CurrentWord;
            label1.Visible = false;

            label2.Text = "Incercari: 0";

            panel2.Invalidate();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn) CheckAnswer(btn.Text ?? "", btn);
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Hangman_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode.ToString().ToUpper();

            if (Letters.Contains(key))
            {
                Button? btn = null;

                foreach (var control in panel1.Controls)
                {
                    if (control is Button button && button.Text.Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        btn = button;
                        break;
                    }
                }

                if (btn != null) CheckAnswer(key, btn);
            }
        }

        private void CheckAnswer(string key, Button button)
        {
            button.Enabled = false;

            if (ExpectedWord.Contains(key))
            {
                List<int> indexToReplace = [];

                for (int i = 0; i < ExpectedWord.Length; i++)
                {
                    if (ExpectedWord[i].ToString() == key)
                    {
                        indexToReplace.Add(i);
                    }
                }

                var array = CurrentWord.ToCharArray();

                foreach (int i in indexToReplace)
                {
                    if (i >= 0 && i < array.Length)
                    {
                        array[i] = key[0];
                    }
                }

                CurrentWord = new string(array);
                textBox1.Text = CurrentWord;
            }
            else
            {
                Attempts++;
            }

            panel2.Invalidate();

            if (ExpectedWord == CurrentWord || Attempts > 5)
            {
                foreach (var c in panel1.Controls.Cast<Button>())
                {
                    c.Enabled = false;
                }

                label1.Visible = true;
                label1.Text = ExpectedWord == CurrentWord ? "Ai castigat!" : "Ai pierdut!";
            }

            label2.Text = $"Incercari: {Attempts}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.Black, 5);

            e.Graphics.FillRectangle(Brushes.Black, 186, 0, 10, 300);
            e.Graphics.FillRectangle(Brushes.Black, 80, 0, 200, 10);
            e.Graphics.FillRectangle(Brushes.Black, 80, 0, 10, 60);

            var bodyParts = new (Action<Graphics> draw, int minAttempts)[]
            {
                (g => g.DrawEllipse(pen, 65, 60, 40, 40), 1),  // Head
                (g => g.DrawLine(pen, 85, 100, 85, 140), 2),   // Body
                (g => g.DrawLine(pen, 85, 100, 65, 130), 3),   // Left arm
                (g => g.DrawLine(pen, 85, 100, 105, 130), 4),  // Right arm
                (g => g.DrawLine(pen, 85, 140, 65, 170), 5),   // Left leg
                (g => g.DrawLine(pen, 85, 140, 105, 170), 6)   // Right leg
            };

            foreach (var (draw, minAttempts) in bodyParts)
            {
                if (Attempts >= minAttempts)
                {
                    draw(e.Graphics);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Close();
        }
    }
}