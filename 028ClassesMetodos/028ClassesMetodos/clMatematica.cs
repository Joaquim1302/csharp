using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _028ClassesMetodos
{
    internal class clMatematica
    {
        int parcela1;
        int parcela2;

        public int Operacoes(int parcela1, int parcela2, string opr)
        {
            this.parcela1 = parcela1;
            this.parcela2 = parcela2;
            
            switch (opr)
            {
                case "+":
                    return Adicao(); 
                case "-":
                    return Subtracao();
                case "*":
                    return Multiplicacao();
                case "/":
                    return Divisao();
                default: 
                    return -1000;
            }
        }

        private int Adicao()
        {
            return parcela1 + parcela2;
        }

        private int Subtracao()
        {
            return parcela1 - parcela2;
        }

        private int Multiplicacao()
        {
            return parcela1 * parcela2;
        }

        private int Divisao()
        {
            return parcela1 / parcela2;
        }

    }
}
