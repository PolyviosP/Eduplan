﻿
namespace Eduplan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BasicPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GradesButton = new System.Windows.Forms.Button();
            this.HomeworkButton = new System.Windows.Forms.Button();
            this.LessonButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BasicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BasicPanel
            // 
            this.BasicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.BasicPanel.Controls.Add(this.panel1);
            this.BasicPanel.Controls.Add(this.GradesButton);
            this.BasicPanel.Controls.Add(this.HomeworkButton);
            this.BasicPanel.Controls.Add(this.LessonButton);
            this.BasicPanel.Controls.Add(this.pictureBox);
            this.BasicPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BasicPanel.Location = new System.Drawing.Point(0, 0);
            this.BasicPanel.Name = "BasicPanel";
            this.BasicPanel.Size = new System.Drawing.Size(266, 741);
            this.BasicPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(266, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 662);
            this.panel1.TabIndex = 2;
            // 
            // GradesButton
            // 
            this.GradesButton.BackColor = System.Drawing.Color.Salmon;
            this.GradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GradesButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GradesButton.Location = new System.Drawing.Point(0, 367);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.Size = new System.Drawing.Size(266, 79);
            this.GradesButton.TabIndex = 6;
            this.GradesButton.Text = "Οι βαθμοί μου";
            this.GradesButton.UseVisualStyleBackColor = false;
            // 
            // HomeworkButton
            // 
            this.HomeworkButton.BackColor = System.Drawing.Color.Salmon;
            this.HomeworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeworkButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeworkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeworkButton.Location = new System.Drawing.Point(0, 294);
            this.HomeworkButton.Name = "HomeworkButton";
            this.HomeworkButton.Size = new System.Drawing.Size(266, 79);
            this.HomeworkButton.TabIndex = 2;
            this.HomeworkButton.Text = "Οι εργασίες μου";
            this.HomeworkButton.UseVisualStyleBackColor = false;
            // 
            // LessonButton
            // 
            this.LessonButton.BackColor = System.Drawing.Color.Salmon;
            this.LessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LessonButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LessonButton.Location = new System.Drawing.Point(0, 218);
            this.LessonButton.Name = "LessonButton";
            this.LessonButton.Size = new System.Drawing.Size(266, 79);
            this.LessonButton.TabIndex = 1;
            this.LessonButton.Text = "Μαθήματα";
            this.LessonButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = global::Eduplan.Properties.Resources.icon;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(44, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(181, 118);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label.Location = new System.Drawing.Point(31, 24);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(185, 26);
            this.Label.TabIndex = 0;
            this.Label.Text = "Συνδεδεμένος ως";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.TopPanel.Controls.Add(this.Label);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Location = new System.Drawing.Point(266, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1160, 79);
            this.TopPanel.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(266, 79);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1160, 662);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.linkLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 4160);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 2343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 189);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(28, 2009);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1394, 312);
            this.label5.TabIndex = 8;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 1507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 461);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 1371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(833, 130);
            this.label4.TabIndex = 6;
            this.label4.Text = "Πράξεις με αριθμούς\r\n\r\n\r\nΘα δώσουμε πολλαπλασιασμό και διαίρεση αριθμών και θα πά" +
    "ρουμε το αποτέλεσμα:\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(370, 1277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Κεφάλαιο 1 - Μεταβλητές";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(406, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Εισαγωγή στην Python";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel.Location = new System.Drawing.Point(287, 16);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(554, 41);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Γλώσσα προγραμματισμού python";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1078, 962);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(28, 2565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(806, 208);
            this.label6.TabIndex = 10;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 2792);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(323, 224);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(35, 3050);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 156);
            this.label7.TabIndex = 12;
            this.label7.Text = "Μη αποδεκτά ονόματα μεταβλητών:\r\n\r\n- 1number - αρχίζει με αριθμό.\r\n- number! - πε" +
    "ριέχει το !\r\n- class - είναι λέξη-κλειδί.\r\n\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1426, 741);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BasicPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Python+";
            this.BasicPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasicPanel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button GradesButton;
        private System.Windows.Forms.Button HomeworkButton;
        private System.Windows.Forms.Button LessonButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
    }
}

