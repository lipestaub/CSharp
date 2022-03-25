using MySql.Data.MySqlClient;
using System.Configuration;

namespace ProjetoComSelect
{
    public class ConexaoBD
    {
        // privado somente leitura  tipo  nome      recebe nova instancia
        private readonly static ConexaoBD conexaoBD = new ConexaoBD();

        // obtem uma instancia da conexao.
        public static ConexaoBD GetInstancia()
        {
            return conexaoBD;
        }

        // retorna a conexão do MySql
        public MySqlConnection GetConexao()
        {
            // acessa o arquivo de configuracao chamada App.config
            // e lê a string de conexao
            string con = ConfigurationManager
                .ConnectionStrings["MySQLConnectionString"].ToString();
            // criar uma conexão com o banco de dados
            MySqlConnection conexao = new MySqlConnection(con);

            return conexao;
        } 
    }
}
