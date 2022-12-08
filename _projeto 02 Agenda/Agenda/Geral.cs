using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Agenda
{
    public static class Geral
    {
        public const string DIR_AGENDA = @"E:\csharp\_config";
        public const string PATH_AGENDA = @"E:\csharp\_config\agenda.txt";
        public static string versao = "v1.0.0";

        // lista de contatos
        public static List<Contato> ListaContatos;

        public static void ConstroiListaContatos()
        {
            // instancia a lista
            ListaContatos = new List<Contato>();

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

                    ListaContatos.Add(novo_contato);


                }

                arqAgenda.Dispose();
            }
        }

    }

}
