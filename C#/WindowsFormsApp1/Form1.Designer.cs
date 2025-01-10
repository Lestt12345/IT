namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label_registration = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pasword = new System.Windows.Forms.Label();
            this.label_paswordAgain = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pasword = new System.Windows.Forms.TextBox();
            this.textBox_paswordAgain = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label_code = new System.Windows.Forms.Label();
            this.checkBox_rules = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_registration
            // 
            this.label_registration.AutoSize = true;
            this.label_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_registration.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_registration.Location = new System.Drawing.Point(339, 9);
            this.label_registration.Name = "label_registration";
            this.label_registration.Size = new System.Drawing.Size(154, 29);
            this.label_registration.TabIndex = 0;
            this.label_registration.Text = "Registration";
            this.label_registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_login.Location = new System.Drawing.Point(339, 112);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(48, 20);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login";
            // 
            // label_pasword
            // 
            this.label_pasword.AutoSize = true;
            this.label_pasword.BackColor = System.Drawing.Color.Transparent;
            this.label_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pasword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_pasword.Location = new System.Drawing.Point(339, 146);
            this.label_pasword.Name = "label_pasword";
            this.label_pasword.Size = new System.Drawing.Size(70, 20);
            this.label_pasword.TabIndex = 2;
            this.label_pasword.Text = "Pasword";
            // 
            // label_paswordAgain
            // 
            this.label_paswordAgain.AutoSize = true;
            this.label_paswordAgain.BackColor = System.Drawing.Color.Transparent;
            this.label_paswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_paswordAgain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_paswordAgain.Location = new System.Drawing.Point(339, 169);
            this.label_paswordAgain.Name = "label_paswordAgain";
            this.label_paswordAgain.Size = new System.Drawing.Size(70, 40);
            this.label_paswordAgain.TabIndex = 3;
            this.label_paswordAgain.Text = "Pasword\r\nagain";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_login.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_login.Location = new System.Drawing.Point(415, 114);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_pasword
            // 
            this.textBox_pasword.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_pasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pasword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_pasword.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_pasword.Location = new System.Drawing.Point(415, 146);
            this.textBox_pasword.Name = "textBox_pasword";
            this.textBox_pasword.PasswordChar = '*';
            this.textBox_pasword.Size = new System.Drawing.Size(100, 20);
            this.textBox_pasword.TabIndex = 5;
            // 
            // textBox_paswordAgain
            // 
            this.textBox_paswordAgain.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_paswordAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_paswordAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_paswordAgain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_paswordAgain.Location = new System.Drawing.Point(415, 172);
            this.textBox_paswordAgain.Name = "textBox_paswordAgain";
            this.textBox_paswordAgain.PasswordChar = '*';
            this.textBox_paswordAgain.Size = new System.Drawing.Size(100, 20);
            this.textBox_paswordAgain.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_email.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_email.Location = new System.Drawing.Point(410, 209);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(48, 20);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_email.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_email.Location = new System.Drawing.Point(344, 232);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(171, 20);
            this.textBox_email.TabIndex = 8;
            // 
            // textBox_code
            // 
            this.textBox_code.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_code.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_code.Location = new System.Drawing.Point(461, 266);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(54, 20);
            this.textBox_code.TabIndex = 9;
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.BackColor = System.Drawing.Color.Transparent;
            this.label_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_code.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_code.Location = new System.Drawing.Point(411, 266);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(47, 20);
            this.label_code.TabIndex = 10;
            this.label_code.Text = "Code";
            // 
            // checkBox_rules
            // 
            this.checkBox_rules.AutoSize = true;
            this.checkBox_rules.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox_rules.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox_rules.Location = new System.Drawing.Point(316, 292);
            this.checkBox_rules.Name = "checkBox_rules";
            this.checkBox_rules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_rules.Size = new System.Drawing.Size(229, 24);
            this.checkBox_rules.TabIndex = 11;
            this.checkBox_rules.Text = "Do you agree with our rules?";
            this.checkBox_rules.UseVisualStyleBackColor = true;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_submit.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_submit.FlatAppearance.BorderSize = 3;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_submit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_submit.Location = new System.Drawing.Point(385, 347);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(92, 34);
            this.button_submit.TabIndex = 12;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(432, 416);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 13;
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(874, 553);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_rules);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_paswordAgain);
            this.Controls.Add(this.textBox_pasword);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_paswordAgain);
            this.Controls.Add(this.label_pasword);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_registration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_registration;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pasword;
        private System.Windows.Forms.Label label_paswordAgain;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pasword;
        private System.Windows.Forms.TextBox textBox_paswordAgain;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.CheckBox checkBox_rules;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_error;
    }
}

