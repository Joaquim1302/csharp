using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            // executa o cálculo da operação

            int parcela1;
            int parcela2;
            string tipo_operacao;

            int res = -111111111; // resultado final da operação

            string algoritmo = text_operacao.Text;

            // 123+456
            string sinais = "+-*/";
            int index = 0;
            foreach( char c in algoritmo)
            {
                foreach(char s in sinais)
                {
                    if (c == s)
                    {
                        // define os 3 elementos da operação
                        parcela1 = int.Parse(algoritmo.Substring(0, index));
                        parcela2 = int.Parse(algoritmo.Substring(index+ 1));
                        tipo_operacao = s.ToString();

                        // analisa a operação que vai ser realizaada
                        switch (tipo_operacao)
                        {
                            case "+":
                                // adição
                                res = parcela1 + parcela2;
                                break;
                            case "-":
                                // subtração
                                res = parcela1 - parcela2;
                                break;
                            case "*":
                                // multiplicação
                                res = parcela1 * parcela2;
                                break;
                            case "/":
                                // divisão
                                res = parcela1 / parcela2;
                                break;

                        }
                        // após o switch já temos o resultado
                        break;
                    }

                } // fim foreach(char s in sinais)

                index++;
                if (res != -111111111)
                    break;

            } // fim foreach( char c in algoritmo)

            // apresentação do resultado
            if (res == -111111111)
                MessageBox.Show ("Erro!");
            else
                MessageBox.Show(algoritmo + " = " + res);
            text_operacao.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // enter = tab
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void text_operacao_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text_operacao.Text))
            {
                text_operacao.SelectionStart = 0;
                text_operacao.SelectionLength = text_operacao.Text.Length;
            }
        }
    }
}
