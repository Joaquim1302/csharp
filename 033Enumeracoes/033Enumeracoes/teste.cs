using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _033Enumeracoes
{
    internal class teste
    {
        public enum DiasDaSemana
        {
            segunda, terça, quarta, quinta, sexta, sábado, domingo        
        }

        public enum Movimentos {Cima, Baixo, Esquerda, Direita}

        public void ApresentaDia(DiasDaSemana dia)
        {
            Console.WriteLine("O dia é " + dia);
        }

        public void Mover(Movimentos mov)
        {
            Console.WriteLine("O jogador moveu-se para " + mov);
        }
    }
}

