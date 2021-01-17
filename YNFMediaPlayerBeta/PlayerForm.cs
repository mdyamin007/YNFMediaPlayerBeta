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
    public partial class PlayerForm : Form
    {
        DatabaseConnection objConnect;
        string conString;

        DataSet ds, ds_recent;
        DataRow dRow;

        int maxRows;
        public int counter = 0;
        public PlayerForm()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
            this.pictureBoxLogo2.Visible = false;
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new OpenMediaForm(this));
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new RecentMediaForm(this));
            hideSubMenu();
        }

        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new CurrentPlaylistForm(this));
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new PlaylistManagementForm(this));
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        #region ToolsSubMenu

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new PreferenceForm(this));
            hideSubMenu();
        }

        #endregion


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (AboutUsForm uu = new AboutUsForm())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0.60d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.close();
        }

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            pictureBoxPause.Visible = false;
            pictureBoxPlay.Visible = true;
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            pictureBoxPlay.Visible = false;
            pictureBoxPause.Visible = true;
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.PlayerConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;
                maxRows = ds.Tables[0].Rows.Count;

                objConnect.Sql = Properties.Settings.Default.SQL2;
                ds_recent = objConnect.GetConnection;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            if (counter < maxRows - 1) counter++;
            else counter = 0;
            dRow = ds.Tables[0].Rows[counter];
            string url = dRow.ItemArray.GetValue(1).ToString();
            player.URL = url;
            player.Ctlcontrols.play();
            updateRecent(dRow);
        }

        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if (counter > 0) counter--;
            else counter = maxRows - 1;
            dRow = ds.Tables[0].Rows[counter];
            string url = dRow.ItemArray.GetValue(1).ToString();
            player.URL = url;
            player.Ctlcontrols.play();
            updateRecent(dRow);
            
        }

        private void pictureBoxShuffle_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            counter = random.Next(0, maxRows - 1);
            player.URL = ds.Tables[0].Rows[counter].ItemArray.GetValue(1).ToString();
            player.Ctlcontrols.play();
            updateRecent(ds.Tables[0].Rows[counter]);
        }

        private void pictureBoxPlaylist_Click(object sender, EventArgs e)
        {
            openChildForm(new CurrentPlaylistForm(this));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            labelTrackStart.Text = player.Ctlcontrols.currentPositionString;
            labelTrackEnd.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBarVolume.Value;
            labelVolume.Text = trackBarVolume.Value.ToString() + "%";
        }


        public void updateRecent(DataRow dataRow)
        {
            DataRow row = ds_recent.Tables[0].NewRow();
            row[1] = dataRow[1];
            row[2] = dataRow[2];
            ds_recent.Tables[0].Rows.Add(row);
            try
            {
                objConnect.UpdateDatabase(ds_recent);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
