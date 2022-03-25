using interfaceUsuario.Login;
using interfaceUsuario.Pessoas;
using interfaceUsuario.Pessoas.Clientes;
using interfaceUsuario.Produtos.Adicionais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceUsuario
{
    public partial class MDIFrm : Form
    {
        public MDIFrm()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND: //preventing the form from being moved by the mouse.
                int command = m.WParam.ToInt32() & 0xfff0;
                if (command == SC_MOVE)
                return;
                break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK) //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private void MDIFrm_Load(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if (control is MdiClient) // testa se controle é MDI
                {
                    control.BackgroundImage = Properties.Resources.fundo;
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }

            var frmLogin = new FrmLogin(); // Cria variavel do tipo FrmLogin

            frmLogin.ShowDialog(); // Exibe o formulario de login em modal

            // verificar se o usuário logou
            if (!frmLogin.bFlagLogin)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadUsuarios());
        }

        private void AbrirFormularios(Form form)
        {
            form.WindowState = FormWindowState.Normal; // abre no modo retaurado
            form.StartPosition = FormStartPosition.Manual; // habilita as posição manual
            form.MdiParent = this; // define que o form pai é a tela principal
            form.Top = 0; // seta as coordenadas da tela
            form.Left = 0; // seta as coordenadas da tela
            form.Show(); // exibe

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadClientes());
        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadAdicionais());
        }
    }
}
