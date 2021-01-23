using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YNFMediaPlayerBeta
{
    public partial class youtubeForm : Form
    {
        public youtubeForm()
        {
            InitializeComponent();
        }

        string _ytUrl;

        private string VideoId
        {
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)\/(?:.*v(?:\/|=)|(?:.*\/)?)([a-zA-Z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            _ytUrl = txtUrl.Text;
            webBrowser.Navigate($"https://www.youtube.com/v/{VideoId}?version=3");
        }

        private void youtubeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser.Stop();
        }
    }
}
