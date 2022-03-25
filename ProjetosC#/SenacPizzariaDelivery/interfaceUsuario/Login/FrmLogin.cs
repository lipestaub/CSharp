using Entidades.Sistema;
using Negocio.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceUsuario.Login
{
    public partial class FrmLogin : Form
    {
        public bool bFlagLogin;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var versao = Assembly.GetExecutingAssembly().GetName().Version;

            lblVersao.Text = string.Format(lblVersao.Text, versao.Major, versao.Minor, versao.Build, versao.Revision); // atribui o texto de lblVersao o valor de cada value da var versao

            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            var listaUsuarios = new UsuarioNG().ListarUsuarios();

            if (listaUsuarios.Count > 0)
            {
                foreach (var usuario in listaUsuarios)
                {
                    // acessa a lista e adiciona itens nesta lista
                    cmbUsuarios.Items.Add(new ComboBoxItemUsuario(usuario.Login, usuario.Codigo, usuario.Senha));
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose(); // fecha a tela de login
            bFlagLogin = false; // login não realizado
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // verificar usuario e senha
            if (txtSenha.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Senha não informada.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (cmbUsuarios.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar um usuário para acessar o sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuarioSelecionado = (ComboBoxItemUsuario)cmbUsuarios.SelectedItem;

            if (usuarioSelecionado.Senha != txtSenha.Text)
            {
                MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sessao.Usuario = new Entidades.Entidade(usuarioSelecionado.Codigo, usuarioSelecionado.Login);

            Sessao.TipoUsuario = new TipoUsuarioNG().BuscarTipoUsuarioDoUsuario(usuarioSelecionado.Codigo);

            bFlagLogin = true;

            this.Close();
        }
    }
}
