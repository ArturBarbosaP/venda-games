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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        Conexao bd = new Conexao();
        string sql;
        int quantidade; 
        double valor_total;
        string valor_jogo;


        private void Listar()
        {
            sql = string.Format("select ID, NOME, EMAIL, CPF, TELEFONE TEL, QUANTIDADE QTD, VALOR_TOTAL R$, JOGOS_ID from vendas");
            dtg_listarvendas.DataSource = bd.Consultar(sql);
        }

        private void Listar_Jogos()
        {
            sql = string.Format("select ID, NOME, PRECO R$, QUANTIDADE QTD from jogos");
            dtg_jogos.DataSource = bd.Consultar(sql);
        }

        private void Limpar()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_cpf.Clear();
            txt_telefone.Clear();
            txt_quantidade.Clear();
            txt_valor.Clear();
            txt_jogoid.Clear();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            Listar();
            Limpar();
            Listar_Jogos();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.IndexOf(".") == -1 || txt_email.Text.IndexOf("@") == -1)
            {
                MessageBox.Show("Insira um email válido!", "Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("insert into vendas values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                 txt_nome.Text, txt_email.Text, txt_cpf.Text.Replace(",", "."), txt_telefone.Text, txt_quantidade.Text, txt_valor.Text.Replace(",", "."), txt_jogoid.Text);
                bd.Alterar(sql);
                sql = string.Format("update jogos set quantidade = quantidade -'{0}' where id = '{1}';", txt_quantidade.Text, txt_jogoid.Text);
                bd.Alterar(sql);
                MessageBox.Show("Venda cadastrada com sucesso!", "Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                Listar();
                Listar_Jogos();
            }            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from vendas where id = '{0}' or nome = '{1}'", txt_id.Text, txt_nome.Text);
            buscar = bd.Consultar(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_id.Text = buscar.Rows[0]["id"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_email.Text = buscar.Rows[0]["email"].ToString();
                txt_cpf.Text = buscar.Rows[0]["cpf"].ToString();
                txt_telefone.Text = buscar.Rows[0]["telefone"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                txt_valor.Text = buscar.Rows[0]["valor_total"].ToString();
                txt_jogoid.Text = buscar.Rows[0]["jogos_id"].ToString();

                txt_valor.Text = txt_valor.Text.Replace(",", ".");

                quantidade = int.Parse(txt_quantidade.Text);
            }
            else
            {
                MessageBox.Show("Cadastro de venda não encontrado!", "Buscar Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.IndexOf(".") == -1 || txt_email.Text.IndexOf("@") == -1)
            {
                MessageBox.Show("Insira um email válido!", "Cadastro de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = string.Format("update vendas set nome = '{0}', email = '{1}', cpf = '{2}', telefone = '{3}', quantidade = '{4}', valor_total = '{5}', jogos_id = '{6}' where id = '{7}'",
                                txt_nome.Text, txt_email.Text, txt_cpf.Text.Replace(",", "."), txt_telefone.Text, txt_quantidade.Text, txt_valor.Text.Replace(",", "."), txt_jogoid.Text, txt_id.Text);
                bd.Alterar(sql);
                if (quantidade > int.Parse(txt_quantidade.Text))
                {
                    sql = string.Format("update jogos set quantidade = quantidade +'{0}' where id = '{1}'", quantidade - int.Parse(txt_quantidade.Text), txt_jogoid.Text);
                    bd.Alterar(sql);
                }
                else if (quantidade < int.Parse(txt_quantidade.Text))
                {
                    sql = string.Format("update jogos set quantidade = quantidade -'{0}' where id = '{1}'", int.Parse(txt_quantidade.Text) - quantidade, txt_jogoid.Text);
                    bd.Alterar(sql);
                }
                MessageBox.Show("Venda alterada com sucesso!", "Alterar Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                Listar();
                Listar_Jogos();
            }            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from vendas where id = '{0}'", txt_id.Text);
            bd.Alterar(sql);
            sql = string.Format("update jogos set quantidade = quantidade +'{0}' where id = '{1}'", txt_quantidade.Text, txt_jogoid.Text);
            bd.Alterar(sql);
            MessageBox.Show("Venda excluida com sucesso!", "Excluir Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
            Listar();
            Listar_Jogos();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantidade.Text != "")
            {
                if (valor_jogo != null)
                {
                    valor_total = int.Parse(txt_quantidade.Text) * double.Parse(valor_jogo);
                    txt_valor.Text = valor_total.ToString();
                    txt_valor.Text = txt_valor.Text.Replace(",", ".");
                }
            }
            else
            {
                txt_valor.Text = "";
            }
        }


        private void txt_jogoid_TextChanged(object sender, EventArgs e)
        {
            DataTable buscar_jogo = new DataTable();
            sql = string.Format("select preco from jogos where id = '{0}'", txt_jogoid.Text);
            buscar_jogo = bd.Consultar(sql);
            if (buscar_jogo.Rows.Count > 0)
            {
                valor_jogo = buscar_jogo.Rows[0]["preco"].ToString();
            }

            if (txt_jogoid.Text != "")
            {
                if (txt_quantidade.Text != "")
                {
                    if (valor_jogo != null)
                    {
                        valor_total = int.Parse(txt_quantidade.Text) * double.Parse(valor_jogo);
                        txt_valor.Text = valor_total.ToString();
                        txt_valor.Text = txt_valor.Text.Replace(",", ".");
                    }
                }
            }            
            else
            {
                txt_valor.Text = "";
            }
        }

        private void dtg_listarvendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_email.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_cpf.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_telefone.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_quantidade.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_valor.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_jogoid.Text = dtg_listarvendas.Rows[e.RowIndex].Cells[7].Value.ToString();

            txt_valor.Text = txt_valor.Text.Replace(",", ".");
            txt_cpf.Text = txt_cpf.Text.Replace(",", ".");

            quantidade = int.Parse(txt_quantidade.Text);
        }

        private void dtg_jogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_jogoid.Text = dtg_jogos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_quantidade.Text = "1";
        }
    }
}
