using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tbDarkTheme.Checked) 
            {
                this.BackColor = Color.DimGray;
                label1.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                label1.ForeColor = Color.DimGray;
            }

        }


    }
}
