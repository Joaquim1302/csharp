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
        Image img_fundo;

        Image img_normal;   // botão normal
        Image img_high;     // quando o mouse passa por cima do botão
        Image img_disabled; // quando o botão está inativo

        public Form1()
        {

            InitializeComponent();
            
            pasta_images = Application.StartupPath + @"\images\";
            // carregamento da imagem de fundo
            img_fundo = Image.FromFile(pasta_images + "foto_1.jpg");

            // carregamento da imagem do botão
            //pic_teste.Image = img_fundo;

            img_normal = Image.FromFile(pasta_images + "btn_normal.png");
            img_high = Image.FromFile(pasta_images + "btn_high.png");
            img_disabled = Image.FromFile(pasta_images + "btn_disabled.png");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int imgW = img_fundo.Width;
            //int imgH = img_fundo.Height;

            //this.Size = new Size(671, 449);
            //this.BackgroundImage = img_fundo;


            //Rectangle rect = pic_teste.Bounds;

            cmd_teste.BackgroundImage = img_normal;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //int x = pic_teste.Location.X;
            //int y = pic_teste.Location.Y;
            //pic_teste.Location = new Point(x + 10, y - 10);

        }

        private void pic_teste_DoubleClick(object sender, EventArgs e)
        {
            // pic_teste.Location = new Point(pic_teste.Location.X - 10, pic_teste.Location.Y + 10);

            // criar a folha em branco
            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);
            Graphics desenhador =  Graphics.FromImage(imgback);

            // atribuir uma cor de fundo a imagem
            desenhador.Clear(Color.Yellow);

            // apresenta imagem final
            pic_teste.BackgroundImage = imgback;

        }

        private void cmd_teste_MouseEnter(object sender, EventArgs e)
        {
            cmd_teste.BackgroundImage = img_high;
        }

        private void cmd_teste_MouseLeave(object sender, EventArgs e)
        {
            cmd_teste.BackgroundImage = img_normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ativa e desativa o botão cmd_teste
            cmd_teste.Enabled = !cmd_teste.Enabled;
            if (cmd_teste.Enabled) 
                 cmd_teste.BackgroundImage = img_normal;
            else
                cmd_teste.BackgroundImage = img_disabled;
        }
    }
}
