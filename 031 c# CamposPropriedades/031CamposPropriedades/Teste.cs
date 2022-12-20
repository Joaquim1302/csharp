using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _031CamposPropriedades
{
    internal class Teste
    {
        // definição de um CAMPO
        private string _nome;

        // definição de uma PROPRIEDADE
        public string Nome
        {
            set
            {
                if (value == "Bullshit")
                    _nome = "Nem a pau!";
                else
                    _nome = value;
            }
            get { return _nome; }
        }
        public string Nome2
        {
            set
            {_nome = "Nome2 " + value;}
        }
         
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome);
        }
    }
}
