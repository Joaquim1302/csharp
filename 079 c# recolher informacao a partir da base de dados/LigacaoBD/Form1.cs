using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Referencia SqlSeverCE
// C:\Program Files\Microsoft SQL Server Compact Edition\v4.0\Desktop\System.Data.SqlServerCe.dll
using System.Data.SqlServerCe;

namespace LigacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // conectar
            SqlCeConnection ligacao = new SqlCeConnection(@"Data Source=E:\csharp\_db\Database_Files\teste.sdf");
            ligacao.Open();

            // recolher dados | executar operações
            DataTable dados = new DataTable();
            SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM Filmes;", ligacao);
            operario.Fill(dados);

            // fechar
            ligacao.Close();

            // apresentar os dados
            //DataRow linha = dados.Rows[0];
            //MessageBox.Show(dados.Rows[0]["Titulo"].ToString() +
            //    "\n" + linha["Diretor"].ToString() +
            //    "\n" + linha["Ano"].ToString());

            foreach(DataRow linha in dados.Rows)
            {
                lista_dados.Items.Add(linha["Titulo"].ToString() +
                " - " + linha["Diretor"].ToString() +
                " - " + linha["Ano"].ToString()); 
            }
            //https://learn.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/style-rules/naming-rules

        }
    }

}
