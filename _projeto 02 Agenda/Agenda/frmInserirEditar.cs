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

            // para permitir enter = tab 
            this.KeyPreview = true;
        }

        // ------------------------------------------
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------------------
        private void ConstroiLista()
        {
            //  adiciona à lista da contatos os contatos registrados
            lista_contatos.Items.Clear();

            foreach(Contato contato  in Geral.Lista_Contatos)
            {
                lista_contatos.Items.Add(contato.nome + " - " + contato.numero);
            }

            // atualiza o número de registros
            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count.ToString();
        }

        // ------------------------------------------
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            // insere um novo registro na lista

            // verifica se todos os campos estão preenchidos
            if(String.IsNullOrEmpty(text_nome.Text) ||
                String.IsNullOrEmpty(text_numero.Text))
            {
                MessageBox.Show("Os campos não estão todos preenchidos.");
                text_nome.Focus();
                return;
            }

            // verifica se existe registro igual
            foreach(Contato contato in Geral.Lista_Contatos)
            {
                if (contato.nome == text_nome.Text &&
                    contato.numero == text_numero.Text) 
                {
                    MessageBox.Show("Esse registro já existe", "ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // gravar novo registro
            Geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            // atualizar a lista
            ConstroiLista();

            // prepara as textbox para um novo registro
            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();
        }

        private void frmInserirEditar_KeyDown(object sender, KeyEventArgs e)
        {
            // enter = tab
            // adicionar this.KeyPreview = true; na tab propriedades ou
            // adicionar no construtor do form
            e.Handled= true;
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }
    }
}
