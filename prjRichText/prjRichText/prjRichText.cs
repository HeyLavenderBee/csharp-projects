using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRichText
{
    public partial class prjRichText : Form
    {
        string vFont = "Times New Roman";
        int vTamanho = 10;

        public prjRichText()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTextBox.ForeColor = colorDialog.Color;
            richTextBox.SelectionColor = colorDialog.Color;
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
            vFont = fontDialog.Font.ToString();
        }

        private void btnAumentarFonte_Click(object sender, EventArgs e)
        {
            // BI - carrega os dados, e transporta eles
            // ERP - software que liga todas as empresas
            // SAP 
            //richTextBox.Font.Size = 10;
            vTamanho += 1;
            richTextBox.Font = new Font(vFont, vTamanho);
        }

        private void btnDiminuirFonte_Click(object sender, EventArgs e)
        {
            vTamanho -= 1;
            richTextBox.Font = new Font(vFont, vTamanho);
        }

        private void prjRichText_Activated(object sender, EventArgs e)
        {
            richTextBox.Font = new Font(vFont, 10);
        }
    }
}
