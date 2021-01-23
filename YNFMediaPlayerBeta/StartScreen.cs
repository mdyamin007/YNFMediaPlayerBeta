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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerForm f = new PlayerForm();
            f.ShowDialog();
            this.Show();
        }

        private void lblPlayMedia_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerForm f = new PlayerForm();
            f.ShowDialog();
            this.Show();
        }

        private void youtubeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            youtubeForm f = new youtubeForm();
            f.ShowDialog();
            this.Show();
        }
    }
}
