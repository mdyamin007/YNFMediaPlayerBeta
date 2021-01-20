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
    public partial class PreferenceForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();
        DataTable dtUser = new DataTable();
        private PlayerForm mainForm = null;
        public PreferenceForm(Form CallingForm)
        {
            InitializeComponent();
            mainForm = CallingForm as PlayerForm;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            mainForm.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            mainForm.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            mainForm.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        }

        private void PreferenceForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_users WHERE username='" + LoginForm.username + "';";
            connector.readDatathroughAdapter(query, dtUser);
            txtUsername.Text = dtUser.Rows[0].ItemArray.GetValue(0).ToString();
            txtFirstName.Text = dtUser.Rows[0].ItemArray.GetValue(2).ToString();
            txtLastName.Text = dtUser.Rows[0].ItemArray.GetValue(3).ToString();
            txtPassword.Text = dtUser.Rows[0].ItemArray.GetValue(1).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            if (firstName.Equals(""))
            {
                MessageBox.Show("Please enter your first name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lastName.Equals(""))
            {
                MessageBox.Show("Please enter your last name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "UPDATE tbl_users SET first_name='" + firstName + "', last_name='" + lastName + "', password='" + password + "' WHERE username='" + username + "';";
                SqlCommand command = new SqlCommand(query);
                int r = connector.executeQuery(command);
                if(r == 1)
                {
                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else
                {
                    MessageBox.Show("Error Occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            if (firstName.Equals(""))
            {
                MessageBox.Show("Please enter your first name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lastName.Equals(""))
            {
                MessageBox.Show("Please enter your last name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "UPDATE tbl_users SET first_name='" + firstName + "', last_name='" + lastName + "', password='" + password + "' WHERE username='" + username + "';";
                SqlCommand command = new SqlCommand(query);
                int r = connector.executeQuery(command);
                if (r == 1)
                {
                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error Occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
