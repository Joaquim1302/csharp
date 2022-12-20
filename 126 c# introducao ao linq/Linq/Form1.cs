using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            List<string> lista_nomes = new List<string>();
            lista_nomes.Add("Joca");
            lista_nomes.Add("Baka");
            lista_nomes.Add("Hugo");
            lista_nomes.Add("Sabugo");
            lista_nomes.Add("Ramalho");
            lista_nomes.Add("Carvalho");
            lista_nomes.Add("Bocó");
            lista_nomes.Add("Socó");
            lista_nomes.Add("Khu Davoh");
            #endregion
            //foreach (string s in lista_nomes)
            //{
            //    if (s.StartsWith("B"))
            //        lista.Items.Add(s);
            //}

            // usando linq
            //var lista_final = lista_nomes.Where(i => i.StartsWith("B"));
            //foreach(var item in lista_final)
            //{
            //    lista.Items.Add(item);
            //}

            var lista_final1 = from i in lista_nomes     // var
                              where i.StartsWith("B")
                              select i;            
            var lista_final2 = (from i in lista_nomes   // List<string>
                                where i.StartsWith("B")
                                select i).ToList<string>();

            foreach (var i in lista_final2)
                lista.Items.Add(i);

            //lista.Items.Add(lista_final.First());
            //lista.Items.Add(lista_nomes.First());

            lista.Items.Add(lista_final2[0]);


        }
    }
}
