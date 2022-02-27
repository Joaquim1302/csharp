using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _025Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();
            p1.nome = "Joaquim";
            p1.sobrenome = "Marques";
            p1.idade = 58;
            p1.ApresentarSe();
        }
    }
}
