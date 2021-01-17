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
    public partial class OpenMediaForm : Form
    {
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int maxRows;
        int counter = 0;

        private PlayerForm mainForm = null;
        public string[] paths, files;

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
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.PlayerConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;
                maxRows = ds.Tables[0].Rows.Count;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

                    DataRow row = ds.Tables[0].NewRow();
                    row[1] = paths[i];
                    row[2] = files[i];
                    ds.Tables[0].Rows.Add(row);
                }

                try
                {
                    objConnect.UpdateDatabase(ds);
                    MessageBox.Show("Media Files Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
