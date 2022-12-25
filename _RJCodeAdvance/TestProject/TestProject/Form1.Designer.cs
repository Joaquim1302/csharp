namespace TestProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDarkTheme = new CustomControls.RJControls.RJToggleButton();
            this.rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "dark theme";
            // 
            // tbDarkTheme
            // 
            this.tbDarkTheme.AutoSize = true;
            this.tbDarkTheme.Location = new System.Drawing.Point(377, 132);
            this.tbDarkTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbDarkTheme.Name = "tbDarkTheme";
            this.tbDarkTheme.OffBackColor = System.Drawing.Color.Gray;
            this.tbDarkTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbDarkTheme.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbDarkTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbDarkTheme.Size = new System.Drawing.Size(45, 22);
            this.tbDarkTheme.TabIndex = 1;
            this.tbDarkTheme.UseVisualStyleBackColor = true;
            this.tbDarkTheme.CheckedChanged += new System.EventHandler(this.tbDarkTheme_CheckedChanged);
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.Checked = true;
            this.rjToggleButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton2.Location = new System.Drawing.Point(180, 275);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton2.Size = new System.Drawing.Size(118, 49);
            this.rjToggleButton2.SolidStyle = false;
            this.rjToggleButton2.TabIndex = 0;
            this.rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Location = new System.Drawing.Point(180, 72);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(118, 49);
            this.rjToggleButton1.TabIndex = 0;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(180, 132);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjButton2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rjButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderRadius = 24;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Gray;
            this.rjButton2.Location = new System.Drawing.Point(180, 220);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(118, 49);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.Text = "rjButton1";
            this.rjButton2.TextColor = System.Drawing.Color.Gray;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDarkTheme);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.rjToggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJToggleButton rjToggleButton1;
        private CustomControls.RJControls.RJToggleButton rjToggleButton2;
        private CustomControls.RJControls.RJToggleButton tbDarkTheme;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}

