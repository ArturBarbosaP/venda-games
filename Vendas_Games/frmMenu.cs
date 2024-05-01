using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas_Games
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        Login login = new Login();

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = "Seja bem vindo(a) " + login.UsuarioLogado() + ".";
        }

        private void picJogos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmJogos cadJogos = new frmJogos();
            cadJogos.ShowDialog();
            this.Visible = true;
        }

        private void picVendas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmVendas cadVendas = new frmVendas();
            cadVendas.ShowDialog();
            this.Visible = true;
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cadUsuarios = new frmCadastro();
            cadUsuarios.ShowDialog();
        }
    }
}
