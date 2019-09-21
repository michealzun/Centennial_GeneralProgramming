using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class form : Form
    {
        public string[] users;
        public int trys = 3;
        public bool userlogin = false;
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                login.Enabled = false;
            }
            else
            {
                login.Enabled = true;
            }
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
           FileStream inFile = new FileStream("~//../../../users.txt", FileMode.Open, FileAccess.Read);
           StreamReader reader = new StreamReader(inFile);
           string lineRead = reader.ReadLine();
           while (lineRead != null)
           {
               users = lineRead.Split(',');
               lineRead = reader.ReadLine();
               if (username.Text == users[0] && password.Text == users[1] && trys > 1)
               {
                   userlogin = true;
                   response.ForeColor = System.Drawing.Color.Lime;
                   response.Text = "The username and password are correct!";
                   picture.Image = Image.FromFile("..\\..\\check.png");
                   this.Hide();
                   calculator form = new calculator();
                   form.ShowDialog();
               }
           }
           if (!userlogin && trys >= 1)
            {
                response.ForeColor = System.Drawing.Color.Red;
                response.Text = "The username / password is wrong ! \n"+trys+" trys left";
                picture.Image = Image.FromFile("..\\..\\x.png");
                trys--;
            }
           else if (!userlogin && trys < 1)
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
