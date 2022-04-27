
namespace Eduplan
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.RegisterButton = new ePOSOne.btnProduct.Button_WOC();
            this.textview = new ePOSOne.btnProduct.Button_WOC();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ShowPasswordBox = new System.Windows.Forms.PictureBox();
            this.VerifyPasswordBox = new System.Windows.Forms.TextBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterButton.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.RegisterButton.Location = new System.Drawing.Point(230, 354);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterButton.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RegisterButton.Size = new System.Drawing.Size(351, 80);
            this.RegisterButton.TabIndex = 50;
            this.RegisterButton.Text = "Ολοκλήρωση εγγραφής";
            this.RegisterButton.TextColor = System.Drawing.Color.White;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // textview
            // 
            this.textview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.textview.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.textview.Enabled = false;
            this.textview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textview.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.textview.Location = new System.Drawing.Point(265, 32);
            this.textview.Name = "textview";
            this.textview.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.textview.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.textview.OnHoverTextColor = System.Drawing.Color.White;
            this.textview.Size = new System.Drawing.Size(281, 71);
            this.textview.TabIndex = 47;
            this.textview.Text = "Εγγραφή";
            this.textview.TextColor = System.Drawing.Color.White;
            this.textview.UseVisualStyleBackColor = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordBox.Location = new System.Drawing.Point(265, 207);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(281, 37);
            this.PasswordBox.TabIndex = 49;
            this.PasswordBox.Text = "Κωδικός πρόσβασης";
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.Gray;
            this.EmailBox.Location = new System.Drawing.Point(265, 141);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(281, 37);
            this.EmailBox.TabIndex = 48;
            this.EmailBox.Text = "Email";
            this.EmailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // ShowPasswordBox
            // 
            this.ShowPasswordBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordBox.ErrorImage")));
            this.ShowPasswordBox.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordBox.Image")));
            this.ShowPasswordBox.InitialImage = null;
            this.ShowPasswordBox.Location = new System.Drawing.Point(572, 207);
            this.ShowPasswordBox.Name = "ShowPasswordBox";
            this.ShowPasswordBox.Size = new System.Drawing.Size(48, 44);
            this.ShowPasswordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordBox.TabIndex = 52;
            this.ShowPasswordBox.TabStop = false;
            this.ShowPasswordBox.Click += new System.EventHandler(this.ShowPasswordBox_Click);
            this.ShowPasswordBox.MouseLeave += new System.EventHandler(this.ShowPasswordBox_MouseLeave);
            // 
            // VerifyPasswordBox
            // 
            this.VerifyPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.VerifyPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerifyPasswordBox.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.VerifyPasswordBox.ForeColor = System.Drawing.Color.Gray;
            this.VerifyPasswordBox.Location = new System.Drawing.Point(265, 276);
            this.VerifyPasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerifyPasswordBox.Name = "VerifyPasswordBox";
            this.VerifyPasswordBox.Size = new System.Drawing.Size(281, 37);
            this.VerifyPasswordBox.TabIndex = 53;
            this.VerifyPasswordBox.Text = "Κωδικός πρόσβασης";
            this.VerifyPasswordBox.Enter += new System.EventHandler(this.VerifyPasswordBox_Enter);
            this.VerifyPasswordBox.Leave += new System.EventHandler(this.VerifyPasswordBox_Leave);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC1.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC1.Enabled = false;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC1.Location = new System.Drawing.Point(23, 141);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(207, 44);
            this.button_WOC1.TabIndex = 54;
            this.button_WOC1.Text = "Email";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC2.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC2.Enabled = false;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC2.Location = new System.Drawing.Point(23, 207);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(207, 44);
            this.button_WOC2.TabIndex = 55;
            this.button_WOC2.Text = "Password";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC3.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC3.Enabled = false;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.button_WOC3.Location = new System.Drawing.Point(23, 276);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(207, 45);
            this.button_WOC3.TabIndex = 56;
            this.button_WOC3.Text = "Verify Password";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.button_WOC3);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.VerifyPasswordBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.textview);
            this.Controls.Add(this.ShowPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Φόρμα εγγραφής";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC RegisterButton;
        private ePOSOne.btnProduct.Button_WOC textview;
        private System.Windows.Forms.PictureBox ShowPasswordBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox VerifyPasswordBox;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
    }
}