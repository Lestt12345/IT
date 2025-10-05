namespace WindowsFormsApp4
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
            this.label_hiName = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_sender = new System.Windows.Forms.Button();
            this.label_clicks = new System.Windows.Forms.Label();
            this.button_tap = new System.Windows.Forms.Button();
            this.label_power = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_hiName
            // 
            this.label_hiName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_hiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hiName.Location = new System.Drawing.Point(12, 9);
            this.label_hiName.Name = "label_hiName";
            this.label_hiName.Size = new System.Drawing.Size(776, 48);
            this.label_hiName.TabIndex = 0;
            this.label_hiName.Text = "Привет!";
            this.label_hiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(285, 79);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(244, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_sender
            // 
            this.button_sender.Location = new System.Drawing.Point(352, 105);
            this.button_sender.Name = "button_sender";
            this.button_sender.Size = new System.Drawing.Size(98, 30);
            this.button_sender.TabIndex = 2;
            this.button_sender.Text = "Отправить";
            this.button_sender.UseVisualStyleBackColor = true;
            this.button_sender.Click += new System.EventHandler(this.button_sender_Click);
            // 
            // label_clicks
            // 
            this.label_clicks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_clicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clicks.Location = new System.Drawing.Point(12, 232);
            this.label_clicks.Name = "label_clicks";
            this.label_clicks.Size = new System.Drawing.Size(776, 88);
            this.label_clicks.TabIndex = 3;
            this.label_clicks.Text = "Тыкни ниже ↓";
            this.label_clicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_tap
            // 
            this.button_tap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tap.Location = new System.Drawing.Point(294, 323);
            this.button_tap.Name = "button_tap";
            this.button_tap.Size = new System.Drawing.Size(219, 85);
            this.button_tap.TabIndex = 4;
            this.button_tap.Text = "Дуже Потужна кнопкА!!! XDXDXD ???";
            this.button_tap.UseVisualStyleBackColor = true;
            this.button_tap.Click += new System.EventHandler(this.button_tap_Click_1);
            // 
            // label_power
            // 
            this.label_power.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_power.Location = new System.Drawing.Point(12, 184);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(776, 48);
            this.label_power.TabIndex = 5;
            this.label_power.Text = "Потужность: 1";
            this.label_power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_power);
            this.Controls.Add(this.button_tap);
            this.Controls.Add(this.label_clicks);
            this.Controls.Add(this.button_sender);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_hiName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hiName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_sender;
        private System.Windows.Forms.Label label_clicks;
        private System.Windows.Forms.Button button_tap;
        private System.Windows.Forms.Label label_power;
    }
}

