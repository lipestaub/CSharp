using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProjetoComSelect
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, System.EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Consultar(Convert.ToInt32(textBoxIdConsulta.Text));

        } // fim metodo click 

        private void buttonInserir_Click(object sender, System.EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Inserir(textBoxInserir.Text);
        }

        private void buttonAlterar_Click(object sender, System.EventArgs e)
        {
            using (MySqlConnection conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                if (string.IsNullOrEmpty(textBoxId.Text))
                {
                    MessageBox.Show("Id não informado.");
                    return;
                }
                try
                {
                    conexao.Open();
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "UPDATE usuario set nome = @nomeUsuario WHERE id = @id";
                    comando.Parameters.AddWithValue("nomeUsuario", textBoxNome.Text);
                    comando.Parameters.AddWithValue("id", Convert.ToInt32(textBoxId.Text));
                    int retorno = comando.ExecuteNonQuery();
                    if (retorno < 1)
                        MessageBox.Show("ERRO AO ATUALIZAR!");
                    else
                    {
                        MessageBox.Show("Usuário alterado com sucesso!");
                        textBoxId.Text = string.Empty;
                        textBoxNome.Text = string.Empty;
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "DELETE FROM usuario WHERE id = @id";
                    comando.Parameters.AddWithValue("id", Convert.ToInt32(textBoxIdExcluir.Text));
                    int retorno = comando.ExecuteNonQuery();
                    if (retorno < 1)
                    {
                        MessageBox.Show("ERRO AO EXCLUIR USUÁRIO.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuário excluído com sucesso!");
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
