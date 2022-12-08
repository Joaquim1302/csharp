namespace Calculadora
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
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_operacao = new System.Windows.Forms.TextBox();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_calcular.Location = new System.Drawing.Point(12, 75);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(150, 39);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // text_operacao
            // 
            this.text_operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_operacao.Location = new System.Drawing.Point(12, 34);
            this.text_operacao.MaxLength = 30;
            this.text_operacao.Name = "text_operacao";
            this.text_operacao.Size = new System.Drawing.Size(306, 26);
            this.text_operacao.TabIndex = 0;
            this.text_operacao.Enter += new System.EventHandler(this.text_operacao_Enter);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sair.Location = new System.Drawing.Point(168, 75);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(150, 39);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escreva o algoritmo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.text_operacao);
            this.Controls.Add(this.cmd_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora 1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_operacao;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label1;
    }
}

