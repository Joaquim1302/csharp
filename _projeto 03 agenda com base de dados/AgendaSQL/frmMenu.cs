﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmMenu : Form
    {

        //-------------------------------------------------
        public frmMenu()
        {
            InitializeComponent();
            // apresenta a versão do software
            label_versao.Text = Vars.versao;
        }

        //-------------------------------------------------
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "AgendaSQL", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
        }

        //-------------------------------------------------
        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        //-------------------------------------------------
        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarEditar frm = new FrmAdicionarEditar();
            frm.ShowDialog();
        }
    }
}
