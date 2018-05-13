namespace SerialReader
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Led1CheckBox = new System.Windows.Forms.CheckBox();
            this.Led2CheckBox = new System.Windows.Forms.CheckBox();
            this.Led3CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 263);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Led1CheckBox
            // 
            this.Led1CheckBox.AutoSize = true;
            this.Led1CheckBox.Location = new System.Drawing.Point(408, 55);
            this.Led1CheckBox.Name = "Led1CheckBox";
            this.Led1CheckBox.Size = new System.Drawing.Size(53, 17);
            this.Led1CheckBox.TabIndex = 1;
            this.Led1CheckBox.Text = "LED1";
            this.Led1CheckBox.UseVisualStyleBackColor = true;
            this.Led1CheckBox.CheckedChanged += new System.EventHandler(this.Led1CheckBox_CheckedChanged);
            // 
            // Led2CheckBox
            // 
            this.Led2CheckBox.AutoSize = true;
            this.Led2CheckBox.Location = new System.Drawing.Point(408, 78);
            this.Led2CheckBox.Name = "Led2CheckBox";
            this.Led2CheckBox.Size = new System.Drawing.Size(53, 17);
            this.Led2CheckBox.TabIndex = 2;
            this.Led2CheckBox.Text = "LED2";
            this.Led2CheckBox.UseVisualStyleBackColor = true;
            this.Led2CheckBox.CheckedChanged += new System.EventHandler(this.Led2CheckBox_CheckedChanged);
            // 
            // Led3CheckBox
            // 
            this.Led3CheckBox.AutoSize = true;
            this.Led3CheckBox.Location = new System.Drawing.Point(408, 101);
            this.Led3CheckBox.Name = "Led3CheckBox";
            this.Led3CheckBox.Size = new System.Drawing.Size(53, 17);
            this.Led3CheckBox.TabIndex = 3;
            this.Led3CheckBox.Text = "LED3";
            this.Led3CheckBox.UseVisualStyleBackColor = true;
            this.Led3CheckBox.CheckedChanged += new System.EventHandler(this.Led3CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 364);
            this.Controls.Add(this.Led3CheckBox);
            this.Controls.Add(this.Led2CheckBox);
            this.Controls.Add(this.Led1CheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Serial Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox Led1CheckBox;
        private System.Windows.Forms.CheckBox Led2CheckBox;
        private System.Windows.Forms.CheckBox Led3CheckBox;
    }
}

