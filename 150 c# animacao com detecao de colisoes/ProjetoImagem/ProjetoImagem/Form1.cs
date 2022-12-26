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
        int x = 50;
        int y = 50;
        int velocidade_x = 10;
        int velocidade_y = 10;

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
            tempo.Enabled = true;
            
        }

        private void Desenhar()
        {
            //cria uma folha em branco
            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);
            Graphics desenhador = Graphics.FromImage(imgback);
            Image bola = Image.FromFile(pasta_imagens + "takim.png");

            //atibuir uma cor de fundo a imagem
            desenhador.Clear(Color.Black);
            desenhador.DrawImage(bola, new Rectangle(x,y, 50, 50), new Rectangle(0, 0, 50, 50), GraphicsUnit.Pixel);
            


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

        private void tempo_Tick(object sender, EventArgs e)
        {
            x += velocidade_x;
            y += velocidade_y;

            //Colisões

            //detecta colisão com o fundo
            if (y+50 >= pic_teste.Height)
            {
                velocidade_y = -velocidade_y;
            }
            if (y<=0)
            {
                velocidade_y = -velocidade_y;
            }

            // dtecta colicao a esquerda
            if (x<=0)
            {
                velocidade_x = -velocidade_x;
            }
            if (x+50 >=pic_teste.Width)
            {
                velocidade_x = -velocidade_x;
            }

            Desenhar();
        }
    }
}
