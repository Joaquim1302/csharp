using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe; //C:\Program Files\Microsoft SQL Server Compact Edition\v4.0\Desktop
using System.IO;
using System.Windows.Forms;

//------------------------------------------------------
// Classe que permite gerir bases de dados
// versão 1.0.0
//------------------------------------------------------
namespace GestorBD
{
    //--------------------------------------------------
    public class cl_GestorBD
    {
        SqlCeConnection ligacao;
        SqlCeCommand comando;
        SqlCeDataAdapter adapter;

        string strConn = "";
        string pasta_bd = @"E:\csharp\_db\Database_Files\";
        string bd_password = "";

        //----------------------------------------------
        public cl_GestorBD() { } // somente para poder usar algum método propriedade

        //----------------------------------------------
        public cl_GestorBD(string base_dados)
        {
            // definir connection string da ligação
            //strConn = "Data source = " + pasta_bd + base_dados + ".sdf; Password = " + bd_password;
            StringBuilder str = new StringBuilder();

            // define a base da strConn
            str.Append("Data source = ");

            // se existir pasta/localização definida
            if (pasta_bd != "")
            {
                str.Append(pasta_bd);
            }

            // acrescenta o nome da base de dados
            str.Append(base_dados + ".sdf");
            
            // adiciona a password se for necessário
            if (bd_password != "")
            {
                str.Append("; Password = " + bd_password);
            }

            // define a str Comm
            strConn = str.ToString();
        }

        //----------------------------------------------
        public void CriarBaseDados(string base_dados, List<string> instrucoes, bool verificar_arquivo = false)
        {
            // base_dados sempre terá o path completo do BD

            #region CRIAR ARQUIVO

            // criar uma base de dados nova
            #region VERIFICA EXISTÊNCIA DA BASE DE DADOS
            if (verificar_arquivo)
            {
                //  executa a verificação
                if (File.Exists(base_dados))
                {
                    if (MessageBox.Show("Existe uma base de dados com o mesmo nome" + 
                        "\nDeseja substituir a existente?",
                        "ATENÇÃO",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // apagar o arquivo
                        try
                        {
                            File.Delete(base_dados);
                        }
                        catch 
                        {
                            MessageBox.Show("Aconteceu um erro ao eliminar a base de dados.");
                            return;
                        }
                    }
                }
            }
            #endregion

            // inicialização da connectio string
            StringBuilder str =  new StringBuilder();
            str.Append("Data source = ");

            // nome do BD
            str.Append(base_dados);

            // verificar de tem password
            if (bd_password != "")
                str.Append("; Password = " + bd_password);
            
            // criação da base de dados
            SqlCeEngine motor = new SqlCeEngine(str.ToString());
            motor.CreateDatabase();

            #endregion

            #region CRIAÇÃO DAS TABELAS
            //--------------------------------------------------
            // criação das tabelas dentro da base de dados
            strConn = str.ToString();
            ligacao = new SqlCeConnection(strConn);
            ligacao.Open();
            comando = new SqlCeCommand();
            comando.Connection = ligacao;

            // executa as instruções para criar as tabelas
            str = null;
            foreach(string item in instrucoes)
            {
                if (item.StartsWith("CREATE TABLE")) 
                { 
                    // inicia a construção da query 
                    str = new StringBuilder();
                    str.Append(item);
                }
                else if (item == "END")
                {
                    // fechar a criação da query e executá-la
                    comando.CommandText = str.ToString();
                    comando.ExecuteNonQuery();
                }
                else
                {
                    // adicionar instrução ao stringbuilder
                    str.Append(item);
                }
            } 

            // fecha o comando e a ligação
            comando.Dispose();
            ligacao.Dispose();

            MessageBox.Show("Base de dados criada com sucesso!");

            #endregion
        }

        //----------------------------------------------
        public DataTable Exe_Reader(string query)
        {
            // ler ou pesquisar informações da base de dados
            // SELECT
            DataTable dados = new DataTable();
            adapter = new SqlCeDataAdapter(query, strConn);

            // executar a query
            try
            {
                adapter.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dados;
        }
        
    }
}
