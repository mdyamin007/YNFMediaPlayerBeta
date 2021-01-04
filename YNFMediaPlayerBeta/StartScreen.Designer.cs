
namespace YNFMediaPlayerBeta
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.lblYoutube = new System.Windows.Forms.Label();
            this.lblPlayMedia = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.youtubeButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYoutube
            // 
            resources.ApplyResources(this.lblYoutube, "lblYoutube");
            this.lblYoutube.ForeColor = System.Drawing.Color.White;
            this.lblYoutube.Name = "lblYoutube";
            // 
            // lblPlayMedia
            // 
            resources.ApplyResources(this.lblPlayMedia, "lblPlayMedia");
            this.lblPlayMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayMedia.ForeColor = System.Drawing.Color.White;
            this.lblPlayMedia.Name = "lblPlayMedia";
            this.lblPlayMedia.Click += new System.EventHandler(this.lblPlayMedia_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Name = "closeButton";
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // youtubeButton
            // 
            resources.ApplyResources(this.youtubeButton, "youtubeButton");
            this.youtubeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtubeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.youtubeButton.FlatAppearance.BorderSize = 0;
            this.youtubeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.youtubeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.youtubeButton.Image = global::YNFMediaPlayerBeta.Properties.Resources.ezgif_com_webp_to_jpg;
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.UseVisualStyleBackColor = true;
            // 
            // playerButton
            // 
            resources.ApplyResources(this.playerButton, "playerButton");
            this.playerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playerButton.FlatAppearance.BorderSize = 0;
            this.playerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.playerButton.Image = global::YNFMediaPlayerBeta.Properties.Resources.rsz_25482;
            this.playerButton.Name = "playerButton";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // StartScreen
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblYoutube);
            this.Controls.Add(this.lblPlayMedia);
            this.Controls.Add(this.youtubeButton);
            this.Controls.Add(this.playerButton);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label lblYoutube;
        private System.Windows.Forms.Label lblPlayMedia;
        private System.Windows.Forms.Button youtubeButton;
        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.Label lblTitle;
    }
}

