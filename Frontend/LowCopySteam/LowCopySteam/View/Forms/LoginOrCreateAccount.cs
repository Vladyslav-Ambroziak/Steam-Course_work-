using LowCopySteam.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowCopySteam.View.Forms
{
    public partial class LoginOrCreateAccount : Form
    {
        public string password;
        public bool checkPassword = false;
        public LoginOrCreateAccount()
        {
            InitializeComponent();
            //if (File.Exists("UserLogAndPass.json"))
            //{
            //    LogAndPassword log = JsonSerializer.Deserialize<LogAndPassword>(new FileStream("UserLogAndPass.json", FileMode.OpenOrCreate));
            //    this.login_textBox.Text = log.Login;
            //    this.password_textBox.Text = log.Password;
            //}
        }

        private void checkPassword_panel_Click(object sender, EventArgs e)
        {
            if (checkPassword)
            {
                this.password_textBox.UseSystemPasswordChar = true;
                checkPassword = false;
            }
            else
            {
                this.password_textBox.UseSystemPasswordChar = false;
                checkPassword = true;
            }
        }

        private void signIn_button_Click(object sender, EventArgs e)
        {
            LogAndPassword userPass = new LogAndPassword();
            userPass.Id = 0;
            userPass.Login = this.login_textBox.Text;
            userPass.Password = this.password_textBox.Text;
            JsonSerializer.Serialize<LogAndPassword>(new FileStream("UserLogAndPass.json", FileMode.OpenOrCreate), userPass);
            
        }
    }
}
