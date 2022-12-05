using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiProjeto
{
    public partial class frmUm : Form
    {
        public frmUm(Form frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;

            int largura = frmParent.DisplayRectangle.Width;
            int altura = frmParent.DisplayRectangle.Height;

            this.Location = new Point((largura - this.Width) / 2, (altura - this.Height) / 2);

        }
    }
}
