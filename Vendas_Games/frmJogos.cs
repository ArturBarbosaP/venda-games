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
    public partial class frmJogos : Form
    {
        public frmJogos()
        {
            InitializeComponent();
        }

        Conexao bd = new Conexao();
        string sql, preco;

        private void Listar()
        {
            sql = string.Format("select ID, NOME, PRECO R$, PLATAFORMA, QUANTIDADE QTD, DESCRICAO, GENERO from jogos");
            dtg_listarjogos.DataSource = bd.Consultar(sql);
        }

        private void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_preco.Clear();
            cbx_plataforma.SelectedIndex = -1;
            txt_quantidade.Clear();
            txt_genero.Clear();
            txt_descricao.Clear();
        }

        private void Jogos_Load(object sender, EventArgs e)
        {
            Listar();
            Limpar();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into jogos values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
                                txt_nome.Text, txt_preco.Text.Replace(",", "."), cbx_plataforma.Text, txt_quantidade.Text, txt_descricao.Text, txt_genero.Text);
            bd.Alterar(sql);
            MessageBox.Show("Jogo cadastrado com sucesso!", "Cadastro de Jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from jogos where id = '{0}' or nome = '{1}'", txt_id.Text, txt_nome.Text);
            buscar = bd.Consultar(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_id.Text = buscar.Rows[0]["id"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                preco = buscar.Rows[0]["preco"].ToString();
                cbx_plataforma.Text = buscar.Rows[0]["plataforma"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                txt_genero.Text = buscar.Rows[0]["genero"].ToString();
                txt_descricao.Text = buscar.Rows[0]["descricao"].ToString();
                preco = preco.Replace(",", ".");
                txt_preco.Text = preco;
            }
            else
            {
                MessageBox.Show("Cadastro de jogo não encontrado!", "Buscar Jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update jogos set nome = '{0}', preco = '{1}', plataforma = '{2}', quantidade = '{3}', genero = '{4}', descricao = '{5}' where id = '{6}'",
                                 txt_nome.Text, txt_preco.Text.Replace(",", "."), cbx_plataforma.Text, txt_quantidade.Text, txt_genero.Text, txt_descricao.Text, txt_id.Text);
            bd.Alterar(sql);
            MessageBox.Show("Jogo alterado com sucesso!", "Alterar Jogos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from jogos where id = '{0}'", txt_id.Text);
            bd.Alterar(sql);
            MessageBox.Show("Jogo excluido com sucesso!", "Excluir Jogos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
            Listar();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listarjogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[1].Value.ToString();
            preco = dtg_listarjogos.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbx_plataforma.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_quantidade.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_descricao.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_genero.Text = dtg_listarjogos.Rows[e.RowIndex].Cells[6].Value.ToString();
            preco = preco.Replace(",", ".");
            txt_preco.Text = preco;
        }
    }
}
