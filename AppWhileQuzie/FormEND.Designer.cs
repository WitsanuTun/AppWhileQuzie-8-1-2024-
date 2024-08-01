namespace AppWhileQuzie
{
    partial class FormEND
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
            this.lascore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lascore
            // 
            this.lascore.AutoSize = true;
            this.lascore.BackColor = System.Drawing.Color.Transparent;
            this.lascore.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lascore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lascore.Location = new System.Drawing.Point(12, 9);
            this.lascore.Name = "lascore";
            this.lascore.Size = new System.Drawing.Size(167, 15);
            this.lascore.TabIndex = 0;
            this.lascore.Text = "Your Score :     ";
            this.lascore.Click += new System.EventHandler(this.lascore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppWhileQuzie.Properties.Resources._294331093;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 316);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormEND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppWhileQuzie.Properties.Resources._1000_F_527488145_kMOGbZg0KFNMUgpMNO1T5ZkvP1wLW6KO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lascore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEND";
            this.Text = "FormEND";
            this.Load += new System.EventHandler(this.FormEND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lascore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}