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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            // carrega os contatos
            Geral.ConstroiListaContatos();

            // apresenta a versão do programa
            label_versao.Text = Geral.versao;

            // abrir diretamente o formulário em desenvolvimento
            openInDevForm();
        }

        private void openInDevForm()
        {
            frmInserirEditar atualDevForm = new frmInserirEditar();
            atualDevForm.ShowDialog();

        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            // sair da aplicação

            // pergunta se o usuario quer mesmo sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No) return;
            else Application.Exit();


        }

        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            // abre quadro para gestão dos contatos
            frmInserirEditar frmEditar = new frmInserirEditar();
            frmEditar.ShowDialog();
        }
    }
}
