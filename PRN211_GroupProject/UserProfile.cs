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
    public partial class UserProfile : Form
    {
        private Form previous;
        private User user;
        private UserService userService;
        public UserProfile(Form previous)
        {
            InitializeComponent();
            userService = UserService.gI();
            user = AuthenticationContext.gI().getUser();
            this.previous = previous;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            lbDate.Text = user.createdAt.ToString();
            lbUsertxt.Text = user.username;
            txtFullname.Text = user.fullName;
            txtPassword.Text = user.password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fullName = txtFullname.Text;
            string password = txtPassword.Text;
            user.fullName = fullName;
            user.password = password;
            userService.update(user);
            MessageBox.Show("Update profile successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
