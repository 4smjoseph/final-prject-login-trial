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
    public partial class Form3 : Form
    {
        SearchMenu f;
        data d = new data();
        string food= "Abiyuch";
        string account;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string name, SearchMenu form,string username)
        {
            InitializeComponent();
            food = name;
            f = form;
            this.FormClosed += new FormClosedEventHandler(Form3_Close);
            account = username;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            d.select("food");
            d.where(food);
            d.work();
            d.connect();
            food_name.Text = d.rd[0].ToString();
            protein_value.Text = d.rd[3].ToString();  calories_value.Text = d.rd[1].ToString(); fat_value.Text = d.rd[4].ToString();
            sugar_value.Text = d.rd[5].ToString(); carbs_value.Text = d.rd[2].ToString(); cholesterol_value.Text = d.rd[10].ToString();
            grams_value.Text = d.rd[6].ToString(); sfat_value.Text = d.rd[9].ToString(); fiber_value.Text = d.rd[8].ToString();
            foodgroup_value.Text = d.rd[7].ToString(); water_value.Text = d.rd[12].ToString(); calcium_value.Text = d.rd[11].ToString();
            d.disconnect();
        }

        private void Form3_Close(object sender, EventArgs e)
        {
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            //d.insert_personal_food(account,day,food,Convert.ToInt16(comboBox1.Text),int meal);
            //d.work();
            //d.insert_personal_daily(account,day,calories_value,carbs_value,protein_value,fat_value,sugar_value);
            //d.work();
        }
    }
}
