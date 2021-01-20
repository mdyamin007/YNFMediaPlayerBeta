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
    public partial class PlaylistManagementForm : Form
    {
        DatabaseConnector connector = new DatabaseConnector();
        DataTable mediaFiles = new DataTable();
        private PlayerForm mainForm = null;
        int maxRows;


        public PlaylistManagementForm(Form CallingForm)
        {
            InitializeComponent();
            mainForm = CallingForm as PlayerForm;
        }

        private void PlaylistManagementForm_Load(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM tbl_playlist WHERE username = '" + LoginForm.username + "';";

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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                mediaFiles.Rows[trackList.SelectedIndex].Delete();
                string query = "SELECT * FROM tbl_playlist WHERE username='" +LoginForm.username+ "';";
                connector.executeDataAdapter(mediaFiles, query);
                maxRows = mediaFiles.Rows.Count;
                trackList.Items.Clear();
                ShowRecords();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.openChildForm(new OpenMediaForm(mainForm));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM tbl_playlist");
            connector.executeQuery(sqlCommand);
            trackList.Items.Clear();
        }
    }
}
