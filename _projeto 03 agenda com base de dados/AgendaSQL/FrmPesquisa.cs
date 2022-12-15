using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class FrmPesquisa : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }

        //-------------------------------------------------------
        public FrmPesquisa()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            // exetuta a pesquisa apenas se existir texto na texbox
            if (text_pesquisa.Text == "")
            {
                cancelado = true;
            }
            else
            {
                texto_pesquisa = text_pesquisa.Text;
            }

   
            this.Close();
        }

        //-------------------------------------------------------
        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            //  fecha o form, cancelando a operação de pesquisa
            cancelado= true;
            this.Close();
        }

    }
}
