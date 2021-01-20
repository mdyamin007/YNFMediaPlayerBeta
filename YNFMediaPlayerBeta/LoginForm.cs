using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YNFMediaPlayerBeta
{
    public partial class LoginForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();
        DataTable dtUser = new DataTable();
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm f = new SignUpForm();
            f.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username.Equals(""))
            {
                MessageBox.Show("Please Enter Your Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please Enter Your Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string query = "SELECT username,password FROM tbl_users WHERE username='" + username + "' AND password='" + password + "'";

                connector.readDatathroughAdapter(query, dtUser);

                if(dtUser.Rows.Count == 1)
                {
                    LoginForm.username = dtUser.Rows[0]["username"].ToString();
                    this.Hide();
                    StartScreen f = new StartScreen();
                    f.Show();
                } else
                {
                    MessageBox.Show("Username or Password is incorrect!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
