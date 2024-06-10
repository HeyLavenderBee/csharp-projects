using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFormatacaoDeCampos
{
    public partial class frmFormatacaoDeCampos : Form
    {
        public frmFormatacaoDeCampos()
        {
            InitializeComponent();
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            txtCEP_S.Text = string.Format("{0:00000-000}", int.Parse(txtCEP_E.Text));
        }
    }
}
