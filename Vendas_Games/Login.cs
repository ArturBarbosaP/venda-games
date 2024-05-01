using System.Data;

namespace Vendas_Games
{
    class Login
    {
        private static string nome;
        private static string tipo;

        public bool validarUsuario (string usuario, string senha)
        {
            Conexao bd = new Conexao();
            string sql = string.Format("select * from usuarios where usuario = '{0}' and senha = '{1}'", usuario, senha);
            DataTable data = new DataTable();
            data = bd.Consultar(sql);
            if (data.Rows.Count > 0)
            {
                nome = data.Rows[0]["nome"].ToString();
                tipo = data.Rows[0]["tipo"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string UsuarioLogado()
        {
            return nome;
        }

        public string TipoUsuario()
        {
            return tipo;
        }

        public bool primeiroLogin()
        {
            Conexao bd = new Conexao();
            string sql = string.Format("select count(codigo) from USUARIOS");
            DataTable consulta = new DataTable();
            consulta = bd.Consultar(sql);
            string count = consulta.Rows[0]["count(codigo)"].ToString();

            if (count == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
