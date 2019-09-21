using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form : Form
    {
        public string[,] users = { { "user", "password" }, /*{ "admin", "password" }*/ };
        public int trys = 4;
        
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwd.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            response.Text = "";
            picture.Image = null;

        }

        private void login_Click(object sender, EventArgs e)
        {

            if (username.Text == users[0, 0] && password.Text == users[0, 1] && trys > 1)
            {
                response.ForeColor = System.Drawing.Color.Lime;
                response.Text = "The username and password are correct!";
                picture.Image = Image.FromFile("..\\..\\check.png");
            }
           /* else if (username.Text == users[1, 0] && password.Text == users[1, 1])
            {
                trys = 4;
                response.ForeColor = System.Drawing.Color.Lime;
                response.Text = "Attepts resetted!";
                picture.Image = Image.FromFile("..\\..\\check.png");
            }*/
            else if (trys > 1)
            {
                trys--;
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "The username / password is wrong ! \n"+trys+" trys left";
                picture.Image = Image.FromFile("..\\..\\x.png");
            }
            else
            {
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "Your account is locked!";
                picture.Image = Image.FromFile("..\\..\\x.png");
                username.Text = "";
                password.Text = "";
                username.Enabled = false;
                password.Enabled = false;
            }
        }
    }
}
