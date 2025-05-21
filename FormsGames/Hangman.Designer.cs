namespace FormsGames
{
    partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 130);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 29);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 255);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(383, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(218, 12);
            button2.Name = "button2";
            button2.Size = new Size(159, 23);
            button2.TabIndex = 5;
            button2.Text = "<--- Back to home page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 237);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Hangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Hangman";
            Text = "Hangman";
            Load += Hangman_Load;
            KeyDown += Hangman_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
    }
}