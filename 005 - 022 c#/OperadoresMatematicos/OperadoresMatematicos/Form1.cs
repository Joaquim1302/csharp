using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresMatematicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            //int p1 = int.Parse(ctParcela1.Text);
            //int p2 = int.Parse(ctParcela2.Text);
            //int res;

            //// adição
            //res = p1 + p2;
            //// subtração
            //res = p1 - p2;
            //// multiplicação
            //res = p1 * p2;
            //// divisão
            //res = p1 / p2;

            int res = 0;


            lbResultado.Text = (res++).ToString(); // 0
            lbResultado.Text = (++res).ToString(); // 1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "";
        }
    }
}
