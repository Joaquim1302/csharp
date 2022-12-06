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

namespace PastasArquivos
{
    public partial class Form1 : Form
    {
        string pasta_config = @"E:\csharp - João Ribeiro\_config\";
        string configFile = "config.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GravarConfiguracoes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verificar se o arquivo config.dat existe e grava novamente
            if (!File.Exists(pasta_config + configFile)) 
            {
                GravarConfiguracoes();
            }

            StreamReader arquivo = new StreamReader(pasta_config + configFile, 
                Encoding.Default);
            text_nome.Text = arquivo.ReadLine();
            dtp_data.Value = Convert.ToDateTime(arquivo.ReadLine());

            arquivo.Dispose();
        }

        private void GravarConfiguracoes()
        {
            // determinar se a pasta existe
            // se não existe é criada
            if (!Directory.Exists(pasta_config))
            {
                Directory.CreateDirectory(pasta_config);
                MessageBox.Show(pasta_config + "\n\n criado com sucesso!");
            }

            StreamWriter arquivo = new StreamWriter(pasta_config + configFile,
                false, Encoding.Default);
            arquivo.WriteLine(text_nome.Text);
            arquivo.WriteLine(dtp_data.Value.ToShortDateString());

            arquivo.Dispose();

            MessageBox.Show("Configurações gravadas com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // preenche nome
            if (String.IsNullOrEmpty(text_nome.Text))
                text_nome.Text = "Joca Bala";
            // get windows My Docs
            text_Mydocs.Text = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            ct_pathFrom.Text = "E:\\csharp - João Ribeiro\\_config\\config.dat";
            ct_pathTo.Text = @"E:\csharp - João Ribeiro\_config\bak\config.dat";
        }

        private void btn_moverArquivo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ct_pathTo.Text) || File.Exists(ct_pathTo.Text))
                MessageBox.Show("");
            else
                File.Move(ct_pathFrom.Text, ct_pathTo.Text);  
            
        }

        private void ct_moverTodos_Click(object sender, EventArgs e)
        {
            string pahtFrom = Path.GetDirectoryName(ct_pathFrom.Text);
            string[] listFiles = Directory.GetFiles(
                @"E:\csharp - João Ribeiro\_config\", "*.dat");
            foreach (string file in listFiles)
            {
                File.Move(file, pahtFrom + @"\bak\" + Path.GetFileName(file));
            }

        }
    }
}
