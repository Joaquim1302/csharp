using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (i != 1)
            {
                lb1.Text = "i != 1";
            } else
            {
                lb1.Text = "i = 1";
            }

            string str = (i == 1) ? "SIM" : "NÃO";
            lb1.Text = str;

        }
    }
}
