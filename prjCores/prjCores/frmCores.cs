using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCores
{
    public partial class frmCores : Form
    {
        public frmCores()
        {
            InitializeComponent();
        }

        private void btn_cor_texto_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            lbl_meu_texto.ForeColor = color_dialog.Color;
        }

        private void btn_cor_fundo_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            this.BackColor = color_dialog.Color;
        }

        private void corDoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            lbl_meu_texto.ForeColor = color_dialog.Color;
        }

        private void corDoFuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_dialog.ShowDialog();
            this.BackColor = color_dialog.Color;
        }
    }
}
