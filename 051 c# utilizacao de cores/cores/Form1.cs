using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cores
{
    public partial class Form1 : Form
    {
        Color cor =  Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarCor()
        {
            cor = Color.FromArgb(trb_red.Value, trb_green.Value, trb_blue.Value);
            pictureBox1.BackColor = cor;
        }

        private void trb_red_Scroll(object sender, EventArgs e)
        {
            lb_red.Text = "R: " + trb_red.Value.ToString();
            MostrarCor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trb_green_Scroll(object sender, EventArgs e)
        {
            lb_green.Text = "G: " + trb_green.Value.ToString();
            MostrarCor();
        }

        private void trb_blue_Scroll(object sender, EventArgs e)
        {
            lb_blue.Text = "B: " + trb_blue.Value.ToString();
            MostrarCor();
        }
    }
}
