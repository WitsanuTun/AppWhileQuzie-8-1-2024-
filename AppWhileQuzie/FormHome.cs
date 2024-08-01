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
    public partial class FormHome : Form
    {
        public static int score = 0;
        public static String playername;
        public FormHome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bstart_Click(object sender, EventArgs e)
        {
            playername=tplayer.Text;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
