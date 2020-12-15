using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_prject_login_trial
{
    public partial class SearchMenu : Form
    {
        string searchText;
        Search form2;
        data d = new data();
        string username;

        List<string>[] list = new List<String>[6];


        public SearchMenu(string text, Search f2, string account)
        {
            this.FormClosed += new FormClosedEventHandler(Form3_Close);

            InitializeComponent();
            searchText = text;
            form2 = f2;
            username = account;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = searchText;
         


            Button[] buttons = new Button[20];
            int posY = 0;



            for (int i = 0; i < 20; i++)
            {
                buttons[i] = new Button();
                buttons[i].Location = new Point(0, posY);
                buttons[i].Size = new Size(600, 40);
                panel1.Controls.Add(buttons[i]);
                buttons[i].Click += new EventHandler(button_Click); // this is for making a function 
                posY += 60;

                buttons[i].Text = buttons[i].Name;
            }


            d.select("food");
            d.sqlStr += "WHERE name >='"+searchText+"';";
            d.work();
            d.con();
            int num = 0;
            do
            {
                while (d.rd.Read())
                {
                    
                    //if (string.Compare(d.rd[0].ToString(), searchText) == 0) break;
                    buttons[num].Text = d.rd[0].ToString();
                    if (++num > 19) break;
                }
            }
            while (d.rd.NextResult());
            d.disconnect();
        }

        private void Form3_Close(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3((sender as Button).Text, this, username);
            f3.Show();
            this.Hide();
        }
    }
}
