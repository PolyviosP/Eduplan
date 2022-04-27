using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduplan
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textview.Select();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text.Trim() != "Email" && PasswordBox.Text.Trim() == VerifyPasswordBox.Text.Trim() && PasswordBox.Text.Trim() != "Κωδικός πρόσβασης")
            {
                User.WriteData(EmailBox.Text.Trim(), PasswordBox.Text.Trim());
                MessageBox.Show("Η Εγγραφή σας ήταν επιτυχής.", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else if (PasswordBox.Text.Trim() == VerifyPasswordBox.Text.Trim())
            {
                MessageBox.Show("Ο Κωδικός πρόσβασης και ο επιβεβαίωσης Κωδικός πρόσβασης δεν είναι ίδιοι.", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void VerifyPasswordBox_Enter(object sender, EventArgs e)
        {
            if (VerifyPasswordBox.Text == "Κωδικός πρόσβασης")
            {
                VerifyPasswordBox.Text = "";
                VerifyPasswordBox.ForeColor = Color.White;
                VerifyPasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void VerifyPasswordBox_Leave(object sender, EventArgs e)
        {
            if (VerifyPasswordBox.Text == "")
            {
                VerifyPasswordBox.Text = "Κωδικός πρόσβασης";
                VerifyPasswordBox.ForeColor = Color.Gray;
                VerifyPasswordBox.UseSystemPasswordChar = false;
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

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
