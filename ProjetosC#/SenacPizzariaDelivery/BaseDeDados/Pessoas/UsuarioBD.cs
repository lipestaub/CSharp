using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDeDados.Pessoas
{
    public class UsuarioBD
    {
        public List<Usuario> ListarUsuarios()
        {
            var listaUsuario = new List<Usuario>();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuario " + "WHERE situacao = 1; ";

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();

                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString()); // atribui valor ao codigo do usuario
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());

                        listaUsuario.Add(oUsuario);
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

            return listaUsuario;
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
                    string query = "SELECT codigo, nome AS descricao, situacao FROM usuario ";

                    if (status != Status.Todos)
                    {
                        //adiciona clausula WHERE
                        query += "WHERE situacao = @situacao";
                        comando.Parameters.AddWithValue("situacao", (int) status);
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

        public Usuario Buscar(int codigo)
        {
            var usuario = new Usuario();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuario " + "WHERE codigo = @codigo;";

                    comando.Parameters.AddWithValue("codigo", (int)codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario.Codigo = Convert.ToInt32(reader["codigo"].ToString()); // atribui valor ao codigo do usuario
                        usuario.Nome = reader["nome"].ToString();
                        usuario.Login = reader["login"].ToString();
                        usuario.Senha = reader["senha"].ToString();
                        usuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        usuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        usuario.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        usuario.TipoUsuario = new TipoUsuario() { Codigo = Convert.ToInt16(reader["codigo_tipo_usuario"].ToString()) };
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

            return usuario;
        }

        public bool Inserir(Usuario usuario)
        {
            bool retorno;

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = @"INSERT INTO usuario (codigo_tipo_usuario, codigo_usr_alteracao,dt_alteracao, login,nome,senha,situacao) VALUES(@tipo_usuario, @usuario_alteracao, NOW(), @login, @nome, @senha, @situacao)";

                    comando.Parameters.AddWithValue("tipo_usuario", usuario.TipoUsuario.Codigo);
                    comando.Parameters.AddWithValue("usuario_alteracao", usuario.CodigoUsrAlteracao);
                    comando.Parameters.AddWithValue("login", usuario.Login);
                    comando.Parameters.AddWithValue("nome", usuario.Nome);
                    comando.Parameters.AddWithValue("senha", usuario.Senha);
                    comando.Parameters.AddWithValue("situacao", (int)usuario.Status);

                    int valorRetorno = comando.ExecuteNonQuery();

                    if (valorRetorno < 1)
                    {
                        retorno = false;
                    }
                    else
                    {
                        retorno = true;
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

            return retorno;
        }

        public bool Atualizar(Usuario usuario)
        {
            bool retorno;

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = @"UPDATE usuario SET codigo_tipo_usuario = @tipo_usuario, codigo_usr_alteracao = @usuario_alteracao, dt_alteracao = NOW(), login = @login, nome = @nome, senha = @senha, situacao = @situacao WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("tipo_usuario", usuario.TipoUsuario.Codigo);
                    comando.Parameters.AddWithValue("usuario_alteracao", usuario.CodigoUsrAlteracao);
                    comando.Parameters.AddWithValue("login", usuario.Login);
                    comando.Parameters.AddWithValue("nome", usuario.Nome);
                    comando.Parameters.AddWithValue("senha", usuario.Senha);
                    comando.Parameters.AddWithValue("situacao", (int)usuario.Status);
                    comando.Parameters.AddWithValue("codigo", usuario.Codigo);

                    int valorRetorno = comando.ExecuteNonQuery();

                    if (valorRetorno < 1)
                    {
                        retorno = false;
                    }
                    else
                    {
                        retorno = true;
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

            return retorno;
        }

        public bool Excluir(int codigo)
        {
            bool retorno;

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();

                    comando = conexao.CreateCommand();
                    comando.CommandText = @"DELETE FROM usuario WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo", (int)codigo);

                    int valorRetorno = comando.ExecuteNonQuery();

                    if (valorRetorno < 1)
                    {
                        retorno = false;
                    }
                    else
                    {
                        retorno = true;
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

            return retorno;
        }
    }
}
