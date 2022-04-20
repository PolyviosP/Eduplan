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
            List<CheckedListBox> D1_Checkboxes = new List<CheckedListBox>() { D1ListBox1, D1ListBox2, D1ListBox3, D1ListBox4, D1ListBox5 };
            List<string> D1 = new List<string>() { "Όχι", "Value", "bool", "50", "Όλα τα παραπάνω" };

            int vath = Functions.TestResults(D1_Checkboxes, D1);
            Console.WriteLine(vath);
            
        }
        private void FinishTest2Button_Click(object sender, EventArgs e)
        {
            List<CheckedListBox> D2_Checkboxes = new List<CheckedListBox>() { D2ListBox1, D2ListBox2, D2ListBox3, D2ListBox4, D2ListBox5 };
            List<string> D2 = new List<string>() { "Hello World", "Geia", @"print(A + "" "" + B)", "21", "10"};

            int vath = Functions.TestResults(D2_Checkboxes, D2);
            Console.WriteLine(vath);
        }
        private void FinishTest3Button_Click(object sender, EventArgs e)
        {
            List<CheckedListBox> D3_Checkboxes = new List<CheckedListBox>() {  };
            List<string> D3 = new List<string>() {  };

            int vath = Functions.TestResults(D3_Checkboxes, D3);
            Console.WriteLine(vath);
        }
        private void FinishFinalTestButton_Click(object sender, EventArgs e)
        {
            List<CheckedListBox> DF_Checkboxes = new List<CheckedListBox>() {  };
            List<string> DF = new List<string>() {  };

            int vath = Functions.TestResults(DF_Checkboxes, DF);
            Console.WriteLine(vath);
        }
        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.CloseProgram(sender, e);
        }
    }
}
