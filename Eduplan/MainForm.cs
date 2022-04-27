using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Eduplan
{
    public partial class MainForm : Form
    {
        TestForm testform = new TestForm();
        private Panel panel;
        public static Person user = new Person();

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
            List<int> Grades = new List<int>();
            Grades.Clear();
            panel.Hide();
            panel = GradesPanel;
            panel.Show();
            Grades = User.ReceiveGrades(Functions.loginAs);

            Functions.FixLabel(Test1label);
            Functions.FixLabel(Test2label);
            Functions.FixLabel(Test3label);
            Functions.FixLabel(Test4label);
            Functions.FixLabel(TestMOlabel);

            Test1label.Text = Grades[0].ToString() + Test1label.Text;
            Test2label.Text = Grades[1].ToString() + Test2label.Text;
            Test3label.Text = Grades[2].ToString() + Test3label.Text;
            Test4label.Text = Grades[3].ToString() + Test4label.Text;
            TestMOlabel.Text = ((Grades[0] + Grades[1] + Grades[2] + Grades[3]) / 4).ToString() + TestMOlabel.Text;
            
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelLogin.Text = LabelLogin.Text + " " + Functions.loginAs;
        }
    }
}
