using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados
{
    public class ConexaoBaseDados
    {

        private static readonly ConexaoBaseDados instanciaMySql = new ConexaoBaseDados();

        public static ConexaoBaseDados getInstancia()
        {
            return instanciaMySql;
        }
        public MySqlConnection getConexao()
        { 
            string conexao = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString(); 
            
            return new MySqlConnection(conexao);
        }

    }
}
