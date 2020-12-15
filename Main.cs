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
    public partial class Main : Form
    {
        string username;

        public Main(string account)
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Label[] labels = new Label[4];
            Button[] buttons = new Button[4];
            int posY = 0;



            for (int i = 0; i < 4; i++)
            {
                labels[i] = new Label();
                labels[i].Location = new Point(0, posY);
                control_panel.Controls.Add(labels[i]);
                posY += 25;

                buttons[i] = new Button();
                buttons[i].Location = new Point(0, posY);
                control_panel.Controls.Add(buttons[i]);
                buttons[i].Name = "button" + i;
                buttons[i].Click += new EventHandler(button_Click);
                posY += 40;

                if (i == 0) labels[i].Text = "Breakfast";
                if (i == 1) labels[i].Text = "Lunch";
                if (i == 2) labels[i].Text = "Dinner";
                if (i == 3) labels[i].Text = "Snacks";

                buttons[i].Text = "Add Food";
            }


            //pictureBox1.Image = Image.FromFile(@"..\..\Icons\default.png");
            //pictureBox1.Image = Properties.Resources._default;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Search f2;
            if (((Button)(sender)).Name.ToString() == "button0")
            {
                f2 = new Search(1, this, username);
                f2.Show();
            }
            if (((Button)(sender)).Name.ToString() == "button1")
            {
                f2 = new Search(2, this, username);
                f2.Show();
            }
            if (((Button)(sender)).Name.ToString() == "button2")
            {
                f2 = new Search(3, this, username);
                f2.Show();
            }
            if (((Button)(sender)).Name.ToString() == "button3")
            {
                f2 = new Search(4, this, username);
                f2.Show();
            }
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Text = "" + monthCalendar1.SelectionRange.Start.AddDays(-1);
            monthCalendar1.SelectionRange = new SelectionRange(monthCalendar1.SelectionRange.Start.AddDays(-1), monthCalendar1.SelectionRange.Start.AddDays(-1));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.Text = "" + monthCalendar1.SelectionRange.Start.AddDays(1);
            monthCalendar1.SelectionRange = new SelectionRange(monthCalendar1.SelectionRange.Start.AddDays(1), monthCalendar1.SelectionRange.Start.AddDays(1));
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            button5.Text = "" + monthCalendar1.SelectionRange.Start;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Create create = new Create(2, this);
            create.Show();
            this.Hide();
        }
    }
}
