using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            // @ para poder usar caracter \
            // bool append = true acrescenta linhas ao arquivo
            // bool append = false cria novo arquivo
            StreamWriter arquivo = new StreamWriter(@"E:\dados.txt", false, Encoding.Default);

            // string
            arquivo.WriteLine("Esta frase é alfanumérica.");

            // int
            int valor = 150;
            arquivo.WriteLine(valor);

            // bool
            bool res = false;
            arquivo.WriteLine(res);

            // data 
            arquivo.WriteLine(DateTime.Now);

            // cor
            Color cor = Color.FromArgb(30, 200, 180);
            arquivo.WriteLine(cor.ToArgb());


            arquivo.Dispose();
        }

        private void cmd_ler_Click(object sender, EventArgs e)
        {
            StreamReader arquivo = new StreamReader(@"E:\dados.txt", Encoding.Default);

            string a = arquivo.ReadLine();

            //int b = int.Parse(arquivo.ReadLine());
            int b = Convert.ToInt32(arquivo.ReadLine());

            bool c = bool.Parse(arquivo.ReadLine());

            DateTime d = DateTime.Parse(arquivo.ReadLine());
            MessageBox.Show(d.Year.ToString() + "/" + d.Month.ToString() + "/" + d.Day.ToString() );

            pictureBox1.BackColor = Color.FromArgb(int.Parse(arquivo.ReadLine()));

            arquivo.Dispose();


        }
    }
}
