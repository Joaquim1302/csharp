using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retorno_Envio
{
    public partial class frm_1 : Form
    {
        string nome = null;
        public frm_1()
        {
            InitializeComponent();
        }

        private void cmd_avancar_Click(object sender, EventArgs e)
        {
            // define nome
            if( label_texto.Text != "")
                nome= label_texto.Text;

            frm_2 formulario = new frm_2(nome);
            formulario.ShowDialog();

            // código fica suspenso até retornar ao form_1 porque frm_2 foi
            // abertto com ShowDialog

            //regressando ...

            if (formulario.nome != null)
            {
                label_texto.Text = formulario.nome;
            }

        }
    }
}
