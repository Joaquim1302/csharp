using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Agenda
{
    public static class Geral
    {
        public const string DIR_AGENDA = @"E:\csharp\_config";
        public const string PATH_AGENDA = @"E:\csharp\_config\agenda.txt";
        public static string versao = "v1.0.0";

        // lista de contatos
        public static List<Contato> Lista_Contatos;

        // ------------------------------------------
        public static void ConstroiListaContatos()
        {
            // instancia a lista
            Lista_Contatos = new List<Contato>();

            // verificar se o arquivo existe
            if (File.Exists(PATH_AGENDA))
            {
                StreamReader arqAgenda = new StreamReader(PATH_AGENDA, Encoding.Default);

                while (!arqAgenda.EndOfStream)
                {
                    // le nome
                    string nome =  arqAgenda.ReadLine();
                    // le fone
                    string numero = arqAgenda.ReadLine();

                    // adicionar à lista de contatos o contato carregado
                    Contato novo_contato = new Contato();
                    novo_contato.nome = nome;
                    novo_contato.numero= numero;

                    Lista_Contatos.Add(novo_contato);


                }

                arqAgenda.Dispose();
            }
        }
        
        // ------------------------------------------
        public static void GravarNovoRegistro(string _nome, string _numero)
        {
            // gravar novo resgistro (na lista e no arquivo)
            //Contato novo = new Contato();
            //novo.nome = _nome;
            //novo.numero = _numero;
            //Lista_Contatos.Add(novo);
            //ou da forma abaixo, forma in line da
            //construção da classe Contato, da  mesma forma
            Lista_Contatos.Add(new Contato() { nome = _nome, numero = _numero});

            // atualiza o arquivo
            GravarArquivo();


        }
        
        // ------------------------------------------
        public static void GravarArquivo()
        {
            StreamWriter arquivo = new StreamWriter(PATH_AGENDA, false, Encoding.Default);

            foreach(Contato contato in Lista_Contatos)
            {
                arquivo.WriteLine(contato.nome);
                arquivo.WriteLine(contato.numero);  
            }

            arquivo.Dispose();
        }

    } // class Geral


} // namespace Agenda
