namespace AppWhileQuzie
{
    partial class FormHome
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
            this.tplayer = new System.Windows.Forms.TextBox();
            this.bstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tplayer
            // 
            this.tplayer.BackColor = System.Drawing.SystemColors.Window;
            this.tplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplayer.Location = new System.Drawing.Point(236, 348);
            this.tplayer.Name = "tplayer";
            this.tplayer.Size = new System.Drawing.Size(137, 31);
            this.tplayer.TabIndex = 1;
            this.tplayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bstart
            // 
            this.bstart.BackColor = System.Drawing.Color.Transparent;
            this.bstart.BackgroundImage = global::AppWhileQuzie.Properties.Resources.images__1_;
            this.bstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bstart.Location = new System.Drawing.Point(251, 394);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(106, 63);
            this.bstart.TabIndex = 2;
            this.bstart.UseVisualStyleBackColor = false;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AppWhileQuzie.Properties.Resources.istockphoto_1223692043_612x612;
            this.ClientSize = new System.Drawing.Size(633, 482);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.tplayer);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tplayer;
        private System.Windows.Forms.Button bstart;
    }
}

