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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Login login = new Login();

        private void Limpar()
        {
            txt_senha.Text = "";
            txt_usuario.Text = "";
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (login.validarUsuario(txt_usuario.Text, txt_senha.Text))
            {
                switch (login.TipoUsuario())
                {
                    case "cadVendas":
                        Limpar();
                        txt_senha.PasswordChar = '•';
                        checkBoxeSenha.Text = "Exibir Senha";
                        checkBoxeSenha.Checked = false;
                        this.Visible = false;
                        frmVendas cadVendas = new frmVendas();
                        cadVendas.ShowDialog();
                        this.Visible = true;
                        break;
                    case "cadJogos":
                        Limpar();
                        txt_senha.PasswordChar = '•';
                        checkBoxeSenha.Text = "Exibir Senha";
                        checkBoxeSenha.Checked = false;
                        this.Visible = false;
                        frmJogos cadJogos = new frmJogos();
                        cadJogos.ShowDialog();
                        this.Visible = true;
                        break;
                    case "ADM":
                        Limpar();
                        txt_senha.PasswordChar = '•';
                        checkBoxeSenha.Text = "Exibir Senha";
                        checkBoxeSenha.Checked = false;
                        this.Visible = false;
                        frmMenu menu = new frmMenu();
                        menu.ShowDialog();
                        this.Visible = true;
                        break;
                }
            }
            else if (txt_usuario.Text == "ADM" && login.primeiroLogin())
            {
                this.Visible = false;
                frmCadastro cadUsuarios = new frmCadastro();
                cadUsuarios.ShowDialog();
                txt_usuario.Text = "";
                txt_senha.Enabled = true;
                checkBoxeSenha.Enabled = true;
                txt_usuario.TabStop = true;
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxeSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxeSenha.Checked == true)
            {
                txt_senha.PasswordChar = (char)0;
                checkBoxeSenha.Text = "Ocultar Senha";
            }
            else
            {
                txt_senha.PasswordChar = '•';
                checkBoxeSenha.Text = "Exibir Senha";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (login.primeiroLogin())
            {
                txt_usuario.Text = "ADM";
                txt_senha.Enabled = false;
                checkBoxeSenha.Enabled = false;
                txt_usuario.TabStop = false;
            }
        }
    }
}
