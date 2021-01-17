using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YNFMediaPlayerBeta
{
    public partial class SignUpForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();


        public SignUpForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFirstName;       
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(firstName.Equals(""))
            {
                MessageBox.Show("Please enter your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (lastName.Equals(""))
            {
                MessageBox.Show("Please enter your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(username.Equals(""))
            {
                MessageBox.Show("Please enter your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(password.Equals(""))
            {
                MessageBox.Show("Please enter your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                SqlCommand command = new SqlCommand("INSERT INTO tbl_users(username,password,first_name,last_name) VALUES(@username, @password, @firstName, @lastName)");
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                int r = connector.executeQuery(command);
                if(r == 1)
                {
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
