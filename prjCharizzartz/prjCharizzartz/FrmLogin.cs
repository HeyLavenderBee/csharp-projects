using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCharizzartz
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
            }
            else
            {
                this.Visible = false;
                frmPrincipal objPrincipal = new frmPrincipal();
                objPrincipal.Show();
            }
            
           
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
    }
}
