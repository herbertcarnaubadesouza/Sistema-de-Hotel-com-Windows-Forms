using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel;

namespace SistemaHotel.Cadastros
{
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome", "Campo Vazio", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            btnNovo.Enabled = true;
            MessageBox.Show("Registro Salvo com Sucesso!","Dado Salvo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Cargo", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            MessageBox.Show("Registro Editado com Sucesso", "Editado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro Excluido com Sucesso","Excluido com Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }
        
        
        }
    }
}
