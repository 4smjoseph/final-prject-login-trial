using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_prject_login_trial
{
    public partial class Search : Form
    {
        int mode;
        Main form1;
        string username;
        // 1 is breakfast, 2 is lunch, 3 is dinner, 4 is snack

        public Search(int food_mode, Main f1, string account)
        {
            this.FormClosed += new FormClosedEventHandler(Form2_Close);

            InitializeComponent();
            mode = food_mode;
            form1 = f1;

            textBox1.Click += TextBox1_Click;
            textBox1.Leave += TextBox1_Leave;
            textBox1.Text = "Search for a food ...";
            textBox1.ForeColor = Color.Gray;

            username = account;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (mode == 1) label1.Text = "Breakfast";
            else if (mode == 2) label1.Text = "Lunch";
            else if (mode == 3) label1.Text = "Dinner";
            else if (mode == 4) label1.Text = "Snack";
        }

        private void Form2_Close(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search for a food ...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new SearchMenu(textBox1.Text, this, username);
            f3.Show();
            this.Hide();
        }
        


    }
}
