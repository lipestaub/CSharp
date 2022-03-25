using Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceUsuario.UserControls
{
    public partial class ucSituacao : UserControl
    {
        public Status status { get; set; }

        public ucSituacao()
        {
            InitializeComponent();
        }

        private void ucSituacao_Load(object sender, EventArgs e)
        {
            // se estiver em modo de edição, é interrompido
            if (DesignMode) return;

            InicializarSituacao(Status.Ativo);

        }

        // quando o valor é alterado
        private void optAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (optAtivo.Checked)
            {
                status = Status.Ativo;
            }
        }

        private void optInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;

            if (optInativo.Checked)
            {
                status = Status.Inativo;
            }
        }

        public void InicializarSituacao(Status sts)
        {
            status = sts;

            if(status == Status.Ativo)
            {
                optAtivo.Checked = true;
            }
            else
            {
                optInativo.Checked = true;
            }
        }
    }
}
