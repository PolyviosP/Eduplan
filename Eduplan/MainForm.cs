using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eduplan
{
    public partial class MainForm : Form
    {
        TestForm testform = new TestForm();
        private Panel panel;
        public MainForm()
        {
            InitializeComponent();
            panel = pythonPanel;
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void LessonButton_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = pythonPanel;
            panel.Show();
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
            panel.Hide();
            panel = GradesPanel;
            panel.Show();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.CloseProgram(sender, e);
        }
    }
}
