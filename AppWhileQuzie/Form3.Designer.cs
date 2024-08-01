namespace AppWhileQuzie
{
    partial class Form3
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
            this.radioC3 = new System.Windows.Forms.RadioButton();
            this.radioB3 = new System.Windows.Forms.RadioButton();
            this.radioA3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioC3
            // 
            this.radioC3.AutoSize = true;
            this.radioC3.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC3.Location = new System.Drawing.Point(54, 159);
            this.radioC3.Name = "radioC3";
            this.radioC3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioC3.Size = new System.Drawing.Size(127, 30);
            this.radioC3.TabIndex = 9;
            this.radioC3.TabStop = true;
            this.radioC3.Text = " ชมรมจิ๊กซอ ";
            this.radioC3.UseVisualStyleBackColor = true;
            this.radioC3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioB3
            // 
            this.radioB3.AutoSize = true;
            this.radioB3.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB3.Location = new System.Drawing.Point(54, 118);
            this.radioB3.Name = "radioB3";
            this.radioB3.Size = new System.Drawing.Size(122, 30);
            this.radioB3.TabIndex = 8;
            this.radioB3.TabStop = true;
            this.radioB3.Text = " ชมรมจิ๊กฟา";
            this.radioB3.UseVisualStyleBackColor = true;
            // 
            // radioA3
            // 
            this.radioA3.AutoSize = true;
            this.radioA3.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA3.Location = new System.Drawing.Point(54, 73);
            this.radioA3.Name = "radioA3";
            this.radioA3.Size = new System.Drawing.Size(117, 30);
            this.radioA3.TabIndex = 7;
            this.radioA3.TabStop = true;
            this.radioA3.Text = " ชมรมจิ๊กเข้";
            this.radioA3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ชมรมดนตรีกลัวอะไร?";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioC3);
            this.Controls.Add(this.radioB3);
            this.Controls.Add(this.radioA3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioC3;
        private System.Windows.Forms.RadioButton radioB3;
        private System.Windows.Forms.RadioButton radioA3;
        private System.Windows.Forms.Label label1;
    }
}