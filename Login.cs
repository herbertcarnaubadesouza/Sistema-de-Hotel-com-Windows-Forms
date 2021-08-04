using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            pnlLogin.Visible = true;
            BtnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21,114,160);
            BtnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RealizaLogin();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RealizaLogin();
            }
        }

        private void RealizaLogin()
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Usuário","Campo Vazio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha a Senha","Campo Vazio",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            //passou do click

            FrmMenu menu = new FrmMenu();
            Limpar();
            menu.Show();

        }

        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
