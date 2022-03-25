using Entidades.Enumeradores;
using Entidades.Sistema;
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
    public partial class FrmPesquisaGenerica : Form
    {
        // variavel para exibir a listagem
        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        // variavel para armazenar o codigo
        public int codigoRetorno = 0;
        public FrmPesquisaGenerica(string strTitulo, Status status)
        {
            InitializeComponent();

            this.Text = strTitulo; // atribui um novo título para a tela

            if (status == Status.Ativo)
            {
                optAtivos.Checked = true;
            }
            else if(status == Status.Inativo)
            {
                optInativos.Checked = true;
            }
            else
            {
                optTodos.Checked = true;
            }
        }

        // carrega a lista de usuarios
        private void PreencherLista(List<EntidadeViewPesquisa> listaRetorno)
        {
            lvlListagem.Clear(); // limpa a lista
            lvlListagem.View = View.Details; // define o tipo de lista
            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Descrição", 280, HorizontalAlignment.Left);

            foreach(var item in listaRetorno)
            {
                if (!optTodos.Checked)
                {
                    if(optAtivos.Checked && item.Status != Entidades.Enumeradores.Status.Ativo)
                    {
                        continue;
                    }

                    if (optInativos.Checked && item.Status != Entidades.Enumeradores.Status.Inativo)
                    {
                        continue;
                    }
                }

                var linha = new String[2];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao;

                var itemListView = new ListViewItem(linha); // monta o objeto listView

                lvlListagem.Items.Add(itemListView); // adiciona o item nos itens da listView
            }
        }

        public void LimparCampos()
        {
            txtBusca.Text = string.Empty;
            codigoRetorno = 0;
        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            PreencherLista(lista);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(lvlListagem.SelectedIndices.Count <= 0) // verifica se existe um item selecionado na lista
            {
                return;
            }

            var IndiceItemSelecionado = Convert.ToInt32(lvlListagem.SelectedIndices[0]); // pega o indice da linha selecionada

            if (IndiceItemSelecionado >= 0)
            {
                codigoRetorno = Convert.ToInt32(lvlListagem.Items[IndiceItemSelecionado].Text);

                btnSair_Click(btnSair, new EventArgs());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvlListagem_DoubleClick(object sender, EventArgs e)
        {
            btnConfirmar_Click(btnConfirmar, new EventArgs());
        }

        private void optTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (optTodos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (optAtivos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (optInativos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Trim().Equals(string.Empty))
            {
                return;
            }

            // monta lista e filtra pela descrição
            var list = new List<EntidadeViewPesquisa>
                (from usuario in lista
                 where usuario.Descricao.Trim().ToLower().Contains(txtBusca.Text.Trim().ToLower())
                 select usuario
                );

            PreencherLista(list);
        }
    }
}
