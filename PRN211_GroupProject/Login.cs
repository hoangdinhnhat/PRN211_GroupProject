using PRN211_GroupProject.Context;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Text;
            var user = UserService.gI().getByUsername(Username);

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                if (user != null)
                {
                    if (user.password.Equals(Password))
                    {
                        //Dang nhap thanh cong
                        var context = AuthenticationContext.gI();
                        context.setUser(user);
                        var homepage = new Homepage();
                        this.Hide();
                        homepage.Show();
                    }else MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Dang nhap that bai
                    MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lklbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
