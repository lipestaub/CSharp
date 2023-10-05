using Entidades.Enumeradores;
using interfaceUsuario.Módulos;
using interfaceUsuario.Pesquisas;
using Negocio.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceUsuario.Pessoas.Clientes
{
    public partial class FrmCadClientes : Form
    {
        public FrmCadClientes()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigoCliente);
        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
            var frmPesquisaCliente = new FrmPesquisaGenericaCliente("Listagem de Clientes", Entidades.Enumeradores.Status.Todos);

            frmPesquisaCliente.gbSituacao.Enabled = true;

            frmPesquisaCliente.ShowDialog();

            var retorno = frmPesquisaCliente.codigoRetorno;

            if (retorno < 1)

                return;

            txtCodigoCliente.Text = retorno.ToString();

            txtCodigoCliente_Validating(txtCodigoCliente, new CancelEventArgs());

            btnBscCliente.Focus();
        }

        private void txtCodigoCliente_Validating(object sender, CancelEventArgs e)
        {
            // verifica se o campo código está vazio
            if (txtCodigoCliente.Text.Trim().Equals(string.Empty)) return;

            // busca o usuário do banco
            var codigo = Convert.ToInt32(txtCodigoCliente.Text.Trim());
            var cliente = new ClienteNG().Buscar(Convert.ToInt32(txtCodigoCliente.Text.Trim()));

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            // popula os campos da tela
            btnExcluir.Enabled = true;

            txtNomeCliente.Text = cliente.Nome;
            txtTelefoneCliente.Text = cliente.Telefone.ToString();
            txtCelularCliente.Text = cliente.Celular.ToString();

            MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());

            // setar valor ativo/inativo
            ucSituacao1.InicializarSituacao(cliente.Status);
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
