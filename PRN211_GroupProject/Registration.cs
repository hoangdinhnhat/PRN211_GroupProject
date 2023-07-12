using PRN211_GroupProject.Model;
using PRN211_GroupProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_GroupProject
{
    public partial class Registration : Form
    {
        UserService userService;

        public Registration()
        {
            InitializeComponent();
            userService = UserService.gI();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        public bool isEmpty(string text)
        {
            return text.Trim().Length == 0;
        }

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            bool isExistEmpty = isEmpty(txtFullName.Text) 
                && isEmpty(txtUserName.Text) 
                && isEmpty(txtPassword.Text) 
                && isEmpty(txtRePassword.Text);

            if (isExistEmpty)
            {
                MessageBox.Show("Please fill in all field!", "Notifcation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!cbFemale.Checked && !cbMale.Checked)
            {
                MessageBox.Show("Please choose your gender", "Notifcation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userService.getByUsername(txtUserName.Text) != null)
            {
                MessageBox.Show("Username is exist!", "Notifcation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("RePassword need to be equal password!", "Notifcation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool gender = cbMale.Checked;


            User user = new User()
            {
                fullName = txtFullName.Text,
                username = txtUserName.Text,
                password = txtPassword.Text,
                gender = gender,
                createdAt = DateTime.Now,
            };
            
            userService.save(user);
            MessageBox.Show("Registing successfully!", "Notifcation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
