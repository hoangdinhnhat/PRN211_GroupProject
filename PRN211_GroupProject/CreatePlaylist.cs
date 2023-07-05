using PRN211_GroupProject.Model;
using PRN211_GroupProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_GroupProject
{
    public partial class CreatePlaylist : Form
    {
        PlayListService _playList;
        public CreatePlaylist()
        {
            InitializeComponent();
            _playList = PlayListService.gI();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            string newDesc = txtDesc.Text;
            DateTime newCreateDate = DateTime.Now;
            var newPlaylist = new PlayList
            {
                name = newName,
                description = newDesc,
                createdAt = newCreateDate,
                username = "hdnqt",
            };
            if (newPlaylist.name == "" || newPlaylist.description == "")
            {
                MessageBox.Show("Please enter all required information!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _playList.save(newPlaylist);
                this.Hide();
                var showPlayList = new MyPlaylist();
                showPlayList.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
