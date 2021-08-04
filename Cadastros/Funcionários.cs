using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereço.Enabled = true;
            cbCargo.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereço.Enabled = false;
            cbCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereço.Text = "";
            txtTelefone.Text = "";
        }



        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {

            rbNome.Checked = true;
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
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
            if(txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!","Campo Vazio",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!","Campo Vazio",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                txtCPF.Focus();
                return;
            }
            MessageBox.Show("Registro Salvo com Sucesso","Dado Salvo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtCPF.Text = "";
            LimparCampos();
            DesabilitarCampos();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (txtCPF.Text.ToString().Trim() == "")
            {
                txtCPF.Text = "";
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
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
    }
}
