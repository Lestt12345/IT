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
            this.label_signIn = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_pasword = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_forgetPass = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.button_signIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_signIn
            // 
            this.label_signIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_signIn.AutoSize = true;
            this.label_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_signIn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_signIn.Location = new System.Drawing.Point(56, 6);
            this.label_signIn.Name = "label_signIn";
            this.label_signIn.Size = new System.Drawing.Size(139, 42);
            this.label_signIn.TabIndex = 0;
            this.label_signIn.Text = "Sign in";
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_password.Location = new System.Drawing.Point(115, 155);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 31);
            this.textBox_password.TabIndex = 23;
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_login.Location = new System.Drawing.Point(115, 101);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 31);
            this.textBox_login.TabIndex = 22;
            // 
            // label_pasword
            // 
            this.label_pasword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pasword.AutoSize = true;
            this.label_pasword.BackColor = System.Drawing.Color.Transparent;
            this.label_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pasword.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_pasword.Location = new System.Drawing.Point(7, 157);
            this.label_pasword.Name = "label_pasword";
            this.label_pasword.Size = new System.Drawing.Size(114, 25);
            this.label_pasword.TabIndex = 21;
            this.label_pasword.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_login.Location = new System.Drawing.Point(7, 101);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(70, 25);
            this.label_login.TabIndex = 20;
            this.label_login.Text = "Login";
            // 
            // label_forgetPass
            // 
            this.label_forgetPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_forgetPass.AutoSize = true;
            this.label_forgetPass.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_forgetPass.Location = new System.Drawing.Point(124, 139);
            this.label_forgetPass.Name = "label_forgetPass";
            this.label_forgetPass.Size = new System.Drawing.Size(91, 13);
            this.label_forgetPass.TabIndex = 24;
            this.label_forgetPass.Text = "Forget password?";
            this.label_forgetPass.Click += new System.EventHandler(this.label_forgetPass_Click);
            // 
            // label_error
            // 
            this.label_error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error.Location = new System.Drawing.Point(9, 275);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(203, 25);
            this.label_error.TabIndex = 29;
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_signIn
            // 
            this.button_signIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_signIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_signIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_signIn.FlatAppearance.BorderSize = 0;
            this.button_signIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_signIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_signIn.ForeColor = System.Drawing.Color.GhostWhite;
            this.button_signIn.Location = new System.Drawing.Point(63, 218);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(92, 34);
            this.button_signIn.TabIndex = 28;
            this.button_signIn.Text = "Sign in";
            this.button_signIn.UseVisualStyleBackColor = false;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_error);
            this.panel1.Controls.Add(this.button_signIn);
            this.panel1.Controls.Add(this.label_forgetPass);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_login);
            this.panel1.Controls.Add(this.label_pasword);
            this.panel1.Controls.Add(this.label_login);
            this.panel1.Controls.Add(this.label_signIn);
            this.panel1.Location = new System.Drawing.Point(196, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 306);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_signIn;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_pasword;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_forgetPass;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button button_signIn;
        private System.Windows.Forms.Panel panel1;
    }
}

