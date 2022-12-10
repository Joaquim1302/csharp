namespace Agenda
{
    partial class FrmTexto
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
            this.cmd_pesquisa = new System.Windows.Forms.Button();
            this.text_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_pesquisa
            // 
            this.cmd_pesquisa.Location = new System.Drawing.Point(137, 51);
            this.cmd_pesquisa.Name = "cmd_pesquisa";
            this.cmd_pesquisa.Size = new System.Drawing.Size(126, 43);
            this.cmd_pesquisa.TabIndex = 1;
            this.cmd_pesquisa.Text = "Pesquisar";
            this.cmd_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_pesquisa.Click += new System.EventHandler(this.cmd_pesquisa_Click);
            // 
            // text_texto
            // 
            this.text_texto.Location = new System.Drawing.Point(8, 25);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(255, 20);
            this.text_texto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "perquisar";
            // 
            // cmd_Cancelar
            // 
            this.cmd_Cancelar.Location = new System.Drawing.Point(8, 51);
            this.cmd_Cancelar.Name = "cmd_Cancelar";
            this.cmd_Cancelar.Size = new System.Drawing.Size(126, 43);
            this.cmd_Cancelar.TabIndex = 2;
            this.cmd_Cancelar.Text = "Cancelar";
            this.cmd_Cancelar.UseVisualStyleBackColor = true;
            this.cmd_Cancelar.Click += new System.EventHandler(this.cmd_Cancelar_Click);
            // 
            // FrmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 102);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.cmd_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTexto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_pesquisa;
        private System.Windows.Forms.TextBox text_texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Cancelar;
    }
}