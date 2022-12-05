namespace square_01_01
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
            this.tbxLadoQuadrado = new System.Windows.Forms.TextBox();
            this.lblLadoQuadrado = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblAreaQuadrado = new System.Windows.Forms.Label();
            this.tbxAreaQuadrado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxLadoQuadrado
            // 
            this.tbxLadoQuadrado.Location = new System.Drawing.Point(124, 12);
            this.tbxLadoQuadrado.Name = "tbxLadoQuadrado";
            this.tbxLadoQuadrado.Size = new System.Drawing.Size(100, 20);
            this.tbxLadoQuadrado.TabIndex = 0;
            // 
            // lblLadoQuadrado
            // 
            this.lblLadoQuadrado.AutoSize = true;
            this.lblLadoQuadrado.Location = new System.Drawing.Point(12, 15);
            this.lblLadoQuadrado.Name = "lblLadoQuadrado";
            this.lblLadoQuadrado.Size = new System.Drawing.Size(96, 13);
            this.lblLadoQuadrado.TabIndex = 1;
            this.lblLadoQuadrado.Text = "Lado quadrado (m)";
            this.lblLadoQuadrado.Click += new System.EventHandler(this.lblLadoQuadrado_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(84, 98);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(84, 25);
            this.btnCalcula.TabIndex = 2;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAreaQuadrado
            // 
            this.lblAreaQuadrado.AutoSize = true;
            this.lblAreaQuadrado.Location = new System.Drawing.Point(12, 64);
            this.lblAreaQuadrado.Name = "lblAreaQuadrado";
            this.lblAreaQuadrado.Size = new System.Drawing.Size(55, 13);
            this.lblAreaQuadrado.TabIndex = 4;
            this.lblAreaQuadrado.Text = "Área (m2):";
            // 
            // tbxAreaQuadrado
            // 
            this.tbxAreaQuadrado.Location = new System.Drawing.Point(124, 61);
            this.tbxAreaQuadrado.Name = "tbxAreaQuadrado";
            this.tbxAreaQuadrado.Size = new System.Drawing.Size(100, 20);
            this.tbxAreaQuadrado.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(417, 334);
            this.Controls.Add(this.lblAreaQuadrado);
            this.Controls.Add(this.tbxAreaQuadrado);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblLadoQuadrado);
            this.Controls.Add(this.tbxLadoQuadrado);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLadoQuadrado;
        private System.Windows.Forms.Label lblLadoQuadrado;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblAreaQuadrado;
        private System.Windows.Forms.TextBox tbxAreaQuadrado;
    }
}

