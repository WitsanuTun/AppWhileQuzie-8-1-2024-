using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWhileQuzie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (radioA.Checked)
            {
                FormHome.score  ++;
            } 
            Form2   form2 = new Form2();
            form2.Show();
            this.Close();   
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
