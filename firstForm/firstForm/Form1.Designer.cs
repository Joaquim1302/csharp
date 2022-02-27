namespace firstForm
{
    partial class Form1
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
            this.ctTexto = new System.Windows.Forms.TextBox();
            this.btButton = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctTexto
            // 
            this.ctTexto.Location = new System.Drawing.Point(169, 60);
            this.ctTexto.Name = "ctTexto";
            this.ctTexto.Size = new System.Drawing.Size(341, 20);
            this.ctTexto.TabIndex = 0;
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(194, 106);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(75, 23);
            this.btButton.TabIndex = 1;
            this.btButton.Text = "teste";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(128, 63);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(36, 13);
            this.lbTexto.TabIndex = 2;
            this.lbTexto.Text = "lbText";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(668, 424);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.btButton);
            this.Controls.Add(this.ctTexto);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctTexto;
        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.Label lbTexto;
    }
}

