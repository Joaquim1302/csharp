using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025Classes
{
    internal class pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void Falar()
        {
            System.Windows.Forms.MessageBox.Show("Olá, o meu nome é " + nome);
        }

        public void ApresentarSe()
        {
            System.Windows.Forms.MessageBox.Show("Olá, o meu nome é " + contruirNome() + " e tenho " + idade.ToString() + " anos.");
        }

        private string contruirNome()
        {
            return nome + " " + sobrenome;
        }
    }
}
