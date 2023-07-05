namespace PRN211_GroupProject
{
    partial class SongPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongPlayer));
            this.pnl = new System.Windows.Forms.Panel();
            this.lbSingerValue = new System.Windows.Forms.Label();
            this.lbSongNameValue = new System.Windows.Forms.Label();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbPlayingSong = new System.Windows.Forms.Label();
            this.wpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.lbSingerValue);
            this.pnl.Controls.Add(this.lbSongNameValue);
            this.pnl.Controls.Add(this.lbSinger);
            this.pnl.Controls.Add(this.lbSongName);
            this.pnl.Controls.Add(this.lbPlayingSong);
            this.pnl.Location = new System.Drawing.Point(588, 9);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(204, 119);
            this.pnl.TabIndex = 7;
            // 
            // lbSingerValue
            // 
            this.lbSingerValue.AutoSize = true;
            this.lbSingerValue.Location = new System.Drawing.Point(91, 67);
            this.lbSingerValue.Name = "lbSingerValue";
            this.lbSingerValue.Size = new System.Drawing.Size(16, 13);
            this.lbSingerValue.TabIndex = 7;
            this.lbSingerValue.Text = "...";
            // 
            // lbSongNameValue
            // 
            this.lbSongNameValue.AutoSize = true;
            this.lbSongNameValue.Location = new System.Drawing.Point(91, 44);
            this.lbSongNameValue.Name = "lbSongNameValue";
            this.lbSongNameValue.Size = new System.Drawing.Size(16, 13);
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
            this.lbSongName.Location = new System.Drawing.Point(10, 44);
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
            this.lbPlayingSong.Size = new System.Drawing.Size(109, 16);
            this.lbPlayingSong.TabIndex = 1;
            this.lbPlayingSong.Text = "PLAYING SONG";
            // 
            // wpPlayer
            // 
            this.wpPlayer.Enabled = true;
            this.wpPlayer.Location = new System.Drawing.Point(11, 8);
            this.wpPlayer.Name = "wpPlayer";
            this.wpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wpPlayer.OcxState")));
            this.wpPlayer.Size = new System.Drawing.Size(563, 404);
            this.wpPlayer.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(8, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 25);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SongPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.wpPlayer);
            this.Controls.Add(this.btnBack);
            this.Name = "SongPlayer";
            this.Text = "SongPlayer";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wpPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lbSingerValue;
        private System.Windows.Forms.Label lbSongNameValue;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbPlayingSong;
        private AxWMPLib.AxWindowsMediaPlayer wpPlayer;
        private System.Windows.Forms.Button btnBack;
    }
}