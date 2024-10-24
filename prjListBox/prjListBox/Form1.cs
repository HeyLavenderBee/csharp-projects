using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjListBox
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            lst_relacao_cidades.Items.Add("S. Caetano");
        }

        private void ListBox_Activated(object sender, EventArgs e)
        {
            txt_cidade.Focus();
            txt_qtd_cidades.Text = lst_relacao_cidades.Items.Count.ToString();
            btn_devolver.Enabled = false;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            lst_relacao_cidades.Items.Add(txt_cidade.Text);
            txt_cidade.Text = "";
            txt_qtd_cidades.Text = lst_relacao_cidades.Items.Count.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lst_relacao_cidades.Items.Remove(lst_relacao_cidades.SelectedItem);
            txt_qtd_cidades.Text = lst_relacao_cidades.Items.Count.ToString();
            if (lst_relacao_cidades.Items.Count == 0)
            {
                btn_selecionar.Enabled = false;
            }
            else
            {
                btn_selecionar.Enabled = true;
            }
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if (lst_relacao_cidades.SelectedIndex == -1)
            {
                MessageBox.Show("É necessário selecionar um item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lst_selecionado.Items.Clear();
                lst_selecionado.Items.Add(lst_relacao_cidades.SelectedItem);
                txt_qtd_cidades.Text = lst_relacao_cidades.Items.Count.ToString();
                btn_devolver.Enabled = true;
            }
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            lst_relacao_cidades.Items.Add(lst_selecionado.SelectedItem);
            txt_qtd_cidades.Text = lst_relacao_cidades.Items.Count.ToString();
            btn_devolver.Enabled = false;
        }
    }
}
