namespace PRN211_GroupProject
{
    partial class AllSong
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.dgvListSong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSongNameValue = new System.Windows.Forms.Label();
            this.lbSingerValue = new System.Windows.Forms.Label();
            this.lbYOPValue = new System.Windows.Forms.Label();
            this.lbPlay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPlayList = new System.Windows.Forms.ComboBox();
            this.btnAddToPlayList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(12, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(30, 38);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(646, 20);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.Text = "Search by name, singer, ...";
            this.txtSearchBar.Click += new System.EventHandler(this.txtSearchBar_Click);
            // 
            // dgvListSong
            // 
            this.dgvListSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSong.Location = new System.Drawing.Point(30, 79);
            this.dgvListSong.Name = "dgvListSong";
            this.dgvListSong.Size = new System.Drawing.Size(506, 322);
            this.dgvListSong.TabIndex = 2;
            this.dgvListSong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSong_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbPlayList);
            this.panel1.Controls.Add(this.btnAddToPlayList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbPlay);
            this.panel1.Controls.Add(this.lbYOPValue);
            this.panel1.Controls.Add(this.lbSingerValue);
            this.panel1.Controls.Add(this.lbSongNameValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(557, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 321);
            this.panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(682, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 20);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SONG SPECIFIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Song Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Singer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Of Public:";
            // 
            // lbSongNameValue
            // 
            this.lbSongNameValue.Location = new System.Drawing.Point(78, 44);
            this.lbSongNameValue.Name = "lbSongNameValue";
            this.lbSongNameValue.Size = new System.Drawing.Size(124, 38);
            this.lbSongNameValue.TabIndex = 4;
            this.lbSongNameValue.Text = "...";
            // 
            // lbSingerValue
            // 
            this.lbSingerValue.AutoSize = true;
            this.lbSingerValue.Location = new System.Drawing.Point(87, 92);
            this.lbSingerValue.Name = "lbSingerValue";
            this.lbSingerValue.Size = new System.Drawing.Size(16, 13);
            this.lbSingerValue.TabIndex = 5;
            this.lbSingerValue.Text = "...";
            // 
            // lbYOPValue
            // 
            this.lbYOPValue.AutoSize = true;
            this.lbYOPValue.Location = new System.Drawing.Point(87, 114);
            this.lbYOPValue.Name = "lbYOPValue";
            this.lbYOPValue.Size = new System.Drawing.Size(16, 13);
            this.lbYOPValue.TabIndex = 6;
            this.lbYOPValue.Text = "...";
            // 
            // lbPlay
            // 
            this.lbPlay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPlay.Location = new System.Drawing.Point(55, 148);
            this.lbPlay.Name = "lbPlay";
            this.lbPlay.Size = new System.Drawing.Size(106, 23);
            this.lbPlay.TabIndex = 7;
            this.lbPlay.Text = "Play This Song";
            this.lbPlay.UseVisualStyleBackColor = true;
            this.lbPlay.Click += new System.EventHandler(this.lbPlay_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(11, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 106);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PlayLists:";
            // 
            // cbPlayList
            // 
            this.cbPlayList.FormattingEnabled = true;
            this.cbPlayList.Location = new System.Drawing.Point(15, 227);
            this.cbPlayList.Name = "cbPlayList";
            this.cbPlayList.Size = new System.Drawing.Size(182, 21);
            this.cbPlayList.TabIndex = 1;
            // 
            // btnAddToPlayList
            // 
            this.btnAddToPlayList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddToPlayList.Location = new System.Drawing.Point(50, 269);
            this.btnAddToPlayList.Name = "btnAddToPlayList";
            this.btnAddToPlayList.Size = new System.Drawing.Size(111, 23);
            this.btnAddToPlayList.TabIndex = 2;
            this.btnAddToPlayList.Text = "ADD TO PLAYLIST";
            this.btnAddToPlayList.UseVisualStyleBackColor = true;
            this.btnAddToPlayList.Click += new System.EventHandler(this.btnAddToPlayList_Click);
            // 
            // AllSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListSong);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.btnBack);
            this.Name = "AllSong";
            this.Text = "AllSong";
            this.Load += new System.EventHandler(this.AllSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.DataGridView dgvListSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSingerValue;
        private System.Windows.Forms.Label lbSongNameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lbPlay;
        private System.Windows.Forms.Label lbYOPValue;
        private System.Windows.Forms.Button btnAddToPlayList;
        private System.Windows.Forms.ComboBox cbPlayList;
    }
}