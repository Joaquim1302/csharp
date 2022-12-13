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

        private void button1_Click(object sender, EventArgs e)
        {
            // ligação à base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = @"Data Source=E:\csharp\_db\Database_Files\teste.sdf";

            ligacao.Open();
            label_resultado.Text = "Ligação efetuada com sucesso!";

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM Filmes;", ligacao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            ligacao.Close();

            label_resultado.Text +=  "\nLinhas na tabela filmes: " + dados.Rows.Count.ToString();
        }
    }

}
