namespace Retorno_Envio
{
    partial class frm_2
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
            this.cmd_avancar = new System.Windows.Forms.Button();
            this.cmd_ok = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_avancar
            // 
            this.cmd_avancar.Location = new System.Drawing.Point(45, 96);
            this.cmd_avancar.Name = "cmd_avancar";
            this.cmd_avancar.Size = new System.Drawing.Size(75, 23);
            this.cmd_avancar.TabIndex = 2;
            this.cmd_avancar.Text = "Cancelar";
            this.cmd_avancar.UseVisualStyleBackColor = true;
            this.cmd_avancar.Click += new System.EventHandler(this.cmd_avancar_Click);
            // 
            // cmd_ok
            // 
            this.cmd_ok.Location = new System.Drawing.Point(126, 96);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(75, 23);
            this.cmd_ok.TabIndex = 3;
            this.cmd_ok.Text = "OK";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(45, 51);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(156, 20);
            this.text_nome.TabIndex = 4;
            // 
            // frm_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 149);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.cmd_ok);
            this.Controls.Add(this.cmd_avancar);
            this.Name = "frm_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_avancar;
        private System.Windows.Forms.Button cmd_ok;
        private System.Windows.Forms.TextBox text_nome;
    }
}