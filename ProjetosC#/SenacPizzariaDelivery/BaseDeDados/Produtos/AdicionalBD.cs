using Entidades.Enumeradores;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Entidades.Produtos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados.Produtos
{
    public class AdicionalBD
    {
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
                    string query = "SELECT codigo, descricao, situacao FROM adicional ";

                    if (status != Status.Todos)
                    {
                        //adiciona clausula WHERE
                        query += "WHERE situacao = @situacao";
                        comando.Parameters.AddWithValue("situacao", (int)status);
                    }

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

        public Adicional Buscar(int codigo)
        {
            var adicional = new Adicional();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM adicional " + "WHERE codigo = @codigo;";

                    comando.Parameters.AddWithValue("codigo", (int)codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        adicional.Codigo = Convert.ToInt32(reader["codigo"].ToString()); // atribui valor ao codigo do usuario
                        adicional.Descricao = reader["descricao"].ToString();
                        adicional.Observacao = reader["observacao"].ToString();
                        adicional.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        adicional.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        adicional.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        adicional.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
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

            return adicional;
        }

    }
}
