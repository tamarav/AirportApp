using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login(object sender, EventArgs e)
        {

            string username = tb_username.Text;
            string password = tb_password.Text;

            if (tb_username.Text == "" || tb_password.Text == "")
            {
                lbl_info.Show();
                tb_password.Text = "";
                return;
            }

            User.UserDao userDao = new User.UserDaoImplements();
            User.User user = userDao.getUser(username, password);

            if (user != null)
            {
                this.Hide();
                var form2 = new MainForm(user.Id);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                lbl_info.Text = "Wrong username or password";
                lbl_info.Show();
            }

        }

        private void registration(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form2 = new RegistrationForm();
            form2.ShowDialog();
        }

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.login(sender, e);
            }
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.login(sender, e);
            }
        }


    }
}
