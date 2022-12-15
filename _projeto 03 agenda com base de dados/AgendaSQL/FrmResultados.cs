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
using System.Runtime;

namespace AgendaSQL
{
    public partial class FrmResultados : Form
    {
        int id_contato;
        string item_pesquisa;

        //-------------------------------------------------------
        public FrmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }

        //-------------------------------------------------------
        public void ConstruirGrid()
        {
            // Constroi grid de registros

            // ligar à base de dados
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            ligacao.Open();

            string query = "SELECT * FROM contatos";
            if (item_pesquisa != "")
            {
                query += " WHERE nome LIKE @item OR telefone LIKE @item";
            }

            SqlCeCommand com = new SqlCeCommand();
            com.Parameters.AddWithValue("@item", "%" + item_pesquisa + "%");
            com.CommandText = query;
            com.Connection = ligacao;

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();          
            adapter.SelectCommand = com;
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            grid_resultados.DataSource = dados;

            // apresenta o número de registros na bd
            label_resultados.Text = "Resultatos: " + grid_resultados.RowCount.ToString();

            // esconder colunas id_contato e atualizacao
            grid_resultados.Columns["id_contato"].Visible = false;
            grid_resultados.Columns[3].Visible = false; // pode ser usado o número da coluna

            // alterar as dimensões das colunas
            grid_resultados.Columns["nome"].Width = CalcularLargura(70);
            grid_resultados.Columns["telefone"].Width = CalcularLargura(30);

            // controla a disponibilidade dos comandos
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;

        }

        //-------------------------------------------------------
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------------------
        private void FrmResultados_Load(object sender, EventArgs e)
        {
            ConstruirGrid();
        }

        //-------------------------------------------------------
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            // eliminar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + Vars.base_dados);
            ligacao.Open();

            SqlCeCommand cmd = new SqlCeCommand("DELETE FROM contatos WHERE id_contato = " +  
                this.id_contato, ligacao);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            ligacao.Dispose();

            // reconstruir o grid
            ConstruirGrid();
        }

        //-------------------------------------------------------
        private void grid_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmd_apagar.Enabled = e.RowIndex > 0;
            cmd_editar.Enabled = e.RowIndex > 0;
            if (cmd_apagar.Enabled)
                this.id_contato = Convert.ToInt16(grid_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            else
                this.id_contato = -1;
        }

        //-------------------------------------------------------
        private void cmd_editar_Click(object sender, EventArgs e)
        {
            FrmAdicionarEditar frm = new FrmAdicionarEditar(this.id_contato);
            frm.ShowDialog();

            // reconstruir o grid
            ConstruirGrid();

        }

        //-------------------------------------------------------
        private void cmd_vertudo_Click(object sender, EventArgs e)
        {
            // volta a apresentar todos os registros
            item_pesquisa = "";
            ConstruirGrid();
        }

        //-------------------------------------------------------
        private int CalcularLargura(int percent)
        {
            int largura_grid = grid_resultados.Width - 20; // 20 é alargura da scroll bar
            int res = (largura_grid * percent) / 100;
            return res;
        }
    }
}
