using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public string nome { get; set; }
        public string numero { get; set;}

        public static void partesContato(string strcontato, Contato contato)
        {
            string separador = "-";
            int index = 0;
            foreach (char c in strcontato)
            {
                foreach (char s in separador)
                {
                    if (c == s)
                    {
                        // define os 3 elementos da operação
                        contato.nome = strcontato.Substring(0, index - 1);
                        contato.numero = strcontato.Substring(index + 2);
                        return;
                    }

                } // fim foreach(char s in separador)
                index ++;
            } // fim foreach( char c in strcontato)
        } // partesContato
    }


}
