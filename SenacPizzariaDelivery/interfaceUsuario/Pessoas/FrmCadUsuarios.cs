using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using interfaceUsuario.Módulos;
using interfaceUsuario.Pesquisas;
using Negocio.Pessoas;
using System;
using System.Windows.Forms;

namespace interfaceUsuario.Pessoas
{
    public partial class FrmCadUsuarios : Form
    {
        private bool isNew;
        public FrmCadUsuarios()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigoUsuario);
            MascaraCampoCodigo.AplicarEventos(txtCodigoTipoUsuario);
            LimparCampos();
        }

        private void btnBscUsuario_Click(object sender, EventArgs e)
        {
            // chamada do UsuárioNG > UsuárioBD

            var listaUsuarios = new UsuarioNG().ListarEntidadesViewPesquisa(Entidades.Enumeradores.Status.Todos);

            if (listaUsuarios.Count < 1)
            {
                MessageBox.Show("Sem dados para exibir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frmPesquisa = new FrmPesquisaGenerica("Listagem de usuários", Status.Todos); // cria a tela de pesquisa

            frmPesquisa.lista = listaUsuarios; // carrega a lista de usuarios cadastrados
            frmPesquisa.ShowDialog(); // exibe a tela de pesquisa

            if (frmPesquisa.codigoRetorno > 0)
            {
                txtCodigoUsuario.Text = frmPesquisa.codigoRetorno.ToString();

                txtCodigoUsuario_Validating(txtCodigoUsuario, new System.ComponentModel.CancelEventArgs());

                btnBscUsuario.Focus();
            }

            isNew = false;
        }

        private void txtCodigoUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // verifica se o campo código está vazio
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty)) return;

            // busca o usuário do banco
            var codigo = Convert.ToInt32(txtCodigoUsuario.Text.Trim());
            var usuario = new UsuarioNG().Buscar(codigo);

            if (usuario.Codigo < 1) return;

            // popula os campos da tela
            btnExcluir.Enabled = true;

            txtNomeUsuario.Text = usuario.Nome;
            txtLoginUsuario.Text = usuario.Login;
            txtSenhaUsuario.Text = usuario.Senha;
            txtCodigoTipoUsuario.Text = usuario.TipoUsuario.Codigo.ToString();

            txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new System.ComponentModel.CancelEventArgs());

            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());

            // setar valor ativo/inativo
            ucSituacao1.InicializarSituacao(usuario.Status);
        }

        public void LimparCampos()
        {
            txtCodigoUsuario.Text = new UsuarioNG().BuscarProximoCodigo().ToString();

            // limpa os campos
            txtNomeUsuario.Text = string.Empty;
            txtLoginUsuario.Text = string.Empty;
            txtSenhaUsuario.Text = string.Empty;
            txtCodigoTipoUsuario.Text = string.Empty;
            lblMstTipoUsuario.Text = string.Empty;

            // desabilita o botão excluir
            btnExcluir.Enabled = false;

            //set o valor ativo
            ucSituacao1.InicializarSituacao(Status.Ativo);

            //formata a máscara do campo código
            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());

            // define o foco
            txtNomeUsuario.Focus();
            txtNomeUsuario.Select();

            isNew = true;
        }

        private void txtCodigoTipoUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCodigoTipoUsuario.Text.Trim().Equals(string.Empty)) return;

            // pega cpdigo digitado no txtCodigoUsuario
            var codigo = Convert.ToInt32(txtCodigoTipoUsuario.Text.Trim());
            // busca o tipo do usuario
            var tipoUsuario = new TipoUsuarioNG().Buscar(codigo);

            if (tipoUsuario == null)
            {
                MessageBox.Show("Tipo de usuário não cadastrado.");
                txtCodigoTipoUsuario.Focus();
                return;
            }
            else
            {
                //carrega a descrição do tipo do usuário
                lblMstTipoUsuario.Text = tipoUsuario.Descricao;
            }
            btnBscUsuario.Focus();
        }

        private bool ValidarCampos()
        {
            if (txtNomeUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Nome deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txtLoginUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Login deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txtSenhaUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Senha deve ser informada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (txtCodigoTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Tipo de usuário deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var usuario = new Usuario();

            usuario.Codigo = Convert.ToInt32(txtCodigoUsuario.Text);
            usuario.Nome = txtNomeUsuario.Text;
            usuario.Login = txtLoginUsuario.Text;
            usuario.Senha = txtSenhaUsuario.Text;
            usuario.TipoUsuario = new TipoUsuario() { Codigo = Convert.ToInt16(txtCodigoTipoUsuario.Text)};
            usuario.Status = ucSituacao1.status;
            usuario.CodigoUsrAlteracao = Sessao.Usuario.Codigo;


            if(isNew == true)
            {
                bool inseriu = new UsuarioNG().Inserir(usuario);

                if (inseriu)
                {
                    MessageBox.Show("Registro cadastrado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Código deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                usuario.Codigo = Convert.ToInt32(txtCodigoUsuario.Text);

                bool atualizou = new UsuarioNG().Atualizar(usuario);

                if (atualizou)
                {
                    MessageBox.Show("Registro atualizado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnBscTipoUsuario_Click(object sender, EventArgs e)
        {
            // chamada do UsuárioNG > UsuárioBD

            var listaTiposUsuario = new TipoUsuarioNG().ListarEntidadesViewPesquisa(Entidades.Enumeradores.Status.Todos);

            if (listaTiposUsuario.Count < 1)
            {
                MessageBox.Show("Sem dados para exibir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frmPesquisa = new FrmPesquisaGenerica("Listagem de tipos de usuário", Status.Todos); // cria a tela de pesquisa

            frmPesquisa.lista = listaTiposUsuario; // carrega a lista de tipos de usuario cadastrados
            frmPesquisa.ShowDialog(); // exibe a tela de pesquisa

            if (frmPesquisa.codigoRetorno > 0)
            {
                txtCodigoTipoUsuario.Text = frmPesquisa.codigoRetorno.ToString();

                txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new System.ComponentModel.CancelEventArgs());

                MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());

                btnBscTipoUsuario.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Selecione um usuário para excluir.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int codigo = Convert.ToInt32(txtCodigoUsuario.Text);

            var excluiu = new UsuarioNG().Excluir(codigo);

            if (excluiu)
            {
                MessageBox.Show("Usuário excluído com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimparCampos();
        }
    }
}
