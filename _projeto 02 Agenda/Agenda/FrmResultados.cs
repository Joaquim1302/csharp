using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmResultados : Form
    {
        string texto;

        //------------------------------------------------------
        public FrmResultados(string texto)
        {
            InitializeComponent();

            // definir o texto de pesquisa
            this.texto = texto.ToUpper();
        }

        //------------------------------------------------------
        private void FrmResultados_Load(object sender, EventArgs e)
        {
            // executa a pesquisa e constroi a lista
            ExecutaPesquisa();
        }


        //------------------------------------------------------
        private void ExecutaPesquisa()
        {
            // realiza a pesquisa e apresenta os dados
            List<Contato> lista_resultados = new List<Contato>();

            foreach (Contato contato in Geral.Lista_Contatos) 
            {
                if (contato.nome.ToUpper().Contains(texto) ||
                    contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }
            // apresenta os resultados da pesquisa
            lstB_resultados.Items.Clear();
            foreach (Contato contato in lista_resultados)
            {
                lstB_resultados.Items.Add(contato.nome + " - " + 
                    contato.numero);
            }
            label_numero_registros.Text = "Registros: " + lista_resultados.Count.ToString();
        }


        //------------------------------------------------------
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            // fecha o form
            this.Close();
        }


        //------------------------------------------------------
        private void cmd_novaPesquisa_Click(object sender, EventArgs e)
        {
            FrmTexto frmTexto = new FrmTexto();
            frmTexto.ShowDialog();

            // quando o for é fechado ...
            if (frmTexto.cancelado) return;
            
            texto = frmTexto.texto.ToUpper();

            ExecutaPesquisa();

        }
    }
}
