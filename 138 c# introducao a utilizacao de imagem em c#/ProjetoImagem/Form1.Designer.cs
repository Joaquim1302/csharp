namespace ProjetoImagem
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
            this.pic_teste = new System.Windows.Forms.PictureBox();
            this.cmd_teste = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_teste
            // 
            this.pic_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_teste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_teste.Location = new System.Drawing.Point(12, 12);
            this.pic_teste.Name = "pic_teste";
            this.pic_teste.Size = new System.Drawing.Size(429, 311);
            this.pic_teste.TabIndex = 0;
            this.pic_teste.TabStop = false;
            this.pic_teste.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pic_teste.DoubleClick += new System.EventHandler(this.pic_teste_DoubleClick);
            // 
            // cmd_teste
            // 
            this.cmd_teste.BackColor = System.Drawing.Color.Transparent;
            this.cmd_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_teste.Location = new System.Drawing.Point(471, 12);
            this.cmd_teste.Name = "cmd_teste";
            this.cmd_teste.Size = new System.Drawing.Size(150, 40);
            this.cmd_teste.TabIndex = 0;
            this.cmd_teste.TabStop = false;
            this.cmd_teste.Click += new System.EventHandler(this.pic_teste_DoubleClick);
            this.cmd_teste.MouseEnter += new System.EventHandler(this.cmd_teste_MouseEnter);
            this.cmd_teste.MouseLeave += new System.EventHandler(this.cmd_teste_MouseLeave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(670, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_teste);
            this.Controls.Add(this.pic_teste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_teste;
        private System.Windows.Forms.PictureBox cmd_teste;
        private System.Windows.Forms.Button button1;
    }
}

