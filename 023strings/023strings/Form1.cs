using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string str = "Gosto muito de c# e espero realizar aplicações eficientes e bonitas no vs2017.";
            bool res = str.EndsWith(".");
            lbx.Items.Add(res.ToString());
            int x = str.IndexOf("c#");
            lbx.Items.Add(x.ToString());
            lbx.Items.Add(str.Replace('c','C'));

            string[] words = str.Split(' ');
            int i = 0;
            foreach (string w in words)
            {
                lbx.Items.Add("i[" + (++i).ToString() + "]: " + w);
            }
        }
    }
}
