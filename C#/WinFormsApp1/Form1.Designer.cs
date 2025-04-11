namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_From = new TextBox();
            label_From = new Label();
            label_To = new Label();
            textBox_To = new TextBox();
            button_From = new Button();
            button_To = new Button();
            progressBar = new ProgressBar();
            button_Copy = new Button();
            SuspendLayout();
            // 
            // textBox_From
            // 
            textBox_From.Location = new Point(68, 12);
            textBox_From.Name = "textBox_From";
            textBox_From.Size = new Size(203, 23);
            textBox_From.TabIndex = 0;
            // 
            // label_From
            // 
            label_From.AutoSize = true;
            label_From.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_From.Location = new Point(24, 13);
            label_From.Name = "label_From";
            label_From.Size = new Size(38, 17);
            label_From.TabIndex = 1;
            label_From.Text = "From";
            // 
            // label_To
            // 
            label_To.AutoSize = true;
            label_To.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_To.Location = new Point(24, 42);
            label_To.Name = "label_To";
            label_To.Size = new Size(22, 17);
            label_To.TabIndex = 3;
            label_To.Text = "To";
            // 
            // textBox_To
            // 
            textBox_To.Location = new Point(68, 41);
            textBox_To.Name = "textBox_To";
            textBox_To.Size = new Size(203, 23);
            textBox_To.TabIndex = 2;
            // 
            // button_From
            // 
            button_From.Location = new Point(277, 11);
            button_From.Name = "button_From";
            button_From.Size = new Size(75, 23);
            button_From.TabIndex = 4;
            button_From.Text = "File...";
            button_From.UseVisualStyleBackColor = true;
            button_From.Click += button_From_Click;
            // 
            // button_To
            // 
            button_To.Location = new Point(277, 40);
            button_To.Name = "button_To";
            button_To.Size = new Size(75, 23);
            button_To.TabIndex = 5;
            button_To.Text = "File...";
            button_To.UseVisualStyleBackColor = true;
            button_To.Click += button_To_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(27, 70);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(244, 23);
            progressBar.TabIndex = 6;
            // 
            // button_Copy
            // 
            button_Copy.Location = new Point(277, 70);
            button_Copy.Name = "button_Copy";
            button_Copy.Size = new Size(75, 23);
            button_Copy.TabIndex = 7;
            button_Copy.Text = "Copy";
            button_Copy.UseVisualStyleBackColor = true;
            button_Copy.Click += button_Copy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Copy);
            Controls.Add(progressBar);
            Controls.Add(button_To);
            Controls.Add(button_From);
            Controls.Add(label_To);
            Controls.Add(textBox_To);
            Controls.Add(label_From);
            Controls.Add(textBox_From);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_From;
        private Label label_From;
        private Label label_To;
        private TextBox textBox_To;
        private Button button_From;
        private Button button_To;
        private ProgressBar progressBar;
        private Button button_Copy;
    }
}
