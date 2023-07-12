namespace PRN211_GroupProject
{
    partial class Homepage
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
            this.lbHomepage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowPlayList = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnShowAllSongs = new System.Windows.Forms.Button();
            this.lbControl = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHomepage
            // 
            this.lbHomepage.AutoSize = true;
            this.lbHomepage.Font = new System.Drawing.Font("Arial", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomepage.Location = new System.Drawing.Point(322, 24);
            this.lbHomepage.Name = "lbHomepage";
            this.lbHomepage.Size = new System.Drawing.Size(174, 26);
            this.lbHomepage.TabIndex = 0;
            this.lbHomepage.Text = "MUSIC PLAYER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnShowPlayList);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnShowAllSongs);
            this.panel1.Controls.Add(this.lbControl);
            this.panel1.Location = new System.Drawing.Point(114, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 366);
            this.panel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(224, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Playlist";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowPlayList
            // 
            this.btnShowPlayList.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPlayList.Location = new System.Drawing.Point(224, 186);
            this.btnShowPlayList.Name = "btnShowPlayList";
            this.btnShowPlayList.Size = new System.Drawing.Size(122, 30);
            this.btnShowPlayList.TabIndex = 3;
            this.btnShowPlayList.Text = "My Playlist";
            this.btnShowPlayList.UseVisualStyleBackColor = true;
            this.btnShowPlayList.Click += new System.EventHandler(this.btnShowPlayList_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(224, 133);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(122, 30);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Song";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnShowAllSongs
            // 
            this.btnShowAllSongs.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllSongs.Location = new System.Drawing.Point(224, 79);
            this.btnShowAllSongs.Name = "btnShowAllSongs";
            this.btnShowAllSongs.Size = new System.Drawing.Size(124, 30);
            this.btnShowAllSongs.TabIndex = 1;
            this.btnShowAllSongs.Text = "All Songs";
            this.btnShowAllSongs.UseVisualStyleBackColor = true;
            this.btnShowAllSongs.Click += new System.EventHandler(this.btnShowAllSongs_Click);
            // 
            // lbControl
            // 
            this.lbControl.AutoSize = true;
            this.lbControl.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControl.Location = new System.Drawing.Point(234, 33);
            this.lbControl.Name = "lbControl";
            this.lbControl.Size = new System.Drawing.Size(114, 19);
            this.lbControl.TabIndex = 0;
            this.lbControl.Text = "Control Table";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(224, 298);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(122, 30);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "User Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbHomepage);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHomepage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShowPlayList;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnShowAllSongs;
        private System.Windows.Forms.Label lbControl;
        private System.Windows.Forms.Button btnProfile;
    }
}