using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportApp.User;

namespace AirportApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (this.tbUsername.Text == "" || this.tbPassword.Text == "" || this.tbRepeatPassword.Text == "")
            {
                this.lblInfo.Text = "Missing information.";
                this.lblInfo.Show();
                this.tbPassword.Text = "";
                this.tbRepeatPassword.Text = "";
                return;
            }
            if (this.tbPassword.Text != this.tbRepeatPassword.Text)
            {
                this.lblInfo.Text = @"The passwords you entered did not match.";
                this.lblInfo.Show();
                this.tbPassword.Text = "";
                this.tbRepeatPassword.Text = "";
                return;
            }

            if (!this.tbPassword.Text.Any(char.IsDigit))
            {
                this.lblInfo.Text = @"The password must contain
at least one digit.";
                this.lblInfo.Show();
                this.tbPassword.Text = "";
                this.tbRepeatPassword.Text = "";
                return;
            }

            UserDao user = new UserDaoImplements();
            if (user.isExisting(this.tbUsername.Text))
            {
                this.lblInfo.Text = "User already existing.";
                this.lblInfo.Show();
                return;
            }
            User.User newUser = new User.User(this.tbUsername.Text, this.tbPassword.Text);
            user.addUser(newUser);
            this.Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbShowPassword.Checked)
            {
                this.tbPassword.PasswordChar = '\0';
                this.tbRepeatPassword.PasswordChar = '\0';
            }
            else
            {
                this.tbPassword.PasswordChar = '*';
                this.tbRepeatPassword.PasswordChar = '*';
            }
        }

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_Save_Click(sender, e);
            }
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_Save_Click(sender, e);
            }
        }

        private void tb_RepeatPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btn_Save_Click(sender, e);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

    }
}
