namespace LAB1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 21);
            button1.Name = "button1";
            button1.Size = new Size(193, 29);
            button1.TabIndex = 0;
            button1.Text = "Инициализировать соединение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 325);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 1;
            button2.Text = "Открыть соединение";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(23, 360);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 2;
            button3.Text = "Закрыть соединение";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(244, 446);
            button4.Name = "button4";
            button4.Size = new Size(141, 32);
            button4.TabIndex = 3;
            button4.Text = "Выполнить команду";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "localhost";
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "books";
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "5432";
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "postgres";
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 269);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            textBox5.Text = "password";
            textBox5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 411);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 9;
            label1.Text = "Отключено";
            label1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(244, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(688, 405);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(644, 446);
            button5.Name = "button5";
            button5.Size = new Size(141, 32);
            button5.TabIndex = 11;
            button5.Text = "Вставить";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(791, 446);
            button6.Name = "button6";
            button6.Size = new Size(141, 32);
            button6.TabIndex = 12;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(23, 300);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 13;
            label2.Text = "Проверьте введенные данные!";
            label2.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационные системы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button5;
        private Button button6;
        private Label label2;
    }
}