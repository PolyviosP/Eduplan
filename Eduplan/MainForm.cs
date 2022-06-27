using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Drawing;
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
            panel = panelVideo;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelLogin.Text = LabelLogin.Text + " " + Functions.loginAs;

            video1.URL = @".\Videos\PythonStarted.mp4";
            video1.Ctlcontrols.play();
            video2.URL = @".\Videos\Python Variables.mp4";
            video2.Ctlcontrols.stop();
            video3.URL = @".\Videos\Pyton If Elif Else Statement.mp4";
            video3.Ctlcontrols.stop();
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            panel.Hide();
            panel = panelVideo;
            panel.Show(); 
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
            try
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

            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {

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
