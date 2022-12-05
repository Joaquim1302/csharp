using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _030ClasseParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste obj = new teste();
            int v = 10;

            //obj.Min5(ref v);

            v = obj.Add(300);

            textBox1.Text = v.ToString();
        }
    }
}
