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
                        MessageBox.Show("Login successfully", "Thong bao", MessageBoxButtons.OK);
                        this.Hide();

                        var homepage = new Homepage();
                        homepage.Show();
                    }
                }
                else
                {
                    //Dang nhap that bai
                    MessageBox.Show("Incorrect username or password", "Thong bao", MessageBoxButtons.OK);
                }
            }
        }
    }
}
