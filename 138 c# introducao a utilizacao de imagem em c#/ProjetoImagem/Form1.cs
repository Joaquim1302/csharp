using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem
{
    public partial class Form1 : Form
    {
        string pasta_images = "";

        public Form1()
        {

            InitializeComponent();
            
            pasta_images = Application.StartupPath + @"\images\";
            // carregamento da imagem de fundo

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(pasta_images + "foto_1.jpg");
        }
    }
}
