namespace FormsGames
{
    partial class TicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            reset = new Button();
            backToHomePage = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 0, 0);
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(118, 12);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 0, 0);
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(224, 12);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 0, 0);
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = "";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 118);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 0, 0);
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.Text = "";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(118, 118);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.Text = "";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(224, 118);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 0, 0);
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.Text = "";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 224);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 0, 0, 0);
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.Text = "";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(118, 224);
            button8.Name = "button8";
            button8.Padding = new Padding(5, 0, 0, 0);
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.Text = "";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Fluent Icons", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(224, 224);
            button9.Name = "button9";
            button9.Padding = new Padding(5, 0, 0, 0);
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.Text = "";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 46);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(51, 13);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 1;
            label2.Text = "Tie!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "";
            // 
            // reset
            // 
            reset.Location = new Point(249, 382);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 10;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += button11_Click;
            // 
            // backToHomePage
            // 
            backToHomePage.Location = new Point(12, 382);
            backToHomePage.Name = "backToHomePage";
            backToHomePage.Size = new Size(145, 23);
            backToHomePage.TabIndex = 11;
            backToHomePage.Text = "<--- Back to home page";
            backToHomePage.UseVisualStyleBackColor = true;
            backToHomePage.Click += button10_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 415);
            Controls.Add(backToHomePage);
            Controls.Add(reset);
            Controls.Add(panel1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TicTacToe";
            Text = "TicTacToe";
            Load += TicTacToe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button reset;
        private Button backToHomePage;
    }
}