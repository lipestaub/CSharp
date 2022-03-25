using BaseDeDados;
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados.Pessoas
{
    public class TipoUsuarioBD
    {
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigoUsuario)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT U.codigo_tipo_usuario as CodigoTipoUsuario,
                                            TU.descricao AS DescricaoTipoUsuario
                                            FROM usuario as U
                                            INNER JOIN tipo_usuario as TU ON U.codigo_tipo_usuario = TU.codigo
                                            WHERE U.codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo",codigoUsuario);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["CodigoTipoUsuario"].ToString());
                        tipoUsuario.Descricao = reader["DescricaoTipoUsuario"].ToString();
                    }
                }
                catch (MySqlException mysqlEx)
                {
                    throw new Exception(mysqlEx.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
            return tipoUsuario;
        }

        public TipoUsuario Buscar(int codigo)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT codigo, descricao
                                            FROM tipo_usuario
                                            WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        tipoUsuario.Descricao = reader["descricao"].ToString();
                    }
                }
                catch (MySqlException mysqlEx)
                {
                    throw new Exception(mysqlEx.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
            return tipoUsuario;
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    string query = "SELECT codigo, descricao, '1' AS situacao FROM tipo_usuario ";

                    comando.CommandText = query;

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();

                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString()); // atribui valor ao codigo do usuario
                        oEntidade.Descricao = reader["descricao"].ToString();
                        oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());

                        listaEntidades.Add(oEntidade);
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

            return listaEntidades;
        }
    }
}
