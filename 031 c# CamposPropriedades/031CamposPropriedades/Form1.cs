using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _031CamposPropriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teste v = new Teste();

            v.Nome = textBox1.Text;
            v.Apresentar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teste v = new Teste();

            v.Nome2 = textBox1.Text;
            v.Apresentar();
        }
    }
}
