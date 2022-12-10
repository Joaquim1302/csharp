namespace Agenda
{
    partial class FrmResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.cmd_novaPesquisa = new System.Windows.Forms.Button();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.lstB_resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(424, 166);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(134, 43);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_novaPesquisa
            // 
            this.cmd_novaPesquisa.Location = new System.Drawing.Point(284, 166);
            this.cmd_novaPesquisa.Name = "cmd_novaPesquisa";
            this.cmd_novaPesquisa.Size = new System.Drawing.Size(134, 43);
            this.cmd_novaPesquisa.TabIndex = 1;
            this.cmd_novaPesquisa.Text = "Nova pesquisa ...";
            this.cmd_novaPesquisa.UseVisualStyleBackColor = true;
            this.cmd_novaPesquisa.Click += new System.EventHandler(this.cmd_novaPesquisa_Click);
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_registros.Location = new System.Drawing.Point(12, 162);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(106, 20);
            this.label_numero_registros.TabIndex = 10;
            this.label_numero_registros.Text = "Registros: 0";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstB_resultados
            // 
            this.lstB_resultados.FormattingEnabled = true;
            this.lstB_resultados.Location = new System.Drawing.Point(12, 12);
            this.lstB_resultados.Name = "lstB_resultados";
            this.lstB_resultados.Size = new System.Drawing.Size(546, 147);
            this.lstB_resultados.TabIndex = 9;
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.lstB_resultados);
            this.Controls.Add(this.cmd_novaPesquisa);
            this.Controls.Add(this.cmd_fechar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_novaPesquisa;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.ListBox lstB_resultados;
    }
}