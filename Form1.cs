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

namespace final_prject_login_trial
{
    public partial class Form1 : Form
    {
        public bool text_input;
        int verification_code;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random verfication = new Random();
            verification_code = verfication.Next(100000,999999);
            code.Text = verification_code.ToString();
        }
            
         private void create_account_button_Click(object sender, EventArgs e)
        { 
            {
                Form2 userinfo = new Form2();
                userinfo.Show();
                this.Hide();
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //string username_data = 
            //string password_data = 
            int username_confirm = 0;
            int password_confirm = 0;
            int code_confirm = string.Compare(verification_code.ToString(), input_code.Text);
            //username_confirm = string.Compare(username_data, login_username.Text);
            //password_confirm = string.Compare(password_data, login_password.Text);
            if (username_confirm == 0 && password_confirm == 0 && code_confirm == 0)
            {
                MessageBox.Show("login successful");
            }
            else
            {
                MessageBox.Show("username, password, or verification code is incorrect");
            }


        }
    }
    
}
