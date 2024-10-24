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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
                progressBar.Value += 1;
            else
            {
                //progressBar.Value = 100;
                this.Visible = false;
                timer1.Enabled = false;
                frmLogin objLogin = new frmLogin();
                objLogin.Show();
            }
            label_Progress();
        }

        private void label_Progress()
        {
            if (progressBar.Value == 30)
                lblProgress.Text = "Abrindo Pokébola...";
            else if (progressBar.Value == 50)
                lblProgress.Text = "Convencendo Charizard a colaborar...";
            else if (progressBar.Value == 70)
                lblProgress.Text = "Incendiando cidade...";
            else if (progressBar.Value == 90)
                lblProgress.Text = "Pronto!";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
