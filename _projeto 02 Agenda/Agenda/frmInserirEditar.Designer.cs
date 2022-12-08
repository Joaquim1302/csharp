namespace Agenda
{
    partial class frmInserirEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.Location = new System.Drawing.Point(438, 547);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(121, 46);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_nome
            // 
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.Location = new System.Drawing.Point(124, 33);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(356, 23);
            this.text_nome.TabIndex = 2;
            // 
            // text_numero
            // 
            this.text_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numero.Location = new System.Drawing.Point(124, 62);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(118, 23);
            this.text_numero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gravar.Location = new System.Drawing.Point(124, 108);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(121, 46);
            this.cmd_gravar.TabIndex = 5;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(12, 190);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(546, 342);
            this.lista_contatos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de contatos registrados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero_registros.Location = new System.Drawing.Point(12, 535);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(106, 20);
            this.label_numero_registros.TabIndex = 8;
            this.label_numero_registros.Text = "Registros: 0";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_apagar.Location = new System.Drawing.Point(281, 547);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(121, 46);
            this.cmd_apagar.TabIndex = 9;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            // 
            // cmd_editar
            // 
            this.cmd_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_editar.Location = new System.Drawing.Point(124, 547);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(121, 46);
            this.cmd_editar.TabIndex = 10;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 605);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA - INSERIR /  EDITAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}