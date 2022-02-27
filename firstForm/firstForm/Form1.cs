using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 30;
            int idade2 = 10;
            int idadeTotal = idade + idade2;
            idadeTotal += 100;

            float fl = 10.5f;
            decimal dec = 30.7m;
            double dbl = 30.7;

            int i = 1 / 3; // = 0
            decimal d = (decimal)1 / 3;

            string nome = "Joaquim";

            int nCaracteres = nome.Length;

            ctTexto.Text = nome + " " + nCaracteres.ToString();
        }
    }
}
