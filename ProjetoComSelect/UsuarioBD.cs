using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoComSelect
{
    public class UsuarioBD
    {
        public void Consultar(int idDoUsuario)
        {
            // criar uma conexão temporária 
            using (MySqlConnection conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                // tentar
                try
                {
                    // abrir a conexao com o banco
                    conexao.Open();
                    //MessageBox.Show("Conectou no banco de dados locadora","SUCESSO");
                    // cria um comando mysql
                    MySqlCommand command = new MySqlCommand();
                    // conecta o comando à conexao do banco de dados
                    command = conexao.CreateCommand();
                    // cria o SELECT de consulta na tabela usuario
                    command.CommandText = "SELECT id, nome FROM usuario WHERE id = @id";
                    command.Parameters.AddWithValue("id", idDoUsuario);
                    // cria um leitor
                    MySqlDataReader reader = command.ExecuteReader();
                    // enquanto o reader possui registros
                    while (reader.Read())
                    {   // verifica se a coluna nome possui valor
                        if (reader["nome"] != null)
                        {
                            MessageBox.Show("Usuário: id= " + reader["id"].ToString() + " - nome=" + reader["nome"].ToString());
                        }
                    }
                    // se nao der certo
                }
                catch (MySqlException erro)
                {
                    // dar uma mensagem para o usuário
                    MessageBox.Show("OPS ferrou:" + erro.Message, "ALERTA");
                }
                // e por fim
                finally
                {
                    // fechar a conexão
                    conexao.Close();
                } // fim try

            } // fim using
        }

        public void Inserir(string nomeDoUsuario)
        {
            using (MySqlConnection conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                try
                {
                    if (string.IsNullOrEmpty(nomeDoUsuario))
                    {
                        MessageBox.Show("Informe o nome do usuário!");
                        return;
                    }
                    // abre a conexao com o banco de dados(locadora)
                    conexao.Open();
                    // inserir registro na tabela usuario
                    // criar um comando mysql usando a conexão
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "INSERT INTO usuario (nome) values(@nomeUsuario);";
                    // adiciona parametro ao comando SQL substituindo @nomeUsuario pelo texto do campo textBoxInserir
                    comando.Parameters.AddWithValue("nomeUsuario", nomeDoUsuario);
                    var retorno = comando.ExecuteNonQuery();

                    if (retorno < 1)
                    {
                        MessageBox.Show("ERRO AO INSERIR");
                    }
                    else
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        // limpa a Caixa de texto
                        //textBoxInserir.Text = string.Empty;
                        // coloca o foco na caixa de texto
                        //textBoxInserir.Select();
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("OPS: " + erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
