using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LAB1
{
    public partial class Form1 : Form
    {

        NpgsqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString =
                "Server=" + textBox1.Text +
                ";Database=" + textBox2.Text +
                ";Port=" + textBox3.Text +
                ";Username=" + textBox4.Text +
                ";Password=" + textBox5.Text + ";";


            //connection = new NpgsqlConnection(connectionString);
            //connection.Open();

            checkFields();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button3.Enabled = false;
            button2.Enabled = true;
            button2.Focus();
            label1.Text = "Отключено";
            richTextBox1.Visible = false;
            richTextBox1.Clear();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            using NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM books;", connection);


            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string record = $"ID: {reader["book_id"]}\n" +
                                       $"Название: {reader["title"]}\n" +
                                       $"Автор: {reader["author"]}\n" +
                                       $"Год: {reader["publication_year"]}\n" +
                                       $"Жанр: {reader["genre"]}\n" +
                                       $"Издательство: {reader["publisher"]}\n" +
                                       $"Цена: {reader["price"]}\n" +
                                       $"Описание: {reader["description"]}\n" +
                                       new string('-', 50) + "\n";

                richTextBox1.AppendText(record);
            }

        }

        private void checkFields()
        {
            string connectionString =
                "Server=" + textBox1.Text +
                ";Database=" + textBox2.Text +
                ";Port=" + textBox3.Text +
                ";Username=" + textBox4.Text +
                ";Password=" + textBox5.Text + ";";
            try
            {
                connection = new NpgsqlConnection(connectionString);
                try
                {
                    connection.Open();

                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button3.Enabled = true;
                    button2.Enabled = false;
                    label1.Text = "Подключено";
                    richTextBox1.Visible = true;
                    label2.Visible = false;
                }
                catch (NpgsqlException)
                {
                    connection?.Dispose();
                    connection = null;
                    label2.Visible = true;
                }

            }
            catch (Exception)
            {
                label2.Visible = true;
            }

        }


    }
}