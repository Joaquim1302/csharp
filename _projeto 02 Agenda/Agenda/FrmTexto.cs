using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmTexto : Form
    {
        // propriedade de controle
        public bool cancelado { get; set; }
        public string texto { get; set; }
        // { get; set; } permite definir e buscar seu próprio valor,
        // ou seja vai se comportar como uma variável pública


        // ------------------------------------------
        public FrmTexto()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        // ------------------------------------------
        private void cmd_Cancelar_Click(object sender, EventArgs e)
        {
            // cancela a pesquisa
            cancelado = true;
            this.Close();   
        }


        // ------------------------------------------
        private void cmd_pesquisa_Click(object sender, EventArgs e)
        {
            // define o texto e fecha o form
            if (String.IsNullOrEmpty(text_texto.Text)) return;

            texto = text_texto.Text;
            cancelado = false;
            this.Close();
        }


        // ------------------------------------------
        private void FrmTexto_KeyDown(object sender, KeyEventArgs e)
        {
            // enter = tab
            // adicionar this.KeyPreview = true; na tab propriedades ou
            // adicionar no construtor do form
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }
    }
}
