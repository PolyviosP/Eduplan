using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eduplan
{
    public partial class LoginForm : Form
    {
        MainForm mainform = new MainForm();
        RegisterForm registerform = new RegisterForm();

        public LoginForm()
        {
            InitializeComponent();
            textview.Select();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (User.ReceiveDataForLogin(EmailBox.Text.Trim(), PasswordBox.Text.Trim()))
            {
                Functions.loginAs = EmailBox.Text.Trim();
                
                this.Hide();
                mainform.Location = new Point(this.Location.X, this.Location.Y);
                mainform.Show();
            }
            else
            {
                MessageBox.Show("To Email ή ο Κωδικός πρόσβασης είναι λάθος", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailBox_Enter(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Email")
            {
                EmailBox.Text = "";
                EmailBox.ForeColor = Color.White;
            }
        }

        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                EmailBox.Text = "Email";
                EmailBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Κωδικός πρόσβασης")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.White;
                PasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Κωδικός πρόσβασης";
                PasswordBox.ForeColor = Color.Gray;
                PasswordBox.UseSystemPasswordChar = false;
            }
        }

        private void ShowPasswordBox_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
        }

        private void ShowPasswordBox_MouseLeave(object sender, EventArgs e)
        {
            if (PasswordBox.Text != "Κωδικός πρόσβασης")
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerform.Show();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            registerform.Hide();
        }
    }
}
