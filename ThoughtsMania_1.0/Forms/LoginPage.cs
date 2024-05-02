using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using ThoughtsMania_1._0.Models;

namespace ThoughtsMania_1._0.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            CenterPanel();
        }

        private void CenterPanel()
        {



        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Calculate the position to center the panel
            int panelX = (this.ClientSize.Width - PanelLogin.Width) / 2;
            int panelY = ((this.ClientSize.Height - PanelLogin.Height) / 2)+200;

            // Set the panel's location
            PanelLogin.Location = new System.Drawing.Point(panelX, panelY);
            PanelLogin.Location = new System.Drawing.Point((int)panelX, (int)panelY - 150);
            loginButton.Focus();


            // Calculate the position to center the panelS
            panelX = (this.ClientSize.Width - PanelSignin.Width) / 2;
            panelY = ((this.ClientSize.Height - PanelSignin.Height) / 2)+200;

            // Set the panel's location
            PanelSignin.Location = new System.Drawing.Point(panelX, panelY);
            PanelSignin.Location = new System.Drawing.Point((int)panelX, (int)panelY - 150);
            loginButton.Focus();

        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void Link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelLogin.Visible = false;
            PanelSignin.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelLogin.Visible = true;
            PanelSignin.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { email = email_id.Text, password = password.Text };
                var user = connection.Query<User>("thoughts_mania.get_login", parameters, commandType: CommandType.StoredProcedure);
                user = user.ToList();


                if (user.Count() == 0)
                {
                    password_error.Text = "invalid email id or password";
                }

                foreach (var user_data in user)
                {
                    // login login and from Routing will be done 
                    if (email_id.Text == user_data.email_id && password.Text == user_data.password)
                    {
                        Form1 form1 = new Form1(user_data);
                        form1.Show();
                    }
                    else
                    {
                        email_error.Text = "invalid email";
                        password_error.Text = "invalid passowrd";
                    }
                }
            }
        }

        private void email_id_Enter(object sender, EventArgs e)
        {
            email_id.Text = string.Empty;
            email_id.ForeColor = Color.Black;
        }

        private void email_id_Leave(object sender, EventArgs e)
        {
            if (email_id.Text == "")
            {
                email_id.Text = " email";
                email_id.ForeColor = Color.DarkGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = string.Empty;
            password.ForeColor = Color.Black;
            password.UseSystemPasswordChar = true;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = " password";
                password.ForeColor = Color.DarkGray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void SignInEmail_Enter(object sender, EventArgs e)
        {
            SignInEmail.Text = string.Empty;
            SignInEmail.ForeColor = Color.Black;
        }

        private void SignInEmail_Leave(object sender, EventArgs e)
        {
            if (SignInEmail.Text == "")
            {
                SignInEmail.Text = " email";
                SignInEmail.ForeColor = Color.DarkGray;
            }
        }

        private void SignInPassword_Enter(object sender, EventArgs e)
        {
            SignInPassword.Text = string.Empty;
            SignInPassword.ForeColor = Color.Black;
            SignInPassword.UseSystemPasswordChar = true;
        }

        private void SignInPassword_Leave(object sender, EventArgs e)
        {
            if (SignInPassword.Text == "")
            {
                SignInPassword.Text = " password";
                SignInPassword.ForeColor = Color.DarkGray;
                SignInPassword.UseSystemPasswordChar = false;
            }
        }

        private void TextName_Enter(object sender, EventArgs e)
        {
            TextName.Text = string.Empty;
            TextName.ForeColor = Color.Black;
        }

        private void TextName_Leave(object sender, EventArgs e)
        {
            if (TextName.Text == "")
            {
                TextName.Text = " name";
                TextName.ForeColor = Color.DarkGray;
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { email = SignInEmail.Text, pass = SignInPassword.Text , user_name = TextName.Text };
                var user = connection.Query<User>("thoughts_mania.insert_into_users", parameters, commandType: CommandType.StoredProcedure);
                PanelLogin.Visible = true;
                PanelSignin.Visible = false;
            }
        }
    }
}
