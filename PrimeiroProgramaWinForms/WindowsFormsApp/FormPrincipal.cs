using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNomes.Text))
            {
                // Adicionar o texto digitado na textBox na caixa de listagem
                listBoxNomes.Items.Add(textBoxNomes.Text);
                // Limpar o texto digitado
                textBoxNomes.Text = string.Empty;
                // Manter o foco do teclado
                textBoxNomes.Focus();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Obtem o item selecionado
            var item = listBoxNomes.SelectedIndex;
            if (item != -1)
            {
                // Remove o item da lista passando por parametro do indice do item
                listBoxNomes.Items.RemoveAt(item);
            }
            else
            {
                //Exibe uma caixa de mensagem com um botao OK e com um icone de erro
                MessageBox.Show("Nome não selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
