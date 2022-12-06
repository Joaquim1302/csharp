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
            this.btn_moverArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_pathFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_pathTo = new System.Windows.Forms.TextBox();
            this.ct_moverTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 67);
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
            this.button2.Location = new System.Drawing.Point(12, 64);
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
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "pasta documentos do Windows";
            // 
            // btn_moverArquivo
            // 
            this.btn_moverArquivo.Location = new System.Drawing.Point(10, 168);
            this.btn_moverArquivo.Name = "btn_moverArquivo";
            this.btn_moverArquivo.Size = new System.Drawing.Size(164, 53);
            this.btn_moverArquivo.TabIndex = 6;
            this.btn_moverArquivo.Text = "mover";
            this.btn_moverArquivo.UseVisualStyleBackColor = true;
            this.btn_moverArquivo.Click += new System.EventHandler(this.btn_moverArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "de";
            // 
            // ct_pathFrom
            // 
            this.ct_pathFrom.Location = new System.Drawing.Point(182, 162);
            this.ct_pathFrom.Name = "ct_pathFrom";
            this.ct_pathFrom.Size = new System.Drawing.Size(281, 20);
            this.ct_pathFrom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "para";
            // 
            // ct_pathTo
            // 
            this.ct_pathTo.Location = new System.Drawing.Point(182, 204);
            this.ct_pathTo.Name = "ct_pathTo";
            this.ct_pathTo.Size = new System.Drawing.Size(281, 20);
            this.ct_pathTo.TabIndex = 9;
            // 
            // ct_moverTodos
            // 
            this.ct_moverTodos.Location = new System.Drawing.Point(10, 240);
            this.ct_moverTodos.Name = "ct_moverTodos";
            this.ct_moverTodos.Size = new System.Drawing.Size(164, 53);
            this.ct_moverTodos.TabIndex = 11;
            this.ct_moverTodos.Text = "Mover todos os .dat";
            this.ct_moverTodos.UseVisualStyleBackColor = true;
            this.ct_moverTodos.Click += new System.EventHandler(this.ct_moverTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 459);
            this.Controls.Add(this.ct_moverTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ct_pathTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_pathFrom);
            this.Controls.Add(this.btn_moverArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Mydocs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastas e arquivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Button btn_moverArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ct_pathFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_pathTo;
        private System.Windows.Forms.Button ct_moverTodos;
    }
}

