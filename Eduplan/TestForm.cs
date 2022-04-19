using DocumentFormat.OpenXml.Office2010.Excel;
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
        private Panel panel;

        public TestForm()
        {
            InitializeComponent();
            panel = Test1panel;
        }

        private void TestFinalButton_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = TestFinalpanel;
            panel.Show();
        }

        private void Test3Button_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = Test3panel;
            panel.Show();
        }

        private void Test2Button_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = Test2panel;
            panel.Show();
        }

        private void Test1Button_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = Test1panel;
            panel.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previous_main.Location = new Point(this.Location.X, this.Location.Y);
            previous_main.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            List<CheckedListBox> D1_Checkboxes = new List<CheckedListBox>() { checkedListBox1, checkedListBox2, checkedListBox3, checkedListBox4, checkedListBox5 };
            List<string> D1 = new List<string>() { "Όχι", "Value", "bool", "50", "Όλα τα παραπάνω" };

            int v = Functions.RefreshBoxes(D1_Checkboxes, D1);
            Console.WriteLine(v);
            
        }
        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.CloseProgram(sender, e);
        }
    }
}
