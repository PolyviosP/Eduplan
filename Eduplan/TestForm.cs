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
    public partial class TestForm : Form
    {
        public MainForm previous_main;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestFinalButton_Click(object sender, EventArgs e)
        {

        }

        private void Test3Button_Click(object sender, EventArgs e)
        {

        }

        private void Test2Button_Click(object sender, EventArgs e)
        {

        }

        private void Test1Button_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previous_main.Location = new Point(this.Location.X, this.Location.Y);
            previous_main.Show();
        }
    }
}
