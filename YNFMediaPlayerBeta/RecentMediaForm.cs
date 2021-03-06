﻿using System;
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
    public partial class RecentMediaForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();
        DataTable mediaFiles = new DataTable();
        private PlayerForm mainForm = null;

        DataRow dRow;

        public RecentMediaForm(Form CallingForm)
        {
            InitializeComponent();
            mainForm = CallingForm as PlayerForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecentMediaForm_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM tbl_recent WHERE username = '" +LoginForm.username+ "';";

            connector.readDatathroughAdapter(query, mediaFiles);

            ShowRecords();
        }

        private void ShowRecords()
        {
            for (int i = 0; i < mediaFiles.Rows.Count; i++)
            {
                trackList.Items.Add(mediaFiles.Rows[i].ItemArray.GetValue(2).ToString());
            }
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dRow = mediaFiles.Rows[trackList.SelectedIndex];
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


            if (this.mainForm.player.Visible == false)
            {
                this.mainForm.player.Visible = true;
                this.mainForm.pictureBoxLogo2.Visible = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tbl_recent WHERE username='" + LoginForm.username + "';");
            connector.executeQuery(command);
            trackList.Items.Clear();
        }
    }
}
