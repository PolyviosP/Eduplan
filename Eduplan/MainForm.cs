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
    public partial class MainForm : Form
    {
        TestForm testform = new TestForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void LessonButton_Click(object sender, EventArgs e)
        {

        }

        private void DiagonismataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            testform.previous_main = this;
            testform.Location = new Point(this.Location.X, this.Location.Y);
            testform.Show();
        }

        private void BathmoiButton_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
