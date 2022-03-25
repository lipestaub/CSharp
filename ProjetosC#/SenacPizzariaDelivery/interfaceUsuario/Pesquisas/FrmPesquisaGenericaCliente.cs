using Entidades.Enumeradores;
using Entidades.Sistema;
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

namespace interfaceUsuario.Pesquisas
{
    public partial class FrmPesquisaGenericaCliente : Form
    {
        // variavel para exibir a listagem
        public List<EntidadeViewPesquisaCliente> lista = new List<EntidadeViewPesquisaCliente>();
        // variavel para armazenar o codigo
        public int codigoRetorno = 0;
        internal object ucSituacao1;

        public FrmPesquisaGenericaCliente(string strTitulo, Status status)
        {
            InitializeComponent();

            this.Text = strTitulo; // atribui um novo título para a tela

            if (status == Status.Ativo)
            {
                optAtivos.Checked = true;
            }
            else if (status == Status.Inativo)
            {
                optInativos.Checked = true;
            }
            else
            {
                optTodos.Checked = true;
            }
        }

        // carrega a lista de usuarios
        private void PreencherLista(List<EntidadeViewPesquisaCliente> listaRetorno)
        {
            foreach (var item in listaRetorno)
            {
                // montando a linha do listView
                var linha = new string[4];

                linha[0] = item.Codigo.ToString();
                linha[1] = item.Nome;
                linha[2] = item.Telefone;
                linha[3] = item.Celular;

                // monta o objeto ListViewItem

                var itemListView = new ListViewItem(linha);

                // adicionar o item nos Itens da ListView

                lvlListagem.Items.Add(itemListView);
            }
        }

        public void LimparCampos()
        {
            txtBusca.Text = string.Empty;
            codigoRetorno = 0;
        }

        private void FrmPesquisaGenericaCliente_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            PrepararListView();

            BuscarClientes();
        }

        private void BuscarClientes()
        {
            Status status;

            if (optAtivos.Checked)
            {
                status = Status.Ativo;
            }
            else if (optInativos.Checked)
            {
                status = Status.Inativo;
            }
            else
            {
                status = Status.Todos;
            }

            PrepararListView();

            var lista = new ClienteNG().ListarPesquisaCliente(status, txtBusca.Text.Trim());

            if (lista.Count < 1) return;

            PreencherLista(lista);
        }

        private void PrepararListView()
        {

            lvlListagem.Clear();
            lvlListagem.View = View.Details;
            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Nome", 280, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Celular", 90, HorizontalAlignment.Left);
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (lvlListagem.SelectedIndices.Count <= 0) // verifica se existe um item selecionado na lista
            {
                return;
            }

            var IndiceItemSelecionado = Convert.ToInt32(lvlListagem.SelectedIndices[0]); // pega o indice da linha selecionada

            if (IndiceItemSelecionado >= 0)
            {
                codigoRetorno = Convert.ToInt32(lvlListagem.Items[IndiceItemSelecionado].Text);

                btnSair_Click_1(btnSair, new EventArgs());
            }
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBusca.Text.Trim().Equals(string.Empty))
            {
                return;
            }

            // monta lista e filtra pela descrição
            var list = new List<EntidadeViewPesquisaCliente>
                (from cliente in lista
                 where cliente.Nome.Trim().ToLower().Contains(txtBusca.Text.Trim().ToLower())
                 select cliente
                );

            PreencherLista(list);
        }

        private void optInativos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optInativos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optAtivos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optAtivos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optTodos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void lvlListagem_DoubleClick_1(object sender, EventArgs e)
        {
            btnConfirmar_Click_1(btnConfirmar, new EventArgs());
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
