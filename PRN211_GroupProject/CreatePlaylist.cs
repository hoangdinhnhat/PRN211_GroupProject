using PRN211_GroupProject.Context;
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
        private Form previous;
        PlayListService _playList;
        private User user;
        public CreatePlaylist(Form previous)
        {
            InitializeComponent();
            _playList = PlayListService.gI();
            user = AuthenticationContext.gI().getUser();
            this.previous = previous;
        }

        public bool isEmpty(string text)
        {
            return text.Length == 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            string newDesc = txtDesc.Text;
            if (isEmpty(newName) && isEmpty(newDesc))
            {
                MessageBox.Show("Please fill in all fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime newCreateDate = DateTime.Now;
            var newPlaylist = new PlayList
            {
                name = newName,
                description = newDesc,
                createdAt = newCreateDate,
                username = user.username,
            };
            if (newPlaylist.name == "" || newPlaylist.description == "")
            {
                MessageBox.Show("Please enter all required information!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _playList.save(newPlaylist);
                this.Hide();
                var showPlayList = new MyPlaylist(this);
                showPlayList.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }
    }
}
