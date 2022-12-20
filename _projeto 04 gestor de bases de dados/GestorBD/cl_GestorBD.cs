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
        SqlCeCommand com;
        SqlCeDataAdapter adapter;
        SqlCeDataAdapter temp_adapter;

        string strConn = "";
        string pasta_bd = @"E:\csharp\_db\Database_Files\";
        string bd_password = "";

        //----------------------------------------------
        // cria a classe de paramatros de SQL
        public class SQLParametros
        {
            public string param { get; set; }
            public object valor { get; set; }

            public SQLParametros(string param, object valor) 
            { 
                this.param = param;
                this.valor = valor;
            }

        }

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
            com = new SqlCeCommand();
            com.Connection = ligacao;

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
                    com.CommandText = str.ToString();
                    com.ExecuteNonQuery();
                }
                else
                {
                    // adicionar instrução ao stringbuilder
                    str.Append(item);
                }
            } 

            // fecha o comando e a ligação
            com.Dispose();
            ligacao.Dispose();

            MessageBox.Show("Base de dados criada com sucesso!");

            #endregion
        }

        //----------------------------------------------
        public DataTable Exe_Reader(string query, List<SQLParametros> parametros)
        {
            // ler ou pesquisar informações da base de dados
            // SELECT
            DataTable dados = new DataTable();
            adapter = new SqlCeDataAdapter(query, strConn);
            adapter.SelectCommand.Parameters.Clear();

            // executar a query
            try
            {
                // insere os parametros na query
                if (parametros != null)
                {
                    foreach (SQLParametros p in parametros)
                        adapter.SelectCommand.Parameters.AddWithValue(p.param, p.valor);
                }

                adapter.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dados;
        }

        //----------------------------------------------
        public void Exe_Non_Query(string query, List<SQLParametros> parametros = null)
        {
            // executar queries do tipo INSERT, DELETE, UPDATE, etc...
            ligacao = new SqlCeConnection(strConn);
            ligacao.Open();

            com = new SqlCeCommand(query, ligacao);
            com.Parameters.Clear();

            try
            {
                // adição dos parametros no comando
                if ( parametros != null)
                    foreach(SQLParametros p in parametros) 
                        com.Parameters.AddWithValue(p.param, p.valor);

                // executar a query
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // destruir com e ligação
            com.Dispose();
            ligacao.Dispose();
        }

        //----------------------------------------------
        public int Id_Disponivel(string tabela, string coluna)
        {
            // devolve o id disponivel para o próximo registro
            int idtemp = -1;
            ligacao= new SqlCeConnection(strConn);
            ligacao.Open();

            string query = "SELECT MAX(" + coluna + ") AS MaxID FROM " + tabela;
            DataTable dados = new DataTable();  
            adapter = new SqlCeDataAdapter(query, strConn);
            adapter.Fill(dados);

            // verifica se é DBNull
            if (dados.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    idtemp = 0;
                else
                    idtemp = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }

            

            ligacao.Dispose();
            return idtemp;
        }

        //----------------------------------------------
        public DataTable Preparar_DataTable(string query)
        {
            temp_adapter = new SqlCeDataAdapter(query, strConn);
            DataTable dados = new DataTable();
            try
            {
                temp_adapter.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dados;
        }

        //----------------------------------------------
        public void Gravar_DataTable(DataTable dados)
        {
            // atualiza a informação na base de dados
            SqlCeCommandBuilder cmd = new SqlCeCommandBuilder(temp_adapter);
            temp_adapter.UpdateCommand = cmd.GetUpdateCommand();

            try
            {
                temp_adapter.Update(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            temp_adapter.Dispose();
        }

        //----------------------------------------------
        public bool Compactar_Base_Dados()
        {
            // compacta a base de dados
            bool concluido = false;

            try
            {
                SqlCeEngine motor = new SqlCeEngine();
                motor.LocalConnectionString = strConn;
                motor.Compact(strConn);
                concluido = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return concluido;
        }

    }
}
