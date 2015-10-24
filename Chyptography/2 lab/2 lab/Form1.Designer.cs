namespace _2_lab
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.button_view = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_run = new System.Windows.Forms.Button();
            this.comboBox_crypt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.Location = new System.Drawing.Point(13, 13);
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.Size = new System.Drawing.Size(178, 20);
            this.textBox_filepath.TabIndex = 0;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(197, 11);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 23);
            this.button_view.TabIndex = 1;
            this.button_view.Text = "View";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 41);
            this.textBox1.TabIndex = 2;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(12, 227);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(260, 23);
            this.button_run.TabIndex = 3;
            this.button_run.Text = "RUN";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // comboBox_crypt
            // 
            this.comboBox_crypt.FormattingEnabled = true;
            this.comboBox_crypt.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.comboBox_crypt.Location = new System.Drawing.Point(12, 39);
            this.comboBox_crypt.Name = "comboBox_crypt";
            this.comboBox_crypt.Size = new System.Drawing.Size(121, 21);
            this.comboBox_crypt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBox_crypt);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.textBox_filepath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.ComboBox comboBox_crypt;
    }
}

