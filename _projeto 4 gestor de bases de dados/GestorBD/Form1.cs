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
        public Form1()
        {
            InitializeComponent();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD("loja2");
            DataTable dados = gestor.Exe_Reader("SELECT * FROM clientes");

            MessageBox.Show(dados.Rows.Count.ToString());
        }
    }
}
