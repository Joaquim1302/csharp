using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBD
{
    public partial class Form1 : Form
    {
        string bd_name = "loja2";
        public Form1()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD();

            // define as instruções das tabelas
            List<string> instrucoes = new List<string>()
            {
                // tabela clientes
                "CREATE TABLE clientes (",
                "id_cliente             int not null primary key,",
                "nome                   nvarchar(50),",
                "telefone               nvarchar(20),",
                "atualizacao            datetime)",
                "END",

                // tabela compras
                "CREATE TABLE compras (",
                "id_compras             int not null primary key,",
                "id_cliente             int,",
                "produto                nvarchar(50),",
                "quantidade             int,",
                "preco_unidade          int,",
                "atualizacao            datetime,",
                "FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)",
                "END"

            };

            gestor.CriarBaseDados(@"E:\csharp\_db\Database_Files\loja2.sdf", instrucoes, true);
        }

        //-------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            // abertuda da base de dados
            cl_GestorBD gestor = new cl_GestorBD(bd_name);

            // construção da lista de parametros
            List<cl_GestorBD.SQLParametros> param = new List<cl_GestorBD.SQLParametros>();
            param.Add(new cl_GestorBD.SQLParametros("@item_pesquisa", text_pesquisa.Text));

            // executa a query
            string query = "SELECT * FROM clientes WHERE nome = @item_pesquisa";
            DataTable dados = gestor.Exe_Reader(query, param);

        }

        //-------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD(bd_name);

            // criar lista de parametros
            List<cl_GestorBD.SQLParametros> parametros = new List<cl_GestorBD.SQLParametros>();
            parametros.Add(new cl_GestorBD.SQLParametros("@id_cliente", 1));
            parametros.Add(new cl_GestorBD.SQLParametros("@nome", "Carlos"));
            parametros.Add(new cl_GestorBD.SQLParametros("@telefone", "113564665456"));
            parametros.Add(new cl_GestorBD.SQLParametros("@atualizacao", DateTime.Now));

            gestor.Exe_Non_Query("INSERT INTO clientes VALUES(" +
                "@id_cliente, @nome, @telefone, @atualizacao)", parametros);

            // apresenta resultado
            MessageBox.Show("OK");
        }

        //-------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            // verificar se os campos estão preenchidos
            if (text_nome.Text == "" || text_telefone.Text == "")
            {
                MessageBox.Show("ERRO: Preencha todos os campos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // gravação do novo cliente na base de dados
            cl_GestorBD gestor = new cl_GestorBD(bd_name);

            // buscar ciente diponivel
            int id_cliente = gestor.Id_Disponivel("clientes","id_cliente");

            // parametros
            List<cl_GestorBD.SQLParametros> parametros = new List<cl_GestorBD.SQLParametros>();
            parametros.Add(new cl_GestorBD.SQLParametros("@id_cliente", id_cliente));
            parametros.Add(new cl_GestorBD.SQLParametros("@nome", text_nome.Text));
            parametros.Add(new cl_GestorBD.SQLParametros("@telefone", text_telefone.Text));
            parametros.Add(new cl_GestorBD.SQLParametros("@atualizacao", DateTime.Now));

            gestor.Exe_Non_Query("INSERT INTO clientes VALUES(" +
                "@id_cliente, @nome, @telefone, @atualizacao)", parametros);

            // apresenta resultado
            MessageBox.Show("OK");
        }

        //-------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            // 
            cl_GestorBD gestor = new cl_GestorBD(bd_name);
            DataTable dados = gestor.Preparar_DataTable("SELECT * FROM clientes");

            foreach(DataRow linha in dados.Rows)
            {
                // alterar telefone
                string novo_telefone  = "(01) " + linha["telefone"].ToString();
                linha["telefone"] = novo_telefone;
            }


            gestor.Gravar_DataTable(dados);
        }

        //-------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            // inserir novos clientes na base de dados
            List<string> lista_nomes = new List<string>();
            lista_nomes.Add("nome 1");
            lista_nomes.Add("nome 2");
            lista_nomes.Add("nome 3");
            lista_nomes.Add("nome 4");
            lista_nomes.Add("nome 5");

            List<string> lista_telefones = new List<string>();
            lista_telefones.Add("146546465");
            lista_telefones.Add("246546165465");
            lista_telefones.Add("365456156");
            lista_telefones.Add("46546431");
            lista_telefones.Add("512132165");

            cl_GestorBD gestorBD = new cl_GestorBD(bd_name);
            DataTable dados = gestorBD.Preparar_DataTable("SELECT * FROM clientes WHERE id_cliente = -1");

            int id_temp = gestorBD.Id_Disponivel("clientes", "id_cliente");

            // percorrer todos os nomes e adicionar a datatable
            for(int index = 0; index < lista_nomes.Count; index++)
            {
                DataRow nova_linha = dados.NewRow();
                nova_linha["id_cliente"] = id_temp;
                nova_linha["nome"] = lista_nomes[index];
                nova_linha["telefone"] = lista_telefones[index];
                dados.Rows.Add(nova_linha);
                id_temp++;
            }
            gestorBD.Gravar_DataTable(dados);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // compactar a base de dados
            cl_GestorBD gestor = new cl_GestorBD(bd_name);
            gestor.Compactar_Base_Dados();
            if (gestor.Compactar_Base_Dados())
            {
                MessageBox.Show("Base de dados compactada com sucesso!");
            }

        }
    }
}
