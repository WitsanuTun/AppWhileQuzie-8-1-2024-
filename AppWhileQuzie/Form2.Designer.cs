namespace AppWhileQuzie
{
    partial class Form2
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
            this.radioC2 = new System.Windows.Forms.RadioButton();
            this.radioB2 = new System.Windows.Forms.RadioButton();
            this.radioA2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioC2
            // 
            this.radioC2.AutoSize = true;
            this.radioC2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC2.Location = new System.Drawing.Point(54, 160);
            this.radioC2.Name = "radioC2";
            this.radioC2.Size = new System.Drawing.Size(127, 30);
            this.radioC2.TabIndex = 9;
            this.radioC2.TabStop = true;
            this.radioC2.Text = "มดยางมะตอย";
            this.radioC2.UseVisualStyleBackColor = true;
            this.radioC2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioB2
            // 
            this.radioB2.AutoSize = true;
            this.radioB2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB2.Location = new System.Drawing.Point(54, 118);
            this.radioB2.Name = "radioB2";
            this.radioB2.Size = new System.Drawing.Size(115, 30);
            this.radioB2.TabIndex = 8;
            this.radioB2.TabStop = true;
            this.radioB2.Text = "มดทอระยิด ";
            this.radioB2.UseVisualStyleBackColor = true;
            this.radioB2.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // radioA2
            // 
            this.radioA2.AutoSize = true;
            this.radioA2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA2.Location = new System.Drawing.Point(54, 73);
            this.radioA2.Name = "radioA2";
            this.radioA2.Size = new System.Drawing.Size(119, 30);
            this.radioA2.TabIndex = 7;
            this.radioA2.TabStop = true;
            this.radioA2.Text = "มดทอระย้อย";
            this.radioA2.UseVisualStyleBackColor = true;
            this.radioA2.CheckedChanged += new System.EventHandler(this.radioA_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = " มดอะไรกัดเจ็บที่สุด?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AppWhileQuzie.Properties.Resources._360_F_609572261_p2z9hZecCkxWc8ntevpCZ4ytQHRoBBtL;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(247, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioC2);
            this.Controls.Add(this.radioB2);
            this.Controls.Add(this.radioA2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioC2;
        private System.Windows.Forms.RadioButton radioB2;
        private System.Windows.Forms.RadioButton radioA2;
        private System.Windows.Forms.Label label1;
    }
}