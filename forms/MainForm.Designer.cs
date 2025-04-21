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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label3 = new Label();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 28);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(227, 60);
            button1.TabIndex = 0;
            button1.Text = "Инициализировать соединение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 433);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(176, 39);
            button2.TabIndex = 1;
            button2.Text = "Открыть соединение";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(26, 480);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(176, 39);
            button3.TabIndex = 2;
            button3.Text = "Закрыть соединение";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1362, 536);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(161, 43);
            button4.TabIndex = 3;
            button4.Text = "Выполнить команду";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Enabled = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 119);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "localhost";
            textBox1.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 188);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 6;
            textBox3.Text = "5432";
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(26, 260);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 7;
            textBox4.Text = "postgres";
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(26, 333);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 8;
            textBox5.Text = "password";
            textBox5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 548);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 9;
            label1.Text = "Отключено";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(26, 400);
            label2.Name = "label2";
            label2.Size = new Size(227, 20);
            label2.TabIndex = 13;
            label2.Text = "Проверьте введенные данные!";
            label2.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Просмотр", "Вставка", "Удаление", "Обновление" });
            listBox1.Location = new Point(1362, 433);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(161, 84);
            listBox1.TabIndex = 14;
            listBox1.TabStop = false;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(565, 28);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(760, 491);
            dataGridView1.TabIndex = 15;
            dataGridView1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1362, 28);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(161, 223);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(1362, 260);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(161, 43);
            button5.TabIndex = 17;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1059, 551);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "от";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 18;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1197, 551);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "до";
            textBox7.Size = new Size(114, 27);
            textBox7.TabIndex = 19;
            textBox7.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(855, 555);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 20;
            label3.Text = "Отбор по году публикации:";
            label3.Visible = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(271, 28);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(269, 489);
            treeView1.TabIndex = 21;
            treeView1.Visible = false;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 615);
            Controls.Add(treeView1);
            Controls.Add(label3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button5);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационные системы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private Button button5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label3;
        private TreeView treeView1;
    }
}