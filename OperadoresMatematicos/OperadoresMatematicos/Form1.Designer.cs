namespace OperadoresMatematicos
{
    partial class Form1
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
            this.btExecutar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.ctParcela1 = new System.Windows.Forms.TextBox();
            this.ctParcela2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(49, 156);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 0;
            this.btExecutar.Text = "executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(46, 119);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(35, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "label1";
            // 
            // ctParcela1
            // 
            this.ctParcela1.Location = new System.Drawing.Point(49, 48);
            this.ctParcela1.Name = "ctParcela1";
            this.ctParcela1.Size = new System.Drawing.Size(100, 20);
            this.ctParcela1.TabIndex = 2;
            // 
            // ctParcela2
            // 
            this.ctParcela2.Location = new System.Drawing.Point(49, 83);
            this.ctParcela2.Name = "ctParcela2";
            this.ctParcela2.Size = new System.Drawing.Size(100, 20);
            this.ctParcela2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 232);
            this.Controls.Add(this.ctParcela2);
            this.Controls.Add(this.ctParcela1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btExecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExecutar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox ctParcela1;
        private System.Windows.Forms.TextBox ctParcela2;
    }
}

