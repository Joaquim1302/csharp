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

        private void pic_teste_DoubleClick(object sender, EventArgs e)
        {
            // pic_teste.Location = new Point(pic_teste.Location.X - 10, pic_teste.Location.Y + 10);

            // criar a folha em branco
            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);
            Graphics desenhador =  Graphics.FromImage(imgback);

            // atribuir uma cor de fundo a imagem
            desenhador.Clear(Color.White);

            Pen lapis = new Pen(Color.Black, 3);
            Pen lapis_slateblue = new Pen(Color.SlateBlue, 3);

            //  desenhar uma linha
            //  horizontal
            //desenhador.DrawLine(lapis, new Point(50, 100), new Point(350, 100));
            // vertical
            //desenhador.DrawLine(lapis, new Point(50, 100), new Point(50, 200));
            // obliquas
            //desenhador.DrawLine(lapis, new Point(350, 100), new Point(50, 200));
            //desenhador.DrawLine(lapis, new Point(50, 100), new Point(350, 200));
            // fechando
            //desenhador.DrawLine(lapis, new Point(50, 200), new Point(350, 200));
            //desenhador.DrawLine(lapis, new Point(350, 200), new Point(350, 100));

            // linha quebrada
            //Point[] pontos = new Point[]
            //{
            //    new Point(50,50),
            //    new Point(100,100),
            //    new Point(100,150),
            //    new Point(400,150),
            //    new Point(200,200),
            //    new Point(200,20),
            //    new Point(50,50),
            //};
            //desenhador.DrawLines(lapis, pontos);

            // retagulo
            //desenhador.DrawRectangle(lapis, new Rectangle(50, 20, 200, 100));
            //desenhador.DrawRectangle(lapis, new Rectangle(50, 20, 100, 200));

            // circunferência
            //desenhador.DrawRectangle(lapis_bisque, new Rectangle(100, 100, 200, 200));
            //desenhador.DrawEllipse(lapis, new Rectangle(100, 100, 200, 200));
            // elipse
            //desenhador.DrawEllipse(lapis, new Rectangle(300, 20, 150, 250));


            // preenchimento
            //Brush pincel1 = new SolidBrush(Color.SlateBlue);
            //desenhador.FillRectangle(pincel1, new Rectangle(400, 20, 150, 250));    
            //Brush pincel2 = new LinearGradientBrush(new Point(50,50), new Point(350,50), Color.Purple,   Color.SlateBlue);
            //desenhador.FillRectangle(pincel2, new Rectangle(50, 50, 300, 250));            

            // preenchimento 2
            //Brush pincel1 = new SolidBrush(Color.Purple);
            //Brush pincel2 = new LinearGradientBrush(new Point(150, 50), new Point(250, 50), Color.Purple, Color.SlateBlue);
            //Brush pincel3 = new SolidBrush(Color.SlateBlue);
            //desenhador.FillRectangle(pincel1, new Rectangle(050, 50, 100, 250));    
            //desenhador.FillRectangle(pincel2, new Rectangle(150, 50, 100, 250));
            //desenhador.FillRectangle(pincel3, new Rectangle(250, 50, 100, 250));  

            // preenchimento 3
            //Brush pincel1 = new SolidBrush(Color.Purple);
            //Brush pincel2 = new LinearGradientBrush(new Point(150, 50), new Point(250, 50), Color.Purple, Color.SlateBlue);
            //Brush pincel3 = new SolidBrush(Color.SlateBlue);
            //desenhador.FillEllipse(pincel1, new Rectangle(050, 50, 100, 250));    
            //desenhador.FillEllipse(pincel2, new Rectangle(150, 50, 100, 250));
            //desenhador.FillEllipse(pincel3, new Rectangle(250, 50, 100, 250));
            //desenhador.DrawRectangle(lapis_slateblue, new Rectangle(050, 50, 100, 250));    
            //desenhador.DrawRectangle(lapis_slateblue, new Rectangle(150, 50, 100, 250));
            //desenhador.DrawRectangle(lapis_slateblue, new Rectangle(250, 50, 100, 250));

            // desenhar texto
            //string texto = "BRASIL ACIMA DE TUDO!";
            //Font letra = new Font("ArmyStamp", 75, FontStyle.Regular | FontStyle.Italic, GraphicsUnit.Pixel);
            //Brush cor = new SolidBrush(Color.Yellow);
            //Point inicio = new Point(53, 53);
            //desenhador.DrawString(texto, letra, cor, inicio);
            //letra = new Font("ArmyStamp", 75, FontStyle.Regular | FontStyle.Italic, GraphicsUnit.Pixel);
            //cor = new SolidBrush(Color.SeaGreen);
            //inicio = new Point(50, 50);
            //desenhador.DrawString(texto, letra, cor, inicio);

            //letra = new Font("ArmyStamp", 75, FontStyle.Regular | FontStyle.Italic, GraphicsUnit.Pixel);
            //cor = new SolidBrush(Color.SeaGreen);
            //inicio = new Point(53, 93);
            //desenhador.DrawString(texto, letra, cor, inicio);
            //letra = new Font("ArmyStamp", 75, FontStyle.Regular | FontStyle.Italic, GraphicsUnit.Pixel);
            //cor = new SolidBrush(Color.Yellow);
            //inicio = new Point(50, 90);
            //desenhador.DrawString(texto, letra, cor, inicio);

            //determinar um local especifico para que o texto aparece 
            string texto = "Lorem ipsum luctus odio lectus nulla vestibulum faucibus porta mi volutpat.";
            Brush cor = new SolidBrush(Color.Black);
            Font letra = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            Rectangle ret = new Rectangle(50, 50, 500, 100);

            //Alinhamento do texto
            StringFormat alinhamento = new StringFormat();
            alinhamento.Alignment = StringAlignment.Center;// near = perto ou a esquerda
            alinhamento.LineAlignment = StringAlignment.Center;// near = perto ou a top
            // cria a borda
            desenhador.DrawRectangle(lapis, ret);
            //cria o retangulo com o texto dentro
            desenhador.DrawString(texto, letra, cor, ret, alinhamento);

            // apresenta imagem final
            pic_teste.BackgroundImage = imgback;

        }



    }
}
