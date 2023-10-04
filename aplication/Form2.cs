using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplication
{
    public partial class Form2 : Form
    {
        public bool resClose;
        public Form2()
        {
            InitializeComponent();
            Form1 main = this.Owner as Form1;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            resClose= true;
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            resClose = false;
            this.Close();
        }
    }
}
