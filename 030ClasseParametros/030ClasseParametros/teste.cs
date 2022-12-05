using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _030ClasseParametros
{
    internal class teste
    {

        public int Add(int x, int valor = 10)
        {
            return valor + x;
        }

        public void Add5(ref int valor)
        {
            valor += 5;
        }

        public void Min5(ref int valor)
        {
            valor -= 5;
        }
    }
}
