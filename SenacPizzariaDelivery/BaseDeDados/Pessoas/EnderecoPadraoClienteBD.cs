using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados.Pessoas
{
    public class EnderecoPadraoClienteBD
    {
        public int BuscarEnderecoPadraoCliente(int codigoCliente)
        {
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = " SELECT codigo_endereco FROM endereco_padrao_cliente " + " WHERE codigo_cliente = @codigo_cliente ";
                    comando.Parameters.AddWithValue("codigo_cliente", (int)codigoCliente);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        return Convert.ToInt32(reader["codigo_endereco"].ToString());
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
            return -1;
        }
    }
}
