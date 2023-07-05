namespace PRN211_GroupProject
{
    partial class PlayListPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListPlayer));
            this.btnBack = new System.Windows.Forms.Button();
            this.wpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlPlayList = new System.Windows.Forms.Panel();
            this.lbCreatedAtValue = new System.Windows.Forms.Label();
            this.lbPlayListNameValue = new System.Windows.Forms.Label();
            this.lbListSong = new System.Windows.Forms.Label();
            this.lboxSongs = new System.Windows.Forms.ListBox();
            this.lbPlayListCreatedAt = new System.Windows.Forms.Label();
            this.lbPlayListName = new System.Windows.Forms.Label();
            this.lbPlayListInfo = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.lbSingerValue = new System.Windows.Forms.Label();
            this.lbSongNameValue = new System.Windows.Forms.Label();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbPlayingSong = new System.Windows.Forms.Label();
            this.lbDesValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wpPlayer)).BeginInit();
            this.pnlPlayList.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(6, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // wpPlayer
            // 
            this.wpPlayer.Enabled = true;
            this.wpPlayer.Location = new System.Drawing.Point(9, 9);
            this.wpPlayer.Name = "wpPlayer";
            this.wpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wpPlayer.OcxState")));
            this.wpPlayer.Size = new System.Drawing.Size(563, 404);
            this.wpPlayer.TabIndex = 1;
            this.wpPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wpPlayer_PlayStateChange);
            // 
            // pnlPlayList
            // 
            this.pnlPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayList.Controls.Add(this.lbDesValue);
            this.pnlPlayList.Controls.Add(this.label2);
            this.pnlPlayList.Controls.Add(this.lbCreatedAtValue);
            this.pnlPlayList.Controls.Add(this.lbPlayListNameValue);
            this.pnlPlayList.Controls.Add(this.lbListSong);
            this.pnlPlayList.Controls.Add(this.lboxSongs);
            this.pnlPlayList.Controls.Add(this.lbPlayListCreatedAt);
            this.pnlPlayList.Controls.Add(this.lbPlayListName);
            this.pnlPlayList.Controls.Add(this.lbPlayListInfo);
            this.pnlPlayList.Location = new System.Drawing.Point(587, 12);
            this.pnlPlayList.Name = "pnlPlayList";
            this.pnlPlayList.Size = new System.Drawing.Size(204, 275);
            this.pnlPlayList.TabIndex = 2;
            // 
            // lbCreatedAtValue
            // 
            this.lbCreatedAtValue.AutoSize = true;
            this.lbCreatedAtValue.Location = new System.Drawing.Point(72, 133);
            this.lbCreatedAtValue.Name = "lbCreatedAtValue";
            this.lbCreatedAtValue.Size = new System.Drawing.Size(16, 13);
            this.lbCreatedAtValue.TabIndex = 6;
            this.lbCreatedAtValue.Text = "...";
            // 
            // lbPlayListNameValue
            // 
            this.lbPlayListNameValue.Location = new System.Drawing.Point(81, 43);
            this.lbPlayListNameValue.Name = "lbPlayListNameValue";
            this.lbPlayListNameValue.Size = new System.Drawing.Size(109, 40);
            this.lbPlayListNameValue.TabIndex = 5;
            this.lbPlayListNameValue.Text = "...";
            // 
            // lbListSong
            // 
            this.lbListSong.AutoSize = true;
            this.lbListSong.Location = new System.Drawing.Point(12, 146);
            this.lbListSong.Name = "lbListSong";
            this.lbListSong.Size = new System.Drawing.Size(54, 13);
            this.lbListSong.TabIndex = 4;
            this.lbListSong.Text = "List Song:";
            // 
            // lboxSongs
            // 
            this.lboxSongs.FormattingEnabled = true;
            this.lboxSongs.Location = new System.Drawing.Point(12, 164);
            this.lboxSongs.Name = "lboxSongs";
            this.lboxSongs.Size = new System.Drawing.Size(178, 95);
            this.lboxSongs.TabIndex = 3;
            this.lboxSongs.Click += new System.EventHandler(this.lboxSongs_Click);
            // 
            // lbPlayListCreatedAt
            // 
            this.lbPlayListCreatedAt.AutoSize = true;
            this.lbPlayListCreatedAt.Location = new System.Drawing.Point(12, 133);
            this.lbPlayListCreatedAt.Name = "lbPlayListCreatedAt";
            this.lbPlayListCreatedAt.Size = new System.Drawing.Size(60, 13);
            this.lbPlayListCreatedAt.TabIndex = 2;
            this.lbPlayListCreatedAt.Text = "Created At:";
            // 
            // lbPlayListName
            // 
            this.lbPlayListName.AutoSize = true;
            this.lbPlayListName.Location = new System.Drawing.Point(12, 43);
            this.lbPlayListName.Name = "lbPlayListName";
            this.lbPlayListName.Size = new System.Drawing.Size(41, 13);
            this.lbPlayListName.TabIndex = 1;
            this.lbPlayListName.Text = "Name: ";
            // 
            // lbPlayListInfo
            // 
            this.lbPlayListInfo.AutoSize = true;
            this.lbPlayListInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPlayListInfo.Location = new System.Drawing.Point(43, 15);
            this.lbPlayListInfo.Name = "lbPlayListInfo";
            this.lbPlayListInfo.Size = new System.Drawing.Size(104, 16);
            this.lbPlayListInfo.TabIndex = 0;
            this.lbPlayListInfo.Text = "PLAYLIST INFO";
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.lbSingerValue);
            this.pnl.Controls.Add(this.lbSongNameValue);
            this.pnl.Controls.Add(this.lbSinger);
            this.pnl.Controls.Add(this.lbSongName);
            this.pnl.Controls.Add(this.lbPlayingSong);
            this.pnl.Location = new System.Drawing.Point(586, 293);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(204, 119);
            this.pnl.TabIndex = 3;
            // 
            // lbSingerValue
            // 
            this.lbSingerValue.AutoSize = true;
            this.lbSingerValue.Location = new System.Drawing.Point(80, 67);
            this.lbSingerValue.Name = "lbSingerValue";
            this.lbSingerValue.Size = new System.Drawing.Size(16, 13);
            this.lbSingerValue.TabIndex = 7;
            this.lbSingerValue.Text = "...";
            // 
            // lbSongNameValue
            // 
            this.lbSongNameValue.Location = new System.Drawing.Point(80, 38);
            this.lbSongNameValue.Name = "lbSongNameValue";
            this.lbSongNameValue.Size = new System.Drawing.Size(111, 29);
            this.lbSongNameValue.TabIndex = 6;
            this.lbSongNameValue.Text = "...";
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Location = new System.Drawing.Point(10, 67);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(40, 13);
            this.lbSinger.TabIndex = 3;
            this.lbSinger.Text = "Singer:";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Location = new System.Drawing.Point(8, 38);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(66, 13);
            this.lbSongName.TabIndex = 2;
            this.lbSongName.Text = "Song Name:";
            // 
            // lbPlayingSong
            // 
            this.lbPlayingSong.AutoSize = true;
            this.lbPlayingSong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPlayingSong.Location = new System.Drawing.Point(44, 13);
            this.lbPlayingSong.Name = "lbPlayingSong";
            this.lbPlayingSong.Size = new System.Drawing.Size(105, 16);
            this.lbPlayingSong.TabIndex = 1;
            this.lbPlayingSong.Text = "PLAYING SONG";
            // 
            // lbDesValue
            // 
            this.lbDesValue.Location = new System.Drawing.Point(79, 82);
            this.lbDesValue.Name = "lbDesValue";
            this.lbDesValue.Size = new System.Drawing.Size(111, 40);
            this.lbDesValue.TabIndex = 8;
            this.lbDesValue.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description:";
            // 
            // PlayListPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlPlayList);
            this.Controls.Add(this.wpPlayer);
            this.Controls.Add(this.btnBack);
            this.Name = "PlayListPlayer";
            this.Text = "PlayListPlayer";
            this.Load += new System.EventHandler(this.PlayListPlayer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.wpPlayer)).EndInit();
            this.pnlPlayList.ResumeLayout(false);
            this.pnlPlayList.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private AxWMPLib.AxWindowsMediaPlayer wpPlayer;
        private System.Windows.Forms.Panel pnlPlayList;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbListSong;
        private System.Windows.Forms.ListBox lboxSongs;
        private System.Windows.Forms.Label lbPlayListCreatedAt;
        private System.Windows.Forms.Label lbPlayListName;
        private System.Windows.Forms.Label lbPlayListInfo;
        private System.Windows.Forms.Label lbCreatedAtValue;
        private System.Windows.Forms.Label lbPlayListNameValue;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbPlayingSong;
        private System.Windows.Forms.Label lbSingerValue;
        private System.Windows.Forms.Label lbSongNameValue;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbDesValue;
        private System.Windows.Forms.Label label2;
    }
}