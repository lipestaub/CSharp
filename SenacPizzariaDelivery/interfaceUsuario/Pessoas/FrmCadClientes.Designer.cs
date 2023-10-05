
namespace interfaceUsuario.Pessoas.Clientes
{
    partial class FrmCadClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBscCliente = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lvEnderecos = new System.Windows.Forms.ListView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.llbCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.ucSituacao1 = new interfaceUsuario.UserControls.ucSituacao();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCodigoCliente.Location = new System.Drawing.Point(12, 25);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoCliente_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(227, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNomeCliente.Location = new System.Drawing.Point(230, 26);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(502, 20);
            this.txtNomeCliente.TabIndex = 13;
            // 
            // btnBscCliente
            // 
            this.btnBscCliente.Image = global::interfaceUsuario.Properties.Resources.busca;
            this.btnBscCliente.Location = new System.Drawing.Point(118, 23);
            this.btnBscCliente.Name = "btnBscCliente";
            this.btnBscCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBscCliente.TabIndex = 11;
            this.btnBscCliente.UseVisualStyleBackColor = true;
            this.btnBscCliente.Click += new System.EventHandler(this.btnBscCliente_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(399, 464);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 50);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::interfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(225, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::interfaceUsuario.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(114, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 45);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::interfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lvEnderecos);
            this.gbEndereco.Controls.Add(this.btnEditar);
            this.gbEndereco.Controls.Add(this.btnRemover);
            this.gbEndereco.Controls.Add(this.btnAdicionar);
            this.gbEndereco.Controls.Add(this.checkBox1);
            this.gbEndereco.Controls.Add(this.llbCidade);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.lblComplemento);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Location = new System.Drawing.Point(15, 114);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(717, 271);
            this.gbEndereco.TabIndex = 20;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lvEnderecos
            // 
            this.lvEnderecos.HideSelection = false;
            this.lvEnderecos.Location = new System.Drawing.Point(9, 159);
            this.lvEnderecos.Name = "lvEnderecos";
            this.lvEnderecos.Size = new System.Drawing.Size(702, 77);
            this.lvEnderecos.TabIndex = 34;
            this.lvEnderecos.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::interfaceUsuario.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(113, 242);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::interfaceUsuario.Properties.Resources.excluir;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(6, 242);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(101, 23);
            this.btnRemover.TabIndex = 32;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::interfaceUsuario.Properties.Resources.confirmar;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(610, 131);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(101, 23);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(362, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "End. Padrão";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // llbCidade
            // 
            this.llbCidade.AutoSize = true;
            this.llbCidade.Location = new System.Drawing.Point(182, 117);
            this.llbCidade.Name = "llbCidade";
            this.llbCidade.Size = new System.Drawing.Size(43, 13);
            this.llbCidade.TabIndex = 29;
            this.llbCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCidade.Location = new System.Drawing.Point(185, 133);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(170, 20);
            this.txtCidade.TabIndex = 28;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBairro.Location = new System.Drawing.Point(9, 133);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(170, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 117);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 26;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(9, 85);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(170, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 69);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Número:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(182, 69);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(185, 85);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(526, 20);
            this.txtComplemento.TabIndex = 15;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRua.Location = new System.Drawing.Point(9, 41);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(702, 20);
            this.txtRua.TabIndex = 14;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 25);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 13;
            this.lblRua.Text = "Rua:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(230, 74);
            this.txtTelefoneCliente.Mask = "(00) 0000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneCliente.TabIndex = 21;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(227, 58);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(364, 58);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 23;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(367, 74);
            this.txtCelularCliente.Mask = "(00) 0 0000-0000";
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCelularCliente.TabIndex = 24;
            // 
            // ucSituacao1
            // 
            this.ucSituacao1.Location = new System.Drawing.Point(532, 391);
            this.ucSituacao1.Name = "ucSituacao1";
            this.ucSituacao1.Size = new System.Drawing.Size(200, 70);
            this.ucSituacao1.status = Entidades.Enumeradores.Status.Inativo;
            this.ucSituacao1.TabIndex = 25;
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 529);
            this.Controls.Add(this.ucSituacao1);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnBscCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadClientes";
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button btnBscCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox txtCelularCliente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label llbCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtRua;
        public UserControls.ucSituacao ucSituacao1;
        private System.Windows.Forms.ListView lvEnderecos;
    }
}