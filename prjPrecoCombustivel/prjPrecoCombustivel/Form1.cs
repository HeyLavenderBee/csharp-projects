using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrecoCombustivel
{
    public partial class Form1 : Form
    {
        double vQuantidade = 0, vTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_combustivel.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            cmb_combustivel.Focus();
            btn_sair.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento efetuado!", "Pagamento", MessageBoxButtons.OK);
            Application.Exit();
        }

        //quando a escolha for alcool, até 20 litros é desconto de 3%, acima é 5%
        //quando for gasolina, até 20 litros é de 5%, acima é 6% (cada um)

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            vQuantidade = Int32.Parse(txt_quantidade.Text);
            if (cmb_combustivel.SelectedIndex == 0) //gasolina
            {
                if (vQuantidade <= 20)
                {
                    vTotal = (vQuantidade * 4.29) - (vQuantidade / 20);
                }
                else if (vQuantidade > 20)
                {
                    vTotal = (vQuantidade * 4.29) - ((vQuantidade / 100)*6);
                }
            }
            else if (cmb_combustivel.SelectedIndex == 1) //alcool
            {
                if (vQuantidade <= 20)
                {
                    vTotal = (vQuantidade * 3.19) - ((vQuantidade / 100)*3);
                }
                else if (vQuantidade > 20)
                {
                    vTotal = (vQuantidade * 3.19) - ((vQuantidade / 100) * 5);
                }
            }

            txt_resultado.Text = "R$" + vTotal.ToString();
        }
    }
}
