using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados
{
    public class FuncoesBD
    {
        public int BuscarProximoCodigo(string sql)
        {
            int codigo = 1;

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = sql;

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {

                        codigo = Convert.ToInt32(reader["Auto_increment"].ToString()); // atribui valor ao codigo do usuario

                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }

            return codigo;
        }
    }
}
