using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Cadastros;
using SistemaHotel.Produtos;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(130, 130, 130);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios form = new FrmFuncionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargo Form = new FrmCargo();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProdutos Form = new FrmProdutos();
            Form.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos form = new FrmProdutos();
            form.Show();
        }
    }
}
