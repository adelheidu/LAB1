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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 31);
            button1.Name = "button1";
            button1.Size = new Size(199, 45);
            button1.TabIndex = 0;
            button1.Text = "Инициализировать соединение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 325);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
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
            button3.Size = new Size(154, 29);
            button3.TabIndex = 2;
            button3.Text = "Закрыть соединение";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(1192, 402);
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
            textBox1.Location = new Point(23, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "localhost";
            textBox1.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "5432";
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "postgres";
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 250);
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Просмотр", "Вставка", "Удаление", "Обновление" });
            listBox1.Location = new Point(1192, 325);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(141, 64);
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
            dataGridView1.Location = new Point(493, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(665, 368);
            dataGridView1.TabIndex = 15;
            dataGridView1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1192, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(141, 168);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(1192, 206);
            button5.Name = "button5";
            button5.Size = new Size(141, 32);
            button5.TabIndex = 17;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(927, 413);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "от";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 18;
            textBox6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1047, 413);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "до";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 19;
            textBox7.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 416);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 20;
            label3.Text = "Отбор по году публикации:";
            label3.Visible = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(237, 32);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(236, 368);
            treeView1.TabIndex = 21;
            treeView1.Visible = false;
            treeView1.AfterSelect += treeView1_AfterSelect;
            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1349, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 20);
            toolStripMenuItem1.Text = "Сохранить базу данных";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(164, 20);
            toolStripMenuItem2.Text = "Восстановить базу данных";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 461);
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
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационные системы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}