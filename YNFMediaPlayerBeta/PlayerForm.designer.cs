namespace YNFMediaPlayerBeta
{
    partial class PlayerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.buttonPreference = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.buttonManagingPlaylist = new System.Windows.Forms.Button();
            this.buttonCurrentPlaylist = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.buttonRecentMedia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTrackStart = new System.Windows.Forms.Label();
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlaylist = new System.Windows.Forms.PictureBox();
            this.pictureBoxShuffle = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepeat = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 439);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  About";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.buttonPreference);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 398);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(250, 41);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // buttonPreference
            // 
            this.buttonPreference.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPreference.FlatAppearance.BorderSize = 0;
            this.buttonPreference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonPreference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonPreference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreference.ForeColor = System.Drawing.Color.Silver;
            this.buttonPreference.Location = new System.Drawing.Point(0, 0);
            this.buttonPreference.Name = "buttonPreference";
            this.buttonPreference.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPreference.Size = new System.Drawing.Size(250, 40);
            this.buttonPreference.TabIndex = 2;
            this.buttonPreference.Text = "Preferences";
            this.buttonPreference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPreference.UseVisualStyleBackColor = true;
            this.buttonPreference.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Silver;
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 353);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(250, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "  Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.buttonManagingPlaylist);
            this.panelPlaylistSubMenu.Controls.Add(this.buttonCurrentPlaylist);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 270);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(250, 83);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // buttonManagingPlaylist
            // 
            this.buttonManagingPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManagingPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonManagingPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonManagingPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonManagingPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagingPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.buttonManagingPlaylist.Location = new System.Drawing.Point(0, 40);
            this.buttonManagingPlaylist.Name = "buttonManagingPlaylist";
            this.buttonManagingPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonManagingPlaylist.Size = new System.Drawing.Size(250, 40);
            this.buttonManagingPlaylist.TabIndex = 1;
            this.buttonManagingPlaylist.Text = "Manage Playlist";
            this.buttonManagingPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManagingPlaylist.UseVisualStyleBackColor = true;
            this.buttonManagingPlaylist.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonCurrentPlaylist
            // 
            this.buttonCurrentPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCurrentPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonCurrentPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonCurrentPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonCurrentPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.buttonCurrentPlaylist.Location = new System.Drawing.Point(0, 0);
            this.buttonCurrentPlaylist.Name = "buttonCurrentPlaylist";
            this.buttonCurrentPlaylist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCurrentPlaylist.Size = new System.Drawing.Size(250, 40);
            this.buttonCurrentPlaylist.TabIndex = 0;
            this.buttonCurrentPlaylist.Text = "Current playlist";
            this.buttonCurrentPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCurrentPlaylist.UseVisualStyleBackColor = true;
            this.buttonCurrentPlaylist.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 225);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(250, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "  Playlist management";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.buttonRecentMedia);
            this.panelMediaSubMenu.Controls.Add(this.button2);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(250, 88);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // buttonRecentMedia
            // 
            this.buttonRecentMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecentMedia.FlatAppearance.BorderSize = 0;
            this.buttonRecentMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonRecentMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.buttonRecentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecentMedia.ForeColor = System.Drawing.Color.Silver;
            this.buttonRecentMedia.Location = new System.Drawing.Point(0, 40);
            this.buttonRecentMedia.Name = "buttonRecentMedia";
            this.buttonRecentMedia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonRecentMedia.Size = new System.Drawing.Size(250, 40);
            this.buttonRecentMedia.TabIndex = 1;
            this.buttonRecentMedia.Text = "Open recent media";
            this.buttonRecentMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecentMedia.UseVisualStyleBackColor = true;
            this.buttonRecentMedia.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Open files";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.Silver;
            this.btnMedia.Image = ((System.Drawing.Image)(resources.GetObject("btnMedia.Image")));
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 92);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(250, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "  Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::YNFMediaPlayerBeta.Properties.Resources.logo3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(36, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(159, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.progressBar1);
            this.panelPlayer.Controls.Add(this.trackBarVolume);
            this.panelPlayer.Controls.Add(this.pictureBoxPause);
            this.panelPlayer.Controls.Add(this.labelVolume);
            this.panelPlayer.Controls.Add(this.labelTrackStart);
            this.panelPlayer.Controls.Add(this.labelTrackEnd);
            this.panelPlayer.Controls.Add(this.pictureBoxSound);
            this.panelPlayer.Controls.Add(this.pictureBoxPlaylist);
            this.panelPlayer.Controls.Add(this.pictureBoxShuffle);
            this.panelPlayer.Controls.Add(this.pictureBoxRepeat);
            this.panelPlayer.Controls.Add(this.pictureBoxPrevious);
            this.panelPlayer.Controls.Add(this.pictureBoxNext);
            this.panelPlayer.Controls.Add(this.pictureBoxPlay);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 431);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 130);
            this.panelPlayer.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.progressBar1.Location = new System.Drawing.Point(58, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 5);
            this.progressBar1.TabIndex = 14;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarVolume.Location = new System.Drawing.Point(389, 33);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(125, 45);
            this.trackBarVolume.TabIndex = 13;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPause.Image = global::YNFMediaPlayerBeta.Properties.Resources.pauseLogo;
            this.pictureBoxPause.Location = new System.Drawing.Point(221, 29);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPause.TabIndex = 12;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Visible = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolume.AutoSize = true;
            this.labelVolume.ForeColor = System.Drawing.Color.LightGray;
            this.labelVolume.Location = new System.Drawing.Point(520, 35);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(28, 17);
            this.labelVolume.TabIndex = 11;
            this.labelVolume.Text = "0%";
            // 
            // labelTrackStart
            // 
            this.labelTrackStart.AutoSize = true;
            this.labelTrackStart.ForeColor = System.Drawing.Color.LightGray;
            this.labelTrackStart.Location = new System.Drawing.Point(12, 84);
            this.labelTrackStart.Name = "labelTrackStart";
            this.labelTrackStart.Size = new System.Drawing.Size(44, 17);
            this.labelTrackStart.TabIndex = 10;
            this.labelTrackStart.Text = "00:00";
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.ForeColor = System.Drawing.Color.LightGray;
            this.labelTrackEnd.Location = new System.Drawing.Point(628, 84);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(44, 17);
            this.labelTrackEnd.TabIndex = 9;
            this.labelTrackEnd.Text = "00:00";
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSound.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSound.Image")));
            this.pictureBoxSound.Location = new System.Drawing.Point(359, 33);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSound.TabIndex = 7;
            this.pictureBoxSound.TabStop = false;
            // 
            // pictureBoxPlaylist
            // 
            this.pictureBoxPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlaylist.Image")));
            this.pictureBoxPlaylist.Location = new System.Drawing.Point(83, 33);
            this.pictureBoxPlaylist.Name = "pictureBoxPlaylist";
            this.pictureBoxPlaylist.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlaylist.TabIndex = 6;
            this.pictureBoxPlaylist.TabStop = false;
            this.pictureBoxPlaylist.Click += new System.EventHandler(this.pictureBoxPlaylist_Click);
            // 
            // pictureBoxShuffle
            // 
            this.pictureBoxShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShuffle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShuffle.Image")));
            this.pictureBoxShuffle.Location = new System.Drawing.Point(128, 33);
            this.pictureBoxShuffle.Name = "pictureBoxShuffle";
            this.pictureBoxShuffle.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShuffle.TabIndex = 5;
            this.pictureBoxShuffle.TabStop = false;
            this.pictureBoxShuffle.Click += new System.EventHandler(this.pictureBoxShuffle_Click);
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRepeat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRepeat.Image")));
            this.pictureBoxRepeat.Location = new System.Drawing.Point(320, 33);
            this.pictureBoxRepeat.Name = "pictureBoxRepeat";
            this.pictureBoxRepeat.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRepeat.TabIndex = 4;
            this.pictureBoxRepeat.TabStop = false;
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrevious.Image")));
            this.pictureBoxPrevious.Location = new System.Drawing.Point(170, 33);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPrevious.TabIndex = 3;
            this.pictureBoxPrevious.TabStop = false;
            this.pictureBoxPrevious.Click += new System.EventHandler(this.pictureBoxPrevious_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(279, 33);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNext.TabIndex = 2;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlay.Image")));
            this.pictureBoxPlay.Location = new System.Drawing.Point(221, 29);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlay.TabIndex = 1;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.player);
            this.panelChildForm.Controls.Add(this.pictureBoxLogo2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 431);
            this.panelChildForm.TabIndex = 2;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(684, 431);
            this.player.TabIndex = 3;
            this.player.Visible = false;
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo2.Image = global::YNFMediaPlayerBeta.Properties.Resources.logo2;
            this.pictureBoxLogo2.Location = new System.Drawing.Point(221, 102);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(226, 218);
            this.pictureBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo2.TabIndex = 2;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "PlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button buttonRecentMedia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button buttonPreference;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button buttonManagingPlaylist;
        private System.Windows.Forms.Button buttonCurrentPlaylist;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelTrackEnd;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.PictureBox pictureBoxRepeat;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label labelTrackStart;
        public System.Windows.Forms.PictureBox pictureBoxLogo2;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public System.Windows.Forms.PictureBox pictureBoxPause;
        public System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxPlaylist;
        private System.Windows.Forms.PictureBox pictureBoxShuffle;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TrackBar trackBarVolume;
        public System.Windows.Forms.Label labelVolume;
        public System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.Panel panelPlayer;
    }
}

