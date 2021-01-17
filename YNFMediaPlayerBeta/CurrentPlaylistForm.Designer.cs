
namespace YNFMediaPlayerBeta
{
    partial class CurrentPlaylistForm
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
            this.trackList = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxCurrentlyPlaying = new System.Windows.Forms.TextBox();
            this.labelCurrentPlaylist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trackList
            // 
            this.trackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.trackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(57, 101);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(604, 290);
            this.trackList.TabIndex = 12;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClose.Location = new System.Drawing.Point(3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxCurrentlyPlaying
            // 
            this.textBoxCurrentlyPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentlyPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentlyPlaying.Location = new System.Drawing.Point(57, 58);
            this.textBoxCurrentlyPlaying.Name = "textBoxCurrentlyPlaying";
            this.textBoxCurrentlyPlaying.Size = new System.Drawing.Size(604, 26);
            this.textBoxCurrentlyPlaying.TabIndex = 10;
            // 
            // labelCurrentPlaylist
            // 
            this.labelCurrentPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentPlaylist.AutoSize = true;
            this.labelCurrentPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCurrentPlaylist.Location = new System.Drawing.Point(261, 11);
            this.labelCurrentPlaylist.Name = "labelCurrentPlaylist";
            this.labelCurrentPlaylist.Size = new System.Drawing.Size(160, 25);
            this.labelCurrentPlaylist.TabIndex = 9;
            this.labelCurrentPlaylist.Text = "Currently Playing";
            // 
            // CurrentPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxCurrentlyPlaying);
            this.Controls.Add(this.labelCurrentPlaylist);
            this.Name = "CurrentPlaylistForm";
            this.Text = "CurrentPlaylistForm";
            this.Load += new System.EventHandler(this.CurrentPlaylistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxCurrentlyPlaying;
        private System.Windows.Forms.Label labelCurrentPlaylist;
    }
}