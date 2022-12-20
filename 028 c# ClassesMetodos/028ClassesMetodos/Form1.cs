using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _028ClassesMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clMatematica calculadora = new clMatematica();

            int res = calculadora.Operacoes(10, 5, "-");

            textBox1.Text = res.ToString();

        }
    }
}
