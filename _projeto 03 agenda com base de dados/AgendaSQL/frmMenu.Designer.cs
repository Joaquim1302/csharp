namespace AgendaSQL
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_adicionar = new System.Windows.Forms.Button();
            this.cmd_ver_tudo = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_pesquisar.Location = new System.Drawing.Point(86, 202);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(206, 57);
            this.cmd_pesquisar.TabIndex = 0;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(89, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(211, 37);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Agenda SQL";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_sair
            // 
            this.cmd_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sair.Location = new System.Drawing.Point(86, 269);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(206, 57);
            this.cmd_sair.TabIndex = 0;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_adicionar.Location = new System.Drawing.Point(86, 135);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(206, 57);
            this.cmd_adicionar.TabIndex = 0;
            this.cmd_adicionar.Text = "Adicionar";
            this.cmd_adicionar.UseVisualStyleBackColor = true;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // cmd_ver_tudo
            // 
            this.cmd_ver_tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ver_tudo.Location = new System.Drawing.Point(86, 68);
            this.cmd_ver_tudo.Name = "cmd_ver_tudo";
            this.cmd_ver_tudo.Size = new System.Drawing.Size(206, 57);
            this.cmd_ver_tudo.TabIndex = 0;
            this.cmd_ver_tudo.Text = "Visualizar Tudo";
            this.cmd_ver_tudo.UseVisualStyleBackColor = true;
            // 
            // label_versao
            // 
            this.label_versao.AutoSize = true;
            this.label_versao.Location = new System.Drawing.Point(170, 355);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(39, 13);
            this.label_versao.TabIndex = 2;
            this.label_versao.Text = "versão";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 389);
            this.ControlBox = false;
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_ver_tudo);
            this.Controls.Add(this.cmd_adicionar);
            this.Controls.Add(this.cmd_pesquisar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_ver_tudo;
        private System.Windows.Forms.Label label_versao;
    }
}

