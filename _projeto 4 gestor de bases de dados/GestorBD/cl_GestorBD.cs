using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        string pasta_bd = "";
        string bd_password = "";

        //----------------------------------------------
        public cl_GestorBD() { }
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
        public void CriarBaseDados(string base_dados, bool verificar_arquivo = false)
        {
            // base_dados sempre terá o path completo do BD

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

            MessageBox.Show("Base de dados criada com sucesso!");
        }
    }
}
