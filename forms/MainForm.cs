using LAB1.forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Text;
using System.Data.Common;

namespace LAB1
{
    public partial class MainForm : Form
    {
        string connectionString;
        NpgsqlConnection connection;
        NpgsqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();
        DataSet treeDataSet = new DataSet();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // кнопка "Инициализровать"
        {
            textBox1.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) // кнопка "Открыть соединение"
        {
            createConnection();
        }

        private void createConnection()
        {
            connectionString =
                "Server=" + textBox1.Text +
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
                    button3.Enabled = true;
                    button2.Enabled = false;
                    label1.Text = "Подключено";
                    dataGridView1.Visible = true;
                    listBox1.Visible = true;
                    richTextBox1.Visible = true;
                    label2.Visible = false;
                    textBox1.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    button5.Visible = true;
                    label3.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    treeView1.Visible = true;
                    initializeTreeView();
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

        private void initializeTreeView()
        {
            treeView1.Nodes.Clear();
            treeDataSet.Clear();

            NpgsqlCommand command = new NpgsqlCommand(
                "SELECT datname FROM pg_database WHERE datistemplate = false;",
                connection);
            NpgsqlDataAdapter treeDataAdapter = new NpgsqlDataAdapter(command);
            treeDataAdapter.Fill(treeDataSet, "Databases");

            foreach (DataRow row in treeDataSet.Tables["Databases"].Rows)
            {
                string dbName = row["datname"].ToString();
                TreeNode dbNode = new TreeNode(dbName);
                treeView1.Nodes.Add(dbNode);
            }
        }

        private void button3_Click(object sender, EventArgs e) // кнопка "Закрыть соединение"
        {
            button4.Visible = false;
            button3.Enabled = false;
            button2.Enabled = true;
            button2.Focus();
            label1.Text = "Отключено";
            dataGridView1.Visible = false;
            listBox1.Visible = false;
            listBox1.ClearSelected();
            dataGridView1.DataSource = null;
            richTextBox1.Visible = false;
            richTextBox1.Clear();
            connection.Close();
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button5.Visible = false;
            label3.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox6.Clear();
            textBox7.Clear();
            treeView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) // кнопка "Выполнить команду"
        {
            switch (listBox1.GetItemText(listBox1.SelectedItem))
            {
                case "Просмотр":
                    selectCommand();
                    break;
                case "Вставка":
                    insertCommand();
                    break;
                case "Удаление":
                    deleteCommand();
                    break;
                case "Обновление":
                    updateCommand();
                    break;
                default:
                    break;
            }
        }

        private void selectCommand()
        {

            string sqlQuery = "SELECT * FROM books WHERE 1=1";

            if (int.TryParse(textBox6.Text, out int yearFrom))
                sqlQuery += " AND publication_year >= @yearFrom";


            if (int.TryParse(textBox7.Text, out int yearTo))
                sqlQuery += " AND publication_year <= @yearTo";

            using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
            {
                if (int.TryParse(textBox6.Text, out yearFrom))
                    command.Parameters.AddWithValue("@yearFrom", yearFrom);

                if (int.TryParse(textBox7.Text, out yearTo))
                    command.Parameters.AddWithValue("@yearTo", yearTo);

                dataSet.Clear();
                dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.UpdateCommand = new NpgsqlCommandBuilder(dataAdapter).GetUpdateCommand();
                dataAdapter.Fill(dataSet, "books");
                dataGridView1.DataSource = dataSet.Tables["books"];
            }
        }

        private void insertCommand()
        {
            InsertForm insertForm = new InsertForm();
            if (insertForm.ShowDialog() == DialogResult.OK)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "SELECT insert(@title, @author, @year);", connection)
                    )
                {
                    command.Parameters.AddWithValue("@title", insertForm.bookTitle);
                    command.Parameters.AddWithValue("@author", insertForm.bookAuthor);
                    command.Parameters.AddWithValue("@year", insertForm.bookYear);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void deleteCommand()
        {
            DeleteForm deleteForm = new DeleteForm();
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "SELECT delete(@id);", connection)
                    )
                {
                    command.Parameters.AddWithValue("@id", deleteForm.bookId);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void showModifiedRows()
        {
            DataTable modifiedRows = dataSet.Tables["books"].GetChanges();

            if (modifiedRows != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Измененные строки:");

                foreach (DataRow row in modifiedRows.Rows)
                {
                    sb.AppendLine($"ID: {row["book_id"]}");
                }

                MessageBox.Show(sb.ToString(), "Измененные строки");
            }
        }

        private void updateCommand()
        {
            try
            {
                if (dataSet.HasChanges())
                {
                    showModifiedRows();
                    dataAdapter.Update(dataSet, "books");
                    selectCommand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении базы данных: " + ex.Message, "Ошибка");
                selectCommand();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.GetItemText(listBox1.SelectedItem))
            {
                case "Просмотр":
                    richTextBox1.Clear();
                    break;
                case "Вставка":
                    getFunctionText("insert");
                    break;
                case "Удаление":
                    getFunctionText("delete");
                    break;
                default:
                    break;
            }
        }
        private void getFunctionText(string functionName)
        {
            richTextBox1.Clear();
            using NpgsqlCommand command = new NpgsqlCommand(
                "SELECT routine_definition FROM information_schema.routines WHERE routine_name = @functionName;", connection);

            command.Parameters.AddWithValue("@functionName", functionName);
            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string record = $"{reader["routine_definition"]}";
                richTextBox1.AppendText(record);
            }
        }

        private void button5_Click(object sender, EventArgs e) // кнопка "Сохранить"
        {
            string functionName = "";
            if (richTextBox1.Text != "" && richTextBox1.Text != null)
            {

                switch (listBox1.GetItemText(listBox1.SelectedItem))
                {
                    case "Вставка":
                        functionName = "insert";
                        break;
                    case "Удаление":
                        functionName = "delete";
                        break;
                    default:
                        break;
                }

                using (NpgsqlCommand command = new NpgsqlCommand(
                    "UPDATE pg_proc SET prosrc = @body where proname= @name;", connection)
                    )
                {
                    command.Parameters.AddWithValue("@name", functionName);
                    command.Parameters.AddWithValue("@body", richTextBox1.Text);
                    command.ExecuteNonQuery();
                }
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null) return;

            string dbConnectionString = $"{connectionString}Database={e.Node.Text}";
            connection = new NpgsqlConnection(dbConnectionString);
            connection.Open();
            if (e.Node.Nodes.Count > 0) return;

            using (NpgsqlCommand command = new NpgsqlCommand(
                "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';",
                connection))
            {
                NpgsqlDataAdapter treeDataAdapter = new NpgsqlDataAdapter(command);
                DataTable tables = new DataTable();
                treeDataAdapter.Fill(tables);

                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["table_name"].ToString();
                    TreeNode tableNode = new TreeNode(tableName);
                    e.Node.Nodes.Add(tableNode);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) return;

            string dbName = e.Node.Parent.Text;
            string tableName = e.Node.Text;

            if (dbName == "books" && tableName == "books") button4.Enabled = true;
            else button4.Enabled = false;

            string dbConnectionString = $"{connectionString}Database={dbName}";
            connection = new NpgsqlConnection(dbConnectionString);
            connection.Open();

            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM {tableName};", connection))
            {
                NpgsqlDataAdapter treeDataAdapter = new NpgsqlDataAdapter(command);
                DataTable tableData = new DataTable();
                treeDataAdapter.Fill(tableData);

                dataGridView1.DataSource = tableData;
            }

        }
    }
}