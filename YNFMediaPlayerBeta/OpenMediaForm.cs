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
    public partial class OpenMediaForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();

        private PlayerForm mainForm = null;
        public string[] paths, files;
        int r;

        public OpenMediaForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as PlayerForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.player.URL = paths[trackList.SelectedIndex];
            mainForm.player.Ctlcontrols.play();
            mainForm.counter = trackList.SelectedIndex;
            mainForm.pictureBoxLogo2.Visible = false;
            mainForm.pictureBoxPause.Visible = true;
            mainForm.timer1.Start();
            mainForm.trackBarVolume.Value = 15;
            mainForm.labelVolume.Text = mainForm.trackBarVolume.Value.ToString() + "%";

            if (this.mainForm.player.Visible == false)
            {
                this.mainForm.player.Visible = true;
                this.mainForm.pictureBoxLogo2.Visible = false;
            }
            textBoxFIle.Text = files[trackList.SelectedIndex];
        }

        private void OpenMediaForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    trackList.Items.Add(files[i]);

                    //Database updating work for adding files into playlist

                    SqlCommand command = new SqlCommand("INSERT INTO tbl_playlist(path,fileName,username) VALUES(@path, @fileName, @username)");
                    command.Parameters.AddWithValue("@path", paths[i]);
                    command.Parameters.AddWithValue("@fileName", files[i]);
                    command.Parameters.AddWithValue("@username", LoginForm.username);
                    r = connector.executeQuery(command);                   
                }
                if (r == 1)
                {
                    MessageBox.Show("Media added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some Error Occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
