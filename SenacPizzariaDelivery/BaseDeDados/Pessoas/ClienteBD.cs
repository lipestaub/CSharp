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
    public class ClienteBD
    {
        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string nome)
        {
            var listaEntidades = new List<EntidadeViewPesquisaCliente>();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    string query = "SELECT codigo, nome, telefone, celular FROM cliente ";

                    if (status != Status.Todos)
                        query += "WHERE situacao = @situacao";

                    if (!nome.Equals(string.Empty))
                    {
                        if (status == Status.Todos)
                            query += " WHERE ";
                        else
                            query += " AND ";

                        var termos = nome.Split(' ');

                        foreach (var termo in termos)
                        {
                            query += "nome LIKE '%" + termo + "%' AND";
                        }

                        query = query.Substring(0, query.Length - 3);
                    }

                    if (status != Status.Todos)
                    comando.Parameters.AddWithValue("situacao", (int)status);

                    comando.CommandText = query;

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisaCliente();

                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString()); // atribui valor ao codigo do usuario
                        oEntidade.Nome = reader["nome"].ToString();
                        if (reader["telefone"] != null)

                            oEntidade.Telefone = Convert.ToInt64(reader["telefone"]).ToString("(##) ####-####");

                        if (reader["celular"] != null)

                            oEntidade.Telefone = Convert.ToInt64(reader["celular"]).ToString("(##) # ####-####");

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

        public Cliente Buscar(int codigo)
        {
            var cliente = new Cliente();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM cliente " + "WHERE codigo = @codigo;";

                    comando.Parameters.AddWithValue("codigo", (int)codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        cliente.Nome = reader["nome"].ToString();

                        if (reader["telefone"] != null)
                            cliente.Telefone = Convert.ToInt64(reader["telefone"]);

                        if (reader["celular"] != null)
                            cliente.Celular = Convert.ToInt64(reader["celular"]);

                        cliente.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        cliente.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        cliente.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        cliente.Enderecos = new EnderecoClienteBD().BuscarEnderecosCliente(cliente.Codigo);
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

            return cliente;
        }
    }
}
