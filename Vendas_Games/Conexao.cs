using System.Data;
using MySql.Data.MySqlClient;

namespace Vendas_Games
{
    class Conexao
    {
        private MySqlConnection conexao;

        public void Conectar()
        {
            conexao = new MySqlConnection("");
            conexao.Open();
        }
        
        public void Alterar (string sql)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable Consultar (string sql)
        {
            Conectar();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }

    }
}
