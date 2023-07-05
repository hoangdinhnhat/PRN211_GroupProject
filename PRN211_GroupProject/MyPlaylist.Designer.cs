namespace PRN211_GroupProject
{
    partial class MyPlaylist
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lbShowNumber = new System.Windows.Forms.Label();
            this.lbShowCreate = new System.Windows.Forms.Label();
            this.lbShowName = new System.Windows.Forms.Label();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnRemovePlaylist = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lstListSongs = new System.Windows.Forms.ListBox();
            this.lbListSongs = new System.Windows.Forms.Label();
            this.lbNumberOfSong = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(772, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(789, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(12, 42);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(451, 580);
            this.dgvPlaylist.TabIndex = 2;
            this.dgvPlaylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellClick);
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfo.Controls.Add(this.lbShowNumber);
            this.pInfo.Controls.Add(this.lbShowCreate);
            this.pInfo.Controls.Add(this.lbShowName);
            this.pInfo.Controls.Add(this.btnRemoveSong);
            this.pInfo.Controls.Add(this.btnRemovePlaylist);
            this.pInfo.Controls.Add(this.btnPlay);
            this.pInfo.Controls.Add(this.lstListSongs);
            this.pInfo.Controls.Add(this.lbListSongs);
            this.pInfo.Controls.Add(this.lbNumberOfSong);
            this.pInfo.Controls.Add(this.lbCreate);
            this.pInfo.Controls.Add(this.lbPlaylistName);
            this.pInfo.Controls.Add(this.lbInfo);
            this.pInfo.Location = new System.Drawing.Point(468, 42);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(403, 580);
            this.pInfo.TabIndex = 3;
            // 
            // lbShowNumber
            // 
            this.lbShowNumber.AutoSize = true;
            this.lbShowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowNumber.Location = new System.Drawing.Point(175, 147);
            this.lbShowNumber.Name = "lbShowNumber";
            this.lbShowNumber.Size = new System.Drawing.Size(0, 16);
            this.lbShowNumber.TabIndex = 15;
            // 
            // lbShowCreate
            // 
            this.lbShowCreate.AutoSize = true;
            this.lbShowCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowCreate.Location = new System.Drawing.Point(119, 104);
            this.lbShowCreate.Name = "lbShowCreate";
            this.lbShowCreate.Size = new System.Drawing.Size(0, 16);
            this.lbShowCreate.TabIndex = 14;
            // 
            // lbShowName
            // 
            this.lbShowName.AutoSize = true;
            this.lbShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowName.Location = new System.Drawing.Point(138, 59);
            this.lbShowName.Name = "lbShowName";
            this.lbShowName.Size = new System.Drawing.Size(0, 16);
            this.lbShowName.TabIndex = 13;
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSong.Location = new System.Drawing.Point(268, 524);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(118, 35);
            this.btnRemoveSong.TabIndex = 12;
            this.btnRemoveSong.Text = "Remove Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnRemovePlaylist
            // 
            this.btnRemovePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlaylist.Location = new System.Drawing.Point(130, 524);
            this.btnRemovePlaylist.Name = "btnRemovePlaylist";
            this.btnRemovePlaylist.Size = new System.Drawing.Size(138, 35);
            this.btnRemovePlaylist.TabIndex = 11;
            this.btnRemovePlaylist.Text = "Remove Playlist";
            this.btnRemovePlaylist.UseVisualStyleBackColor = true;
            this.btnRemovePlaylist.Click += new System.EventHandler(this.btnRemovePlaylist_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(19, 524);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 35);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play Playlist";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lstListSongs
            // 
            this.lstListSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListSongs.FormattingEnabled = true;
            this.lstListSongs.ItemHeight = 16;
            this.lstListSongs.Location = new System.Drawing.Point(19, 226);
            this.lstListSongs.Name = "lstListSongs";
            this.lstListSongs.Size = new System.Drawing.Size(367, 292);
            this.lstListSongs.TabIndex = 10;
            // 
            // lbListSongs
            // 
            this.lbListSongs.AutoSize = true;
            this.lbListSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListSongs.Location = new System.Drawing.Point(16, 189);
            this.lbListSongs.Name = "lbListSongs";
            this.lbListSongs.Size = new System.Drawing.Size(98, 18);
            this.lbListSongs.TabIndex = 9;
            this.lbListSongs.Text = "List Songs: ";
            // 
            // lbNumberOfSong
            // 
            this.lbNumberOfSong.AutoSize = true;
            this.lbNumberOfSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfSong.Location = new System.Drawing.Point(16, 145);
            this.lbNumberOfSong.Name = "lbNumberOfSong";
            this.lbNumberOfSong.Size = new System.Drawing.Size(153, 18);
            this.lbNumberOfSong.TabIndex = 8;
            this.lbNumberOfSong.Text = "Number Of Songs: ";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(16, 102);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(97, 18);
            this.lbCreate.TabIndex = 7;
            this.lbCreate.Text = "Created At: ";
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.AutoSize = true;
            this.lbPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylistName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPlaylistName.Location = new System.Drawing.Point(16, 57);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Size = new System.Drawing.Size(116, 18);
            this.lbPlaylistName.TabIndex = 6;
            this.lbPlaylistName.Text = "Playlist Name:";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbInfo.Location = new System.Drawing.Point(118, 13);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(158, 24);
            this.lbInfo.TabIndex = 5;
            this.lbInfo.Text = "PLAYLIST INFO";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 628);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 664);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "MyPlaylist";
            this.Text = "MyPlaylist";
            this.Load += new System.EventHandler(this.MyPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstListSongs;
        private System.Windows.Forms.Label lbListSongs;
        private System.Windows.Forms.Label lbNumberOfSong;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbPlaylistName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnRemovePlaylist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbShowName;
        private System.Windows.Forms.Label lbShowCreate;
        private System.Windows.Forms.Label lbShowNumber;
    }
}