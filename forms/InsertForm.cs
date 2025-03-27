using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class InsertForm : Form
    {
        public string bookTitle { get; private set; }
        public string bookAuthor { get; private set; }
        public int bookYear;

        public InsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkFields())
            {
                label4.Visible = true;
                return;
            }

            bookTitle = textBox1.Text;
            bookAuthor = textBox2.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool checkFields()
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                return false;
            }
            if (textBox3.Text.Length != 4)
            {
                return false;
            }
            return int.TryParse(textBox3.Text, out bookYear);
        }

    }
}
