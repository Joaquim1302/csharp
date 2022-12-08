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
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConstroiLista()
        {
            //  adiciona à lista da contatos os contatos registrados
            lista_contatos.Items.Clear();

            foreach(Contato contato  in Geral.ListaContatos)
            {
                lista_contatos.Items.Add(contato.nome + " - " + contato.numero);
            }

            // atualiza o número de registros
            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count.ToString();
        }
    }
}
