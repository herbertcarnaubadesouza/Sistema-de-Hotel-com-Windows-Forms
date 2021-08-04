using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Properties;

namespace SistemaHotel.Produtos
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            txtEstoque.Enabled = true;
            btnImg.Enabled = true;
            txtNome.Focus();
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            btnImg.Enabled = false;
        }

        private void LimparCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            txtNome.Text = "";
            LimparFoto();
        }


        private void LimparFoto()
        {
            img.Image = Resources.sem_foto;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor!", "Campo Vazio", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return;
            }
            MessageBox.Show("Registro Salvo com Sucesso", "Dado Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtValor.Text = "";
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor!", "Campo Vazio", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return;
            }
            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro Excluido com Sucesso", "Excluido com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string CaminhoDaFoto = dialog.FileName.ToString();
                img.ImageLocation = CaminhoDaFoto;
            }
        }
    }
}
