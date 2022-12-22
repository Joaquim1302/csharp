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

            #region CLÁUSULA WHERE
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

            // 03b usando função lambda
            //var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));
            //foreach (KeyValuePair<string, double> resultado in resultados)
            //    lista.Items.Add(resultado.Key + " - " + resultado.Value);
            #endregion

            #region REFERÊNCIA A CLASSES
            //----------------------------------
            // referência a classes
            // 01 resultado é uma lista de strings
            //var resultados1 = from aluno in lista_alunos
            //                 select aluno.nome;
            //foreach(string n in resultados1)
            //{
            //    lista.Items.Add(n);
            //}
            //lista.Items.Add("\n");

            //// 02 resultado é uma lista de ojetos da classe cl_alunos
            //var resultados2 = from aluno in lista_alunos
            //                 select aluno;
            //foreach (cl_alunos n in resultados2)
            //{
            //    lista.Items.Add("O aluno n.º " + n.numero + " é " + n.nome);
            //}
            //lista.Items.Add("\n");

            //// 03 resultado é uma lista de ojetos da classe cl_alunos
            //var resultados3 = from aluno in lista_alunos
            //                  select aluno;
            //foreach (cl_alunos n in resultados3)
            //{
            //    lista.Items.Add("O aluno n.º " + n.numero + " é " + n.nome);
            //}
            //lista.Items.Add("\n");

            //// 04 resultado é uma lista strings com a contatenação feita no select
            //var resultados4 = from aluno in lista_alunos
            //                  select "O aluno n.º " + 
            //                  aluno.numero + " é " +
            //                  aluno.nome;
            //foreach (string n in resultados4)
            //{
            //    lista.Items.Add(n);
            //}
            #endregion

            #region TIPOS ANÔNIMOS - SELECT COM NEW SEM CRIAR OBJETO
            //----------------------------------
            // tipos anônimos
            //var turmaA = from a in lista_alunos
            //             where a.nome.Contains("a")
            //             select new { num = a.numero, nom = a.nome, sex = a.sexo };
            //foreach (var aluno in turmaA)
            //    lista.Items.Add(aluno.nom);
            #endregion

            #region ORDENAÇÃO - CLÁUSULA ORDERBY
            //----------------------------------
            // 01 ordenação nomes de alunos sexo masculino
            //var turma1 = from aluno in lista_alunos
            //            where aluno.sexo == "masculino"
            //            orderby aluno.nome
            //            select aluno;
            //foreach (cl_alunos aluno in turma1)
            //    lista.Items.Add(aluno.nome);            

            // 02 ordenar pelo tamanho do nome
            //var turma2 = from aluno in lista_alunos
            //            where aluno.sexo == "masculino"
            //            orderby aluno.nome.Length
            //            select aluno;
            //foreach (cl_alunos aluno in turma2)
            //    lista.Items.Add(aluno.nome + " [" + aluno.nome.Length + "]");

            // 03 ordenar descendente pelo tamanho do nome
            //var turma3 = from aluno in lista_alunos
            //            where aluno.sexo == "masculino"
            //            orderby aluno.nome.Length descending
            //            select aluno;
            //foreach (cl_alunos aluno in turma3)
            //    lista.Items.Add(aluno.nome + " [" + aluno.nome.Length + "]");

            // 04 dictionary produto por preço
            //var produtos = from produto in lista_produtos
            //               orderby produto.Value ascending
            //               select produto;
            //foreach (KeyValuePair<string, double> produto in produtos)
            //    lista.Items.Add(produto.Key + ": " + produto.Value);

            // 05 dictionary produto por preço - lambda
            //var produtos5 = lista_produtos.OrderByDescending(i => i.Key);
            //foreach (KeyValuePair<string, double> produto in produtos5)
            //    lista.Items.Add(produto.Key + ": " + produto.Value);

            #endregion

            #region OPERADORES DE AGREGAÇÃO
            //----------------------------------
            //01 saber quantos alunos são do sexo feminino
            //int numero_alunas = (from aluno in lista_alunos
            //                     where aluno.sexo == "feminino"
            //                     select aluno).Count();
            //label_resultado.Text = string.Format("Esta turma tem {0} alunas.", numero_alunas);
            //var turma = lista_alunos.Where(s => s.sexo == "feminino");
            //int i = 1;
            //foreach (cl_alunos aluno in turma)
            //{
            //    lista.Items.Add(i + ": " + aluno.nome);
            //    i++;
            //}

            // 02 operador SUM
            //label_resultado.Text =  "A soma dos números é " + lista_numeros.Sum();
            //foreach (int v in lista_numeros)
            //    lista.Items.Add(v);

            // 03 operador MIN
            //int resultado = lista_nomes.Min(i => i.Length);
            //label_resultado.Text = "O menor nome da lista tem " + resultado + " caracteres";

            // 04 função AGERAGE
            //double media = lista_numeros.Average();
            //label_resultado.Text = media.ToString();

            #endregion

            #region CONTATENAÇÃO DE OERADORES LAMBDA
            // contatenação de operadores
            //label_resultado.Text =   lista_numeros.Where(i => i <= 15).Sum() + " é soma dos números menores que 15" +;
            //var numeros = lista_numeros.Where(i => i <= 15);
            //foreach (int i in numeros)
            //    lista.Items.Add(i);
            #endregion

            #region OPERADORES DE ELEMENTO

            // método FirstOrDefault
            //List<string> lista_teste = new List<string>() { };
            //label_resultado.Text = lista_teste.FirstOrDefault();

            // método ElementAt
            try
            {
                label_resultado.Text = lista_nomes.Where(i => i.Contains("Silva")).ElementAt(3); // se não existir dá erro
            }
            catch
            {
                label_resultado.Text = "Não existe";
            }
            var nomes = lista_nomes.Where(i => i.Contains("Silva"));
            foreach (string i in nomes)
                lista.Items.Add(i);
            #endregion


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

