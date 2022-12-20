using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lsTeste.Items.Add("if");
            int i;
            for(i = 0; i < 10; i++)
            {
                lsTeste.Items.Add(i);
            }
            lsTeste.Items.Add("");

            lsTeste.Items.Add("while");

            //lsTeste.Items.Clear();
            i = 1;
            while (i <= 10)
            {
                lsTeste.Items.Add(i);
                i++;
            }

            lsTeste.Items.Add("do while");
            //lsTeste.Items.Clear();
            i = 10;
            do
            {
                lsTeste.Items.Add(i);
                i--;
            } while (i > 0);

            lsTeste.Items.Add("forreach");
            string str = "Joaquim Maques dos Santos Neto";
            foreach (char c in str)
            {
                lsTeste.Items.Add(c);
            };
            List<string> nomes = new List<string>
            {
                "Joaquim","Maques","dos" ,"Santos", "Neto"
            };
                
            foreach (string s in nomes)
            {
                lsTeste.Items.Add(s);
            };

            int[] vals = new int[]
            {
                10,9,8,7,6,5,4,3,2,1
            };
            foreach (int j in vals)
            {
                lsTeste.Items.Add(j);
            };
            for (int j=0; j<vals.Length;  j++)
            {
                lsTeste.Items.Add("j: " + j.ToString() + " -> " + vals[j]);
            };
        }
    }
}
