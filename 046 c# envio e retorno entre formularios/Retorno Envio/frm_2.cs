using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retorno_Envio
{
    public partial class frm_2 : Form
    {
        public string nome { get; set; }
        public frm_2(string nome)
        {
            InitializeComponent();
            text_nome.Text = nome;
        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            // definir o valor a retornar
            if (text_nome.Text == "")
                nome = null;
            else
                nome =  text_nome.Text;
            this.Close();
        }

        private void cmd_avancar_Click(object sender, EventArgs e)
        {
            // fechar o for e não retornar valor
            nome = null;
            this.Close();
        }
    }
}
