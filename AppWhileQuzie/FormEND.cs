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
    public partial class FormEND : Form
    {
        public FormEND()
        {
            InitializeComponent();
        }

        private void lascore_Click(object sender, EventArgs e)
        {
            //lascore.Text    =   FormHome.playername+"Score"+FormHome.score;
        }

        private void FormEND_Load(object sender, EventArgs e)
        {
            lascore.Text = FormHome.playername + "Score" + FormHome.score;
        }
    }
}
