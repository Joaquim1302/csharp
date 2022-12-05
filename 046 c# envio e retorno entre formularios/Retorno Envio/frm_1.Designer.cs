namespace Retorno_Envio
{
    partial class frm_1
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
            this.label_texto = new System.Windows.Forms.Label();
            this.cmd_avancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_texto
            // 
            this.label_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_texto.Location = new System.Drawing.Point(12, 21);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(401, 35);
            this.label_texto.TabIndex = 0;
            this.label_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_avancar
            // 
            this.cmd_avancar.Location = new System.Drawing.Point(338, 218);
            this.cmd_avancar.Name = "cmd_avancar";
            this.cmd_avancar.Size = new System.Drawing.Size(75, 23);
            this.cmd_avancar.TabIndex = 1;
            this.cmd_avancar.Text = "executar";
            this.cmd_avancar.UseVisualStyleBackColor = true;
            this.cmd_avancar.Click += new System.EventHandler(this.cmd_avancar_Click);
            // 
            // frm_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 253);
            this.Controls.Add(this.cmd_avancar);
            this.Controls.Add(this.label_texto);
            this.Name = "frm_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_texto;
        private System.Windows.Forms.Button cmd_avancar;
    }
}

