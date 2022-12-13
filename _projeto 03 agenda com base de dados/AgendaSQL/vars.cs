using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;

namespace AgendaSQL
{
    public static class Vars
    {
        public static string versao = "v.1.0.4";
        public static string pasta_dados;
        public static string base_dados;

        //-----------------------------------------
        public static void Iniciar()
        {
            // proceder aos mecanismos de inicialização da aplicação
            pasta_dados = @"E:\csharp\_db\Database_Files\AgendaSQL\";
            // verifica se a pasta existe se não existir, cria a pasta
            if(!Directory.Exists(pasta_dados))
                Directory.CreateDirectory(pasta_dados);
            // define base de dados
            base_dados = pasta_dados + "dados.sdf";
            // verifica se a base de dados existe
            if(!File.Exists(base_dados))
                CriarBaseDados();

        }

        //-----------------------------------------
        public static void CriarBaseDados()
        {
            // criação da base de dados using System.Data.SqlServerCe;
            SqlCeEngine motor = new SqlCeEngine("Data Source = " + base_dados);
            motor.CreateDatabase();
            
            // criar estrutura base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "Data Source = " + base_dados;
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText =
                "CREATE TABLE contatos(" + 
                    "id_contato      int not null primary key, " +
                    "nome            nvarchar(50), " +
                    "telefone        nvarchar(20), " +
                    "atualizacao     datetime)";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();
            comando.Dispose();

            ligacao.Dispose();
        }

    }

}
