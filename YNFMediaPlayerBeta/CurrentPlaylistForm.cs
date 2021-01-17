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
    public partial class CurrentPlaylistForm : Form
    {
        private PlayerForm mainForm = null;
        
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int maxRows;
        int counter = 0;
        public CurrentPlaylistForm(Form CallingForm)
        {
            InitializeComponent();
            mainForm = CallingForm as PlayerForm;
        }

        private void CurrentPlaylistForm_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.PlayerConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;
                maxRows = ds.Tables[0].Rows.Count;

                ShowRecords();
                textBoxCurrentlyPlaying.Text = ds.Tables[0].Rows[mainForm.counter].ItemArray.GetValue(2).ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ShowRecords()
        {
            for (int i = 0; i < maxRows; i++)
            {
                dRow = ds.Tables[0].Rows[i];
                trackList.Items.Add(dRow.ItemArray.GetValue(2).ToString());
            }
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dRow = ds.Tables[0].Rows[trackList.SelectedIndex];
            string url = dRow.ItemArray.GetValue(1).ToString();
            mainForm.player.URL = url;
            mainForm.player.Ctlcontrols.play();
            mainForm.counter = trackList.SelectedIndex;
            textBoxCurrentlyPlaying.Text = dRow.ItemArray.GetValue(2).ToString();
            mainForm.pictureBoxPlay.Visible = false;
            mainForm.pictureBoxPause.Visible = true;
            mainForm.timer1.Start();
            mainForm.trackBarVolume.Value = 15;
            mainForm.labelVolume.Text = mainForm.trackBarVolume.Value.ToString() + "%";
            mainForm.updateRecent(dRow);
            

            if (this.mainForm.player.Visible == false)
            {
                this.mainForm.player.Visible = true;
                this.mainForm.pictureBoxLogo2.Visible = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
