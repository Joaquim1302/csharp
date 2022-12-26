using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem
{
    public partial class Form1 : Form
    {
        string pasta_imagens = "";
        Image imgFundo;

        //criar botão com imagens 
        Image img_normal;  // botão normal
        Image img_high;   //quando o mouse passa sobre o botão 
        Image img_disabled;// quando o botão esta inativo

        //=================================================================
        public Form1()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\";


            img_normal = Image.FromFile(pasta_imagens + "btn_normal.png");
            img_high = Image.FromFile(pasta_imagens + "btn_high.png");
            img_disabled = Image.FromFile(pasta_imagens + "btn_disabled.png");

        }
        //=================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_teste.BackColor = Color.Transparent;
            //botão

            cmd_teste.BackgroundImage = img_normal;
            
        }
        //===============================================================
        private void pic_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture Box Clicada!");
        }

        //===============================================================
        private void cmd_teste_MouseEnter(object sender, EventArgs e)
        {
            //altera imagem para high
            cmd_teste.BackgroundImage = img_high;
        }
        //===============================================================
        private void cmd_teste_MouseLeave(object sender, EventArgs e)
        {
            //retorna ao aspecnto normal quando o mouse sair 
            cmd_teste.BackgroundImage = img_normal;
        }
        //===============================================================
        private void cmd_teste_Click(object sender, EventArgs e)
        {
            //back buffer é do directx
            //cria uma folha em branco
            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);
            Graphics desenhador = Graphics.FromImage(imgback);
            Image original = Image.FromFile(pasta_imagens + "foto_1.jpg");

            //atibuir uma cor de fundo a imagem
            desenhador.Clear(Color.White);

            //cortar e colar uma porção da imgem
            desenhador.DrawImage(original, new Rectangle(50,50, 50, 50),new Rectangle(90,100, 50, 50), GraphicsUnit.Pixel);
            desenhador.DrawImage(original, new Rectangle(150,50, 50, 50),new Rectangle(90,100, 100, 100), GraphicsUnit.Pixel);

            //apresenta a imagem final
            pic_teste.BackgroundImage = imgback;

        }
        //===============================================================
        private void cmd_teste_EnabledChanged(object sender, EventArgs e)
        {
            //define a imagem ativa ou inativa do botão personalizado
            if (cmd_teste.Enabled)
            {
                cmd_teste.BackgroundImage = img_normal;
            }
            else
            {
                cmd_teste.BackgroundImage = img_disabled;
            }
        }
    }
}
