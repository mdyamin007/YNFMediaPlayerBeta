
namespace YNFMediaPlayerBeta
{
    partial class youtubeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(youtubeForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(929, 749);
            this.webBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.ActiveBorderThickness = 1;
            this.btnGo.ActiveCornerRadius = 20;
            this.btnGo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGo.ActiveForecolor = System.Drawing.Color.White;
            this.btnGo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGo.BackColor = System.Drawing.Color.Black;
            this.btnGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGo.BackgroundImage")));
            this.btnGo.ButtonText = "Play";
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.IdleBorderThickness = 1;
            this.btnGo.IdleCornerRadius = 20;
            this.btnGo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnGo.IdleForecolor = System.Drawing.Color.White;
            this.btnGo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnGo.Location = new System.Drawing.Point(623, 6);
            this.btnGo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(136, 44);
            this.btnGo.TabIndex = 1;
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsReturn = false;
            this.txtUrl.AcceptsTab = false;
            this.txtUrl.AnimationSpeed = 200;
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUrl.BackgroundImage")));
            this.txtUrl.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.txtUrl.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUrl.BorderRadius = 1;
            this.txtUrl.BorderThickness = 1;
            this.txtUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUrl.DefaultText = "";
            this.txtUrl.FillColor = System.Drawing.Color.White;
            this.txtUrl.HideSelection = true;
            this.txtUrl.IconLeft = null;
            this.txtUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.IconPadding = 10;
            this.txtUrl.IconRight = null;
            this.txtUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUrl.Modified = false;
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnIdleState = stateProperties4;
            this.txtUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUrl.PlaceholderText = "Enter video url";
            this.txtUrl.ReadOnly = false;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(603, 38);
            this.txtUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrl.TextMarginBottom = 0;
            this.txtUrl.TextMarginLeft = 3;
            this.txtUrl.TextMarginTop = 0;
            this.txtUrl.TextPlaceholder = "Enter video url";
            this.txtUrl.UseSystemPasswordChar = false;
            this.txtUrl.WordWrap = true;
            // 
            // youtubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "youtubeForm";
            this.Text = "YNF Youtube Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.youtubeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtUrl;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGo;
    }
}