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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        Conexao bd = new Conexao();
        Login login = new Login();
        string sql;

        private void Limpar()
        {
            txt_codigo.Text = "";
            txt_conSenha.Text = "";
            txt_nome.Text = "";
            txt_senha.Text = "";
            txt_usuario.Text = "";
            cbx_tipo.SelectedIndex = -1;
        }

        private void frmCadastro_Shown(object sender, EventArgs e)
        {
            if (login.primeiroLogin())
            {
                cbx_tipo.Items.Clear();
                cbx_tipo.Items.Add("ADM");
                cbx_tipo.SelectedItem = "ADM";
                btn_buscar.Enabled = false;
                btn_alterar.Enabled = false;
                btn_excluir.Enabled = false;
                MessageBox.Show("Cadastre um administrador antes de continuar!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            switch (login.primeiroLogin())
            {
                case true:
                    if (txt_senha.Text == txt_conSenha.Text)
                    {
                        sql = string.Format("insert into usuarios values (null, '{0}', '{1}', '{2}', '{3}')",
                                            txt_nome.Text, txt_usuario.Text, txt_senha.Text, cbx_tipo.Text);
                        bd.Alterar(sql);
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não são iguais!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case false:
                    if (txt_senha.Text == txt_conSenha.Text)
                    {
                        sql = string.Format("insert into usuarios values (null, '{0}', '{1}', '{2}', '{3}')",
                                            txt_nome.Text, txt_usuario.Text, txt_senha.Text, cbx_tipo.Text);
                        bd.Alterar(sql);
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não são iguais!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }        
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from usuarios where codigo = '{0}' or usuario = '{1}' or nome = '{2}'",
                                txt_codigo.Text, txt_usuario.Text, txt_nome.Text);
            buscar = bd.Consultar(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_usuario.Text = buscar.Rows[0]["usuario"].ToString();
                txt_senha.Text = buscar.Rows[0]["senha"].ToString();
                txt_conSenha.Text = buscar.Rows[0]["senha"].ToString();
                cbx_tipo.Text = buscar.Rows[0]["tipo"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro de usuário não encontrado!", "Buscar Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_conSenha.Text)
            {
                sql = string.Format("update usuarios set nome = '{0}', usuario = '{1}', senha = '{2}', tipo = '{3}' where codigo = '{4}'",
                                txt_nome.Text, txt_usuario.Text, txt_senha.Text, cbx_tipo.Text, txt_codigo.Text);
                bd.Alterar(sql);
                MessageBox.Show("Cadastro de usuário alterado com sucesso!", "Alterar Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("As senhas não são iguais!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from usuarios where codigo = '{0}'", txt_codigo.Text);
            bd.Alterar(sql);
            MessageBox.Show("Cadastro de usuário excluido com sucesso!", "Excluir Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
