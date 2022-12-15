using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AgendaSQL
{
    public partial class FrmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;

        //--------------------------------------------------
        public FrmAdicionarEditar(int id_contato = -1) // -1 evita ter que atribuir um parametro na instanciação
        {
            InitializeComponent();
            this.id_contato = id_contato;

            // definir se vou adicionar ou editar contato
            editar = id_contato == -1 ? false : true;
        }

        //--------------------------------------------------
        private void FrmAdicionarEditar_Load(object sender, EventArgs e)
        {
            // apresenta os dados do contato quando necessário
            if (editar)
                ApresentaContato();
        }

        //--------------------------------------------------
        private void ApresentaContato() 
        {
            // mostra o que vai ser editado
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            ligacao.Open();

            DataTable dados = new DataTable();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato = " +
                this.id_contato, ligacao);
            adapter.Fill(dados);
            ligacao.Dispose();

            // colocar os dados nos textboxes
            text_nome.Text = dados.Rows[0]["nome"].ToString();
            text_telefone.Text = dados.Rows[0]["telefone"].ToString();

        }

        //--------------------------------------------------
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " +
                Vars.base_dados);
            ligacao.Open();
            // grava novo registro ou edita registro editado
            #region VERIFICACOES
            if (text_nome.Text == "" || text_telefone.Text == "")
            {
                MessageBox.Show("Falta preencher todos os campos", "AgendaSQL",
                MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            #endregion

            //-------------------------------
            #region NOVO CONTATO
            if (!editar)
            {
                // buscar id contato disponível
                SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT MAX(id_contato) AS maxId FROM contatos;", ligacao);
                DataTable dados = new DataTable();
                adapter.Fill(dados);
                // verifica se maxId é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0])) //dados.Rows[0]["maxId"]
                    id_contato = 0;
                else 
                    id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1; 
                // gravar novo contato
                SqlCeCommand com = new SqlCeCommand();
                com.Connection = ligacao;

                // parametros
                com.Parameters.AddWithValue("@id_contato", id_contato);
                com.Parameters.AddWithValue("@nome", text_nome.Text);
                com.Parameters.AddWithValue("@telefone", text_telefone.Text);
                com.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                // verifica se já existe um contato com o mesmo nome e telefone
                adapter =  new SqlCeDataAdapter();
                dados = new DataTable();
                com.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                adapter.SelectCommand = com;
                adapter.Fill(dados);
                if (dados.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe um registro com o mesmo nome e telefone");
                    return;
                }


                // texto da query
                com.CommandText = "INSERT INTO contatos VALUES(" +
                    "@id_contato, @nome, @telefone, @atualizacao)";


                com.ExecuteNonQuery(); 
                com.Dispose();
                ligacao.Dispose();

                MessageBox.Show("Contato gravado com sucesso!");

                // limpa campos
                text_telefone.Text = "";
                text_nome.Text = "";
                text_nome.Focus();
             }
            #endregion
            //-------------------------------
            #region EDITAR CONTATO
            else
            {
                // edita o contato na bade de dados
                SqlCeCommand com = new SqlCeCommand();
                com.Connection = ligacao;

                // parametros
                com.Parameters.AddWithValue("@id_contato", id_contato);
                com.Parameters.AddWithValue("@nome", text_nome.Text);
                com.Parameters.AddWithValue("@telefone", text_telefone.Text);
                com.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                // verifica se existe registro com o mesmo nome e id_contato diferente
                DataTable dados = new DataTable();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                com.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";
                adapter.SelectCommand = com;
                adapter.Fill(dados);
                if (dados.Rows.Count != 0)
                {
                    // foi encontrado um registro como mesmo nome
                    if (MessageBox.Show("Já existe um registro com o mesmo nome." + 
                        "\nDeseja gravar assim mesmo?", "Agenda SQL",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                // editar o registro selecionado
                com.CommandText = "UPDATE contatos SET " +
                                    "nome = @nome, " +
                                    "telefone = @telefone, " +
                                    "atualizacao =  @atualizacao " +
                                    "WHERE id_contato = @id_contato";
                com.ExecuteNonQuery();

                // atualiza grid
                try // porque pode não estar aberto
                {
                    FrmResultados frm = new FrmResultados();
                    frm.ConstruirGrid();
                }
                finally
                {
                    // fecha o form
                    this.Close();
                }

            }
            #endregion

        }

        private void cnd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
