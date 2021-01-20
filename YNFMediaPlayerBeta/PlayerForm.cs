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
    public partial class PlayerForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();
        DataTable mediaFiles = new DataTable();
        DataTable recentFiles = new DataTable();
        int maxRows;
        public int counter = 0;
        private Form activeForm = null;
        
        public PlayerForm()
        {
            InitializeComponent();
            hideSubMenu();
        }

        public void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
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

        public void openChildForm(Form childForm)
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
            if (pictureBoxLogo2.Visible == true) pictureBoxLogo2.Visible = false;
            if (player.Visible == false) player.Visible = true;
            pictureBoxPause.Visible = false;
            pictureBoxPlay.Visible = true;
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            if(pictureBoxLogo2.Visible == true) pictureBoxLogo2.Visible = false;
            if (player.Visible == false) player.Visible = true;
            pictureBoxPlay.Visible = false;
            pictureBoxPause.Visible = true;
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_playlist WHERE username = '" + LoginForm.username + "';";
            connector.readDatathroughAdapter(query, mediaFiles);
            maxRows = mediaFiles.Rows.Count;
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            if (counter < maxRows - 1) counter++;
            else counter = 0;
            string url = mediaFiles.Rows[counter].ItemArray.GetValue(1).ToString();
            player.URL = url;
            player.Ctlcontrols.play();
            if (pictureBoxLogo2.Visible == true) pictureBoxLogo2.Visible = false;
            if (player.Visible == false) player.Visible = true;
            updateRecent(mediaFiles.Rows[counter]);
        }

        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            if (counter > 0) counter--;
            else counter = maxRows - 1;
            string url = mediaFiles.Rows[counter].ItemArray.GetValue(1).ToString();
            player.URL = url;
            player.Ctlcontrols.play();
            if (pictureBoxLogo2.Visible == true) pictureBoxLogo2.Visible = false;
            if (player.Visible == false) player.Visible = true;
            updateRecent(mediaFiles.Rows[counter]);

        }

        private void pictureBoxShuffle_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_playlist WHERE username='"+LoginForm.username+"' ORDER BY newid();";
            connector.readDatathroughAdapter(query, mediaFiles);
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
            string pathOfFile = dataRow[1].ToString();
            string nameOfFile = dataRow[2].ToString();
            string username = LoginForm.username;

            SqlCommand command = new SqlCommand("INSERT INTO tbl_recent(path,fileName,username) VALUES(@path,@fileName,@username);");
            command.Parameters.AddWithValue("@path", pathOfFile);
            command.Parameters.AddWithValue("@fileName", nameOfFile);
            command.Parameters.AddWithValue("@username", username);
            connector.executeQuery(command);
        }
    }
}
