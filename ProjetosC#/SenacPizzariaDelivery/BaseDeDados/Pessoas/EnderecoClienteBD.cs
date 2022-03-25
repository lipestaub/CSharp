using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados.Pessoas
{
    public class EnderecoClienteBD
    {
        public List<Endereco> BuscarEnderecosCliente(int codigoCliente)
        {
            var enderecos = new List<Endereco>();

            int codEnderecoPadraoCliente = new EnderecoPadraoClienteBD().BuscarEnderecoPadraoCliente(codigoCliente);

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = " SELECT * FROM endereco_cliente " + " WHERE codigo_cliente = @codigoCliente ";
                    comando.Parameters.AddWithValue("codigoCliente", (int)codigoCliente);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var endereco = new Endereco();

                        endereco.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        endereco.Rua = reader["rua"].ToString();
                        endereco.Numero = Convert.ToInt32(reader["numero"].ToString());
                        endereco.Bairro = reader["bairro"].ToString();
                        endereco.Cidade = reader["cidade"].ToString();

                        if (reader["complemento"] != null)
                            endereco.Complemento = reader["complemento"].ToString();

                        if (endereco.Codigo == codEnderecoPadraoCliente)
                            endereco.EhEnderecoPadrao = true;

                        enderecos.Add(endereco);
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
            return enderecos;
        }
    }
}
