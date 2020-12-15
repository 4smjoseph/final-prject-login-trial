using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace final_prject_login_trial
{
    public partial class Create : Form
    {
        int form_mode;
        Form f;

        public Create(int mode, Form form)
        {
            InitializeComponent();
            form_mode = mode;
            f = form;
        }
        public Create( string username)
        {
            InitializeComponent();
            create_username.Text = username;
            create_username.Enabled = false;
        }
        

        private void create_button_Click(object sender, EventArgs e)
        {
            if (create_username.Text == null | create_password.Text == null | input_height.Text == null | input_weight.Text == null | input_age.Text == null | input_gender.Text == null)
            {
                MessageBox.Show("one or more requirements have not been filled");
                return;
            }
            if (sedentary.Checked == false && lightly_active.Checked == false && moderately_active.Checked == false && active.Checked == false && very_active.Checked == false)
            {
                MessageBox.Show("one or more requirements have not been filled");
                return;
            }

            bool valid_input = false;
            if (input_height.Text.All(char.IsDigit)&&input_weight.Text.All(char.IsDigit)&&input_age.Text.All(char.IsDigit))
            {
                valid_input = true;
            }
            if (valid_input == false)
            {
                MessageBox.Show("Invalid input");
                return;
            }
            string username = create_username.Text;
            string password = create_password.Text;
            int gender = 0;
            float height = float.Parse(input_height.Text);
            float weight = float.Parse(input_weight.Text);
            float age = float.Parse(input_age.Text);
            float daily_calories = 0;
            float x = 0;
            int life_style = 0;
            if (sedentary.Checked)
            {
                life_style = 0;
                x = 1.2f;
            }
            if (lightly_active.Checked)
            {
                life_style = 1;
                x = 1.375f;
            }
            if(moderately_active.Checked)
            {
                life_style = 2;
                x = 1.55f;
            }
            if(active.Checked)
            {
                life_style = 3;
                x = 1.725f;
            }
            if(very_active.Checked)
            {
                life_style = 4;
                x = 1.9f;
            }
            if (input_gender.SelectedIndex == 0)
            {
                gender = 0;
                daily_calories = ((10f * weight) + (6.25f * height) - (5f * age) + 5f)*x;
            }
            if (input_gender.SelectedIndex == 1)
            {
                gender = 1;
                daily_calories = ((10f * weight) + (6.25f * height) - (5f *age) - 161f)*x;
            }
            d.select("account_data");
            d.where_account(username);
            d.work();
            d.connect();
            try
            {
                if (username == d.rd[0].ToString())
                {
                    MessageBox.Show("username invalid");
                    d.disconnect();
                    return;
                }
            }
            catch
            {
            }
            d.insert_account(username, password, gender, height, weight, age, life_style, daily_calories);
            d.work();
            d.create(username);
            //if (create_username.Enabled == true)
            //{
             //   this.Hide();
            //    Form1 frm_1 = new Form1();
            //    frm_1.Show();
           // }
            
            
        }
        data d = new data();

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (form_mode == 1)
            {
                this.Hide();
                Login frm_1 = new Login();
                frm_1.Show();
            }
            if(form_mode == 2)
            {
                this.Hide();
                f.Show();
            }
        }

        private void Create_Load(object sender, EventArgs e)
        {
            if(form_mode == 2)
            {
                create_username.Enabled = false;
                create_button.Text = "Change";
            }
        }
    }
  
}
