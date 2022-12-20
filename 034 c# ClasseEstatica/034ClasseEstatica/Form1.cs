using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _034ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = estatica.NomePrograma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal obj1 = new normal();
            obj1.Nome = "Joaquim Marques";
            obj1.ApresentarNome();

            normal obj2 = new normal();
            obj2.Nome = "dos Santos";
            obj2.ApresentarNome();

            estatica.Nome = "Cecilia";
            estatica.ApresentarNome();

        }
    }
}
