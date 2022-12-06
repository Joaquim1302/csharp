namespace PastasArquivos
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.text_Mydocs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gravar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(12, 12);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(162, 20);
            this.text_nome.TabIndex = 1;
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(12, 38);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(162, 20);
            this.dtp_data.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Carregar Configurações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_Mydocs
            // 
            this.text_Mydocs.Location = new System.Drawing.Point(209, 41);
            this.text_Mydocs.Name = "text_Mydocs";
            this.text_Mydocs.Size = new System.Drawing.Size(281, 20);
            this.text_Mydocs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "pasta documentos do Windows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Mydocs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastas e arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_Mydocs;
        private System.Windows.Forms.Label label1;
    }
}

