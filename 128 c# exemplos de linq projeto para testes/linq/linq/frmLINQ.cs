using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linq
{
    //=====================================================
    // projeto para testar instruções LINQ em C#
    //=====================================================
    public partial class frmLINQ : Form
    {
        List<int> lista_numeros;
        List<string> lista_nomes;
        Dictionary<string, double> lista_produtos;
        List<cl_alunos> lista_alunos;
        DataTable dados;

        //=================================================
        public frmLINQ()
        {
            InitializeComponent();

            //carrega os dados das coleções
            cl_colecoes colecoes = new cl_colecoes();
            lista_numeros = colecoes.lista_numeros;
            lista_nomes = colecoes.lista_nomes;
            lista_produtos = colecoes.lista_produtos;
            lista_alunos = colecoes.lista_alunos;
            dados = colecoes.dados;
        }

        //=================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            //apresenta o número de registos em cada coleção
            lista.Items.Add("lista_numeros = " + lista_numeros.Count + " números.");
            lista.Items.Add("lista_nomes = " + lista_nomes.Count + " nomes.");
            lista.Items.Add("lista_produtos = " + lista_produtos.Count + " produtos.");
            lista.Items.Add("lista_alunos = " + lista_alunos.Count + " alunos.");
            lista.Items.Add("dados (DataTable) = " + dados.Rows.Count + " linhas.");
        }

        //=================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //fecha a aplicação
            Application.Exit();
        }

        //=================================================
        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //execução dos testes
            lista.Items.Clear();
            label_resultado.Text = "";

            //----------------------------------
            // execução dos testes de linq
            //----------------------------------

            //----------------------------------
            // cláusula where

            // 01 seleção de  números
            //var numeros = from num in lista_numeros
            //              where num <= 10 ||  num >= 20
            //              select num;
            //foreach (int i in numeros)
            //    lista.Items.Add(i.ToString());

            // 02 seleção de nomes
            //var nomes = from nome in lista_nomes
            //            where nome.Contains("Marques") || nome.Contains("Ribeiro")
            //            select nome;
            //foreach(string n in nomes)
            //    lista.Items.Add((string)n);

            // 03 usando dicionário
            //var resultados = from item in lista_produtos
            //                 where item.Key.StartsWith("M")
            //                 select item;
            //foreach (KeyValuePair<string, double> resultado in resultados)
            //    lista.Items.Add(resultado.Key + " - " + resultado.Value);            

            // 04 usabdo dicionário
            var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));
            foreach (KeyValuePair<string, double> resultado in resultados)
                lista.Items.Add(resultado.Key + " - " + resultado.Value);

            //----------------------------------
            ////saber quantos alunos são do sexo feminino
            //int numero_alunas = (from aluno in lista_alunos
            //                     where aluno.sexo == "feminino"
            //                     select aluno).Count();
            ////label_resultado.Text = "Esta turma tem " + numero_alunas + " alunas.";
            //label_resultado.Text = string.Format("Esta turma tem {0} alunas.", numero_alunas);

            ////----------------------------------
            ////saber os resultados dos exames de matemática
            //var notas_matematica = from nota in lista_alunos
            //                       select nota.EXAMES[0];
            //foreach (var nota in notas_matematica)
            //    lista.Items.Add("Nota de matemática = " + nota.nota_exame);


            ////----------------------------------
            ////numero de alunas (lambda)
            //int numero_alunas = lista_alunos.Where(i => i.sexo == "feminino").Count();
            //label_resultado.Text = "Numero alunas: " + numero_alunas;

            ////----------------------------------
            ////lista de notas do exame de matemática (lambda)
            //var notas = lista_alunos.Select(i => i.EXAMES[0]);
            //foreach (var nota in notas)
            //    lista.Items.Add(nota.nota_exame);

            ////----------------------------------
            ////saber quantos alunos tiveram positiva no exame de matemática
            //int positivas_matematica = lista_alunos.Where(i => i.EXAMES[0].nota_exame >= 10).Count();
            //label_resultado.Text = string.Format("Na turma, {0} alunos tiveram positiva a Matemática.", positivas_matematica);

            ////----------------------------------
            ////saber quantos alunos tiveram positiva no exame de matemática
            //int positivas_matematica = (from aluno in lista_alunos
            //                            where aluno.EXAMES[0].nota_exame >= 10
            //                            select aluno).Count();
            //label_resultado.Text = string.Format("Na turma, {0} alunos tiveram positiva a Matemática.", positivas_matematica);

            ////----------------------------------
            ////média das notas do exame de matemática
            ////double media_matematica = lista_alunos.Average(i => i.EXAMES[0].nota_exame);
            //double media_matematica = (from aluno in lista_alunos
            //                           select aluno.EXAMES[0].nota_exame).Average();

            //label_resultado.Text = string.Format("A média dos exames de Matemática foi {0} valores.", media_matematica);

            ////----------------------------------
            //var notas_biologia = lista_alunos.Select(i => i.EXAMES[2].nota_exame);
            //foreach (var nota in notas_biologia)
            //    lista.Items.Add(nota);

            //----------------------------------
            //média das positivas de biologia
            //double media_biologia = lista_alunos.Where(i => i.EXAMES[2].nota_exame >= 10).Average(i => i.EXAMES[2].nota_exame);
            //label_resultado.Text = string.Format("A média das positivas de biologia é {0} valores.", media_biologia);

            ////----------------------------------
            ////média de notas de cada aluno
            //var notas = from aluno in lista_alunos
            //            select new
            //            {
            //                nome = aluno.nome,
            //                media = (aluno.EXAMES[0].nota_exame +
            //                         aluno.EXAMES[1].nota_exame +
            //                         aluno.EXAMES[2].nota_exame +
            //                         aluno.EXAMES[3].nota_exame) / 4
            //            };

            //foreach (var nota in notas)
            //    lista.Items.Add(nota.nome + " - " + nota.media);

            ////----------------------------------
            ////listagem de notas de matemática por ordem decrescente
            //var alunos = (

            //             from aluno in lista_alunos
            //             select new
            //             {
            //                 nome = aluno.nome,
            //                 nota_matematica = aluno.EXAMES[0].nota_exame
            //             }

            //             ).OrderByDescending(i => i.nota_matematica);

            //foreach (var aluno in alunos)
            //    lista.Items.Add(aluno.nome + " - " + aluno.nota_matematica);

            ////----------------------------------
            ////qual é o melhor aluno no geral
            //var alunos = (from aluno in lista_alunos
            //              select new
            //              {
            //                  nome = aluno.nome,
            //                  total_notas = aluno.EXAMES.Select(i => i.nota_exame).Sum()
            //              }
            //             ).OrderByDescending(i => i.total_notas);

            //foreach (var aluno in alunos)
            //    lista.Items.Add(string.Format("{0} tem um total de {1} valores.", aluno.nome, aluno.total_notas));


            //DATATABLE
            //foreach (DataRow linha in dados.Rows)
            //{
            //    lista.Items.Add(string.Format("id_cliente = {0} | nome_cliente = {1} | cidade = {2} | num. encomendas = {3}",
            //                    linha["id_cliente"].ToString(), linha["nome_cliente"].ToString(),
            //                    linha["cidade"].ToString(), linha["numero_encomendas"].ToString()));
            //}

            ////--------------------------------------------
            ////nomes dos clientes
            //var clientes = from cliente in dados.AsEnumerable()
            //               select cliente["nome_cliente"].ToString();
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente);

            //--------------------------------------------
            //nomes dos clientes
            //var clientes = (from cliente in dados.AsEnumerable()
            //                select cliente.Field<string>("nome_cliente")).OrderBy(i => i);

            //var clientes = (
            //               from cliente in dados.AsEnumerable()
            //               select new
            //               {
            //                   nome = cliente.Field<string>("nome_cliente")
            //               }
            //               ).OrderBy(i => i.nome);


            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome);

            //var clientes = (from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente["nome_cliente"].ToString(),
            //                    numero_encomendas = (int)cliente["numero_encomendas"]
            //                }).OrderByDescending(i => i.numero_encomendas);
            //foreach (var cliente in clientes)
            //    lista.Items.Add(string.Format("O cliente {0} tem {1} encomendas no total.",cliente.nome, cliente.numero_encomendas));

            //var clientes = from cliente in dados.AsEnumerable()
            //               where cliente.Field<string>("cidade") == "Paris"
            //               select new
            //               {
            //                   nome = cliente["nome_cliente"].ToString(),
            //                   cidade = cliente.Field<string>("cidade")
            //               };
            //foreach (var cliente in clientes)
            //    lista.Items.Add(cliente.nome + " - " + cliente.cidade);
        }
    }
}

