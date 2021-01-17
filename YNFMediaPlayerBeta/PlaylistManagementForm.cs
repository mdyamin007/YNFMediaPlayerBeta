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
    public partial class PlaylistManagementForm : Form
    {
        private PlayerForm mainForm = null;

        DatabaseConnection objConnect;
        string conString;

        DataSet ds, ds_recent;
        DataRow dRow;

        int maxRows;

        public PlaylistManagementForm(Form CallingForm)
        {
            InitializeComponent();
            mainForm = CallingForm as PlayerForm;
        }

        private void PlaylistManagementForm_Load(object sender, EventArgs e)
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows[trackList.SelectedIndex].Delete();
                objConnect.UpdateDatabase(ds);
                maxRows = ds.Tables[0].Rows.Count;
                trackList.Items.Clear();
                ShowRecords();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0;i < maxRows; i++)
                {
                    ds.Tables[0].Rows[i].Delete();
                    maxRows = ds.Tables[0].Rows.Count;
                }
                objConnect.UpdateDatabase(ds);
                trackList.Items.Clear();
                maxRows = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
