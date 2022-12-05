namespace cores
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trb_red = new System.Windows.Forms.TrackBar();
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.trb_green = new System.Windows.Forms.TrackBar();
            this.lb_blue = new System.Windows.Forms.Label();
            this.trb_blue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(33, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 207);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trb_red
            // 
            this.trb_red.Location = new System.Drawing.Point(33, 245);
            this.trb_red.Maximum = 255;
            this.trb_red.Name = "trb_red";
            this.trb_red.Size = new System.Drawing.Size(553, 45);
            this.trb_red.TabIndex = 2;
            this.trb_red.Scroll += new System.EventHandler(this.trb_red_Scroll);
            // 
            // lb_red
            // 
            this.lb_red.AutoSize = true;
            this.lb_red.Location = new System.Drawing.Point(592, 254);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(27, 13);
            this.lb_red.TabIndex = 5;
            this.lb_red.Text = "R: 0";
            // 
            // lb_green
            // 
            this.lb_green.AutoSize = true;
            this.lb_green.Location = new System.Drawing.Point(592, 291);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(27, 13);
            this.lb_green.TabIndex = 7;
            this.lb_green.Text = "G: 0";
            // 
            // trb_green
            // 
            this.trb_green.Location = new System.Drawing.Point(33, 282);
            this.trb_green.Maximum = 255;
            this.trb_green.Name = "trb_green";
            this.trb_green.Size = new System.Drawing.Size(553, 45);
            this.trb_green.TabIndex = 6;
            this.trb_green.Scroll += new System.EventHandler(this.trb_green_Scroll);
            // 
            // lb_blue
            // 
            this.lb_blue.AutoSize = true;
            this.lb_blue.Location = new System.Drawing.Point(592, 327);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(26, 13);
            this.lb_blue.TabIndex = 9;
            this.lb_blue.Text = "B: 0";
            // 
            // trb_blue
            // 
            this.trb_blue.Location = new System.Drawing.Point(33, 318);
            this.trb_blue.Maximum = 255;
            this.trb_blue.Name = "trb_blue";
            this.trb_blue.Size = new System.Drawing.Size(553, 45);
            this.trb_blue.TabIndex = 8;
            this.trb_blue.Scroll += new System.EventHandler(this.trb_blue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 369);
            this.Controls.Add(this.lb_blue);
            this.Controls.Add(this.trb_blue);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.trb_green);
            this.Controls.Add(this.lb_red);
            this.Controls.Add(this.trb_red);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trb_red;
        private System.Windows.Forms.Label lb_red;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.TrackBar trb_green;
        private System.Windows.Forms.Label lb_blue;
        private System.Windows.Forms.TrackBar trb_blue;
    }
}

