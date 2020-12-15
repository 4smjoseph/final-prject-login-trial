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
    public partial class Login : Form
    {
        public bool text_input;
        int verification_code;

        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random verfication = new Random();
            int verification_code = verfication.Next(1000, 9999);
            code_visible.Text = verification_code.ToString();
        
        }
            
         private void create_account_button_Click(object sender, EventArgs e)
        { 
            {
                Create userinfo = new Create(1, this);
                userinfo.Show();
                this.Hide();
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user_username = login_username.Text;
            int password_confirm = 0;
            d.select("account_data");
            d.where_account(user_username);
            d.work();
            d.connect();
            string password_data = null;
            try
            {
                password_data = d.rd[1].ToString();
            }
            catch 
            {
                MessageBox.Show("username, password, or verification code is incorrect");
                input_code.Clear();
                Random verification = new Random();
                code_visible.Text = verification.Next(1000, 9999).ToString();
                d.disconnect();
                return;
            }
            password_confirm = string.Compare(password_data, login_password.Text);
            int code_confirm = string.Compare(code_visible.Text, input_code.Text);
            d.disconnect();
            if (password_confirm == 0 && code_confirm == 0)
            {
                Main main = new Main(user_username);
                main.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("username, password, or verification code is incorrect");
                input_code.Clear();
                Random verification = new Random();
                code_visible.Text = verification.Next(1000, 9999).ToString();
            }


        }
        data d = new data();
    }
    
}
