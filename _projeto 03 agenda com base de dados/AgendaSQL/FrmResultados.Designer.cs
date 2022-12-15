namespace AgendaSQL
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
            this.grid_resultados = new System.Windows.Forms.DataGridView();
            this.label_resultados = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_vertudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.Location = new System.Drawing.Point(558, 391);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(120, 47);
            this.cmd_fechar.TabIndex = 3;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // grid_resultados
            // 
            this.grid_resultados.AllowUserToAddRows = false;
            this.grid_resultados.AllowUserToDeleteRows = false;
            this.grid_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_resultados.Location = new System.Drawing.Point(12, 12);
            this.grid_resultados.MultiSelect = false;
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.ReadOnly = true;
            this.grid_resultados.RowHeadersVisible = false;
            this.grid_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_resultados.Size = new System.Drawing.Size(667, 373);
            this.grid_resultados.TabIndex = 5;
            this.grid_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_resultados_CellClick);
            // 
            // label_resultados
            // 
            this.label_resultados.AutoSize = true;
            this.label_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados.Location = new System.Drawing.Point(12, 391);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(98, 20);
            this.label_resultados.TabIndex = 6;
            this.label_resultados.Text = "Resultados: ";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_apagar.Location = new System.Drawing.Point(427, 391);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(120, 47);
            this.cmd_apagar.TabIndex = 3;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_editar.Location = new System.Drawing.Point(296, 391);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(120, 47);
            this.cmd_editar.TabIndex = 3;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_vertudo
            // 
            this.cmd_vertudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_vertudo.Location = new System.Drawing.Point(165, 391);
            this.cmd_vertudo.Name = "cmd_vertudo";
            this.cmd_vertudo.Size = new System.Drawing.Size(120, 47);
            this.cmd_vertudo.TabIndex = 3;
            this.cmd_vertudo.Text = "Ver tudo";
            this.cmd_vertudo.UseVisualStyleBackColor = true;
            this.cmd_vertudo.Click += new System.EventHandler(this.cmd_vertudo_Click);
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label_resultados);
            this.Controls.Add(this.grid_resultados);
            this.Controls.Add(this.cmd_vertudo);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.DataGridView grid_resultados;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_vertudo;
    }
}