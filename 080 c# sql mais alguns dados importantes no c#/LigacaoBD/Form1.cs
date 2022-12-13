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
            // havendo erro após a abertura de sqlConn poderá ser fechada no catch
            SqlCeConnection sqlConn = new SqlCeConnection();
            try
            {
                // buscar todos os dados da tabele
                sqlConn.ConnectionString = @"Data Source = E:\csharp\_db\Database_Files\dados.sdf";
                sqlConn.Open();

                // buscar dados
                DataTable dtTable = new DataTable();
                SqlCeDataAdapter sqlAdapter = new SqlCeDataAdapter("SELECT * FROM pessoas", sqlConn);
                sqlAdapter.Fill(dtTable);

                // apresentar dados
                foreach (DataRow dtRow in dtTable.Rows)
                {
                    lista_dados.Items.Add(dtRow["nome"].ToString() + " | " +
                        dtRow["endereco"].ToString() + " | " +
                        dtRow["telefone"].ToString());
                }

                sqlConn.Close();
            } 
            catch (Exception ex)
            {
                try
                {
                    sqlConn.Close();
                }
                finally
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }

}
