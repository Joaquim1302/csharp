using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // array
            //string[] nomes;
            //nomes = new string[5];
            //nomes[0] = "Joaquim";
            //nomes[1] = "Marques";
            //nomes[2] = "dos";
            //nomes[3] = "Santos";
            //nomes[4] = "Neto";
            //listBox1.Items.AddRange(nomes);

            // coleção LIST
            List<string> listNomes = new List<string>();
            listNomes.Add("Alfa");
            listNomes.Add("Bravo");
            listNomes.Add("Charlie");
            listNomes.Add("Delta");
            listNomes.Add("Eco");
            listNomes.Add("Foxtrot");
            listNomes.Add("Golf");
            listNomes.Add("Hotel");
            listNomes.Add("India");
            listNomes.Add("Juliet");
            listNomes.Add("Kilo");
            listNomes.Add("Lima");
            listNomes.Add("Mike");
            listNomes.Add("November");
            listNomes.Add("Oscar");
            listNomes.Add("Papa");
            listNomes.Add("Quebec");
            listNomes.Add("Romel");
            listNomes.Add("Sierra");
            listNomes.Add("Tango");
            listNomes.Add("Uniform");
            listNomes.Add("Victor");
            listNomes.Add("Whiskey");
            listNomes.Add("X-ray");
            listNomes.Add("Yankee");
            listNomes.Add("Zulu");

            listNomes.Remove("Oscar");
            listNomes.RemoveAt(15);

            listBox1.Items.Clear();
            foreach (string nome in listNomes) 
            {
                listBox1.Items.Add(nome);
            }
            MessageBox.Show(listNomes[3] + "\n" +
                listNomes.Count.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> listNomes = new List<string>() {"Alfa", "Bravo", "Charlie", "Delta",
                "Eco", "Foxtrot", "Golf", "Hotel", "Alfa", "Bravo"};
            listBox1.Items.Clear();
            foreach (string nome in listNomes)
            {
                listBox1.Items.Add(nome);
            }
            MessageBox.Show(listNomes[3] + "\n" +
                listNomes.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // HashSet consegue gerenciar adição de valores repetidos
            HashSet<string> setNomes = new HashSet<string>()
            {  
                "Juliet", "Kilo", "Lima", "Mike", "Mike"
            };
            if (!setNomes.Add("Kilo"))
                MessageBox.Show("Kilo já exite e não foi adicionado.");

            listBox1.Items.Clear();
            foreach (string nome in setNomes)
            {
                listBox1.Items.Add(nome);
            }

        }
    }
}
