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
        int indice;

        // ------------------------------------------
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
            lst_contatos.Items.Clear();

            foreach(Contato contato  in Geral.Lista_Contatos)
            {
                lst_contatos.Items.Add(contato.nome + " - " + contato.numero);
            }

            // atualiza o número de registros
            label_numero_registros.Text = "Registros: " + lst_contatos.Items.Count.ToString();

            // impedir edição e eliminação de registros
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
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

        // ------------------------------------------
        private void frmInserirEditar_KeyDown(object sender, KeyEventArgs e)
        {
            // para permitir enter = tab this.KeyPreview = true; na tab propriedades ou
            // adicionar no construtor do form
            e.Handled= true;
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        // ------------------------------------------
        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // -1 = nenhum selecionado
            if(lst_contatos.SelectedIndex != -1)
            {
                indice = lst_contatos.SelectedIndex;
                cmd_editar.Enabled = true;
                cmd_apagar.Enabled = true;
                //MessageBox.Show(lst_contatos.SelectedIndex.ToString());
            }
        }

        // ------------------------------------------
        private void apagarContato()
        {
            // remove a lista
            Geral.Lista_Contatos.RemoveAt(indice);
            // renova o arquivo
            Geral.GravarArquivo();
            // reconstroi a lista
            ConstroiLista();
        }        
        
        // ------------------------------------------
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            apagarContato();
        }

        // ------------------------------------------
        private void cmd_editar_Click(object sender, EventArgs e)
        {

            // prepara as textbox para um novo registro
            Contato contato = new Contato();
            Contato.partesContato(lst_contatos.Items[indice].ToString(), contato);

            text_nome.Text = contato.nome;
            text_numero.Text = contato.numero;
            text_nome.Focus();

            apagarContato();


        }

    }
}
