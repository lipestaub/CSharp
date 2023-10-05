using Entidades.Enumeradores;
using interfaceUsuario.Módulos;
using interfaceUsuario.Pesquisas;
using Negocio.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceUsuario.Produtos.Adicionais
{
    public partial class FrmCadAdicionais : Form
    {
        public FrmCadAdicionais()
        {
            InitializeComponent();
        }

        private void btnBscAdicional_Click(object sender, EventArgs e)
        {
            var listaAdicionais = new AdicionalNG().ListarEntidadesViewPesquisa(Entidades.Enumeradores.Status.Todos);

            if (listaAdicionais.Count < 1)
            {
                MessageBox.Show("Sem dados para exibir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frmPesquisa = new FrmPesquisaGenerica("Listagem de adicionais", Status.Todos); // cria a tela de pesquisa

            frmPesquisa.lista = listaAdicionais; // carrega a lista de usuarios cadastrados
            frmPesquisa.ShowDialog(); // exibe a tela de pesquisa

            if (frmPesquisa.codigoRetorno > 0)
            {
                txtCodigoAdicional.Text = frmPesquisa.codigoRetorno.ToString();

                txtCodigoAdicional_Validating(txtCodigoAdicional, new System.ComponentModel.CancelEventArgs());

                btnBscAdicional.Focus();
            }

        }

        private void txtCodigoAdicional_Validating(object sender, CancelEventArgs e)
        {
            // verifica se o campo código está vazio
            if (txtCodigoAdicional.Text.Trim().Equals(string.Empty)) return;

            // busca o usuário do banco
            var codigo = Convert.ToInt32(txtCodigoAdicional.Text.Trim());
            var adicional = new AdicionalNG().Buscar(codigo);

            if (adicional.Codigo < 1) return;

            // popula os campos da tela
            btnExcluir.Enabled = true;

            txtDescricaoAdicional.Text = adicional.Descricao;
            txtObservacaoAdicional.Text = adicional.Observacao;
            txtValorAdicional.Text = adicional.Valor.ToString();

            MascaraCampoCodigo.RetornarMascara(txtCodigoAdicional, new EventArgs());

            // setar valor ativo/inativo
            ucSituacao1.InicializarSituacao(adicional.Status);
        }
    }
}
