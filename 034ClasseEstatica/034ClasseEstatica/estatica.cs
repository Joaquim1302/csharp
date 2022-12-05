using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _034ClasseEstatica
{
    // classe estátic não precisa instanciar
    public static class estatica
    {
        public static string Nome;
        public static string NomePrograma = "Aplicação de teste";

        public static void ApresentarNome()
        {
            Console.WriteLine(Nome);       
        }
    }
}
