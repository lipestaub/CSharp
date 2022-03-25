
namespace interfaceUsuario.Produtos.Adicionais
{
    partial class FrmCadAdicionais
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
            this.txtCodigoAdicional = new System.Windows.Forms.TextBox();
            this.btnBscAdicional = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoAdicional = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacaoAdicional = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorAdicional = new System.Windows.Forms.TextBox();
            this.ucSituacao1 = new interfaceUsuario.UserControls.ucSituacao();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigoAdicional
            // 
            this.txtCodigoAdicional.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCodigoAdicional.Location = new System.Drawing.Point(12, 25);
            this.txtCodigoAdicional.Name = "txtCodigoAdicional";
            this.txtCodigoAdicional.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAdicional.TabIndex = 2;
            this.txtCodigoAdicional.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoAdicional_Validating);
            // 
            // btnBscAdicional
            // 
            this.btnBscAdicional.Image = global::interfaceUsuario.Properties.Resources.busca;
            this.btnBscAdicional.Location = new System.Drawing.Point(118, 22);
            this.btnBscAdicional.Name = "btnBscAdicional";
            this.btnBscAdicional.Size = new System.Drawing.Size(75, 23);
            this.btnBscAdicional.TabIndex = 12;
            this.btnBscAdicional.UseVisualStyleBackColor = true;
            this.btnBscAdicional.Click += new System.EventHandler(this.btnBscAdicional_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(227, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricaoAdicional
            // 
            this.txtDescricaoAdicional.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDescricaoAdicional.Location = new System.Drawing.Point(230, 25);
            this.txtDescricaoAdicional.Name = "txtDescricaoAdicional";
            this.txtDescricaoAdicional.Size = new System.Drawing.Size(502, 20);
            this.txtDescricaoAdicional.TabIndex = 14;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(227, 57);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 15;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacaoAdicional
            // 
            this.txtObservacaoAdicional.Location = new System.Drawing.Point(230, 73);
            this.txtObservacaoAdicional.Multiline = true;
            this.txtObservacaoAdicional.Name = "txtObservacaoAdicional";
            this.txtObservacaoAdicional.Size = new System.Drawing.Size(502, 101);
            this.txtObservacaoAdicional.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(399, 304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 50);
            this.flowLayoutPanel1.TabIndex = 18;
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
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(626, 186);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "Valor:";
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Location = new System.Drawing.Point(629, 202);
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(100, 20);
            this.txtValorAdicional.TabIndex = 20;
            // 
            // ucSituacao1
            // 
            this.ucSituacao1.Location = new System.Drawing.Point(532, 228);
            this.ucSituacao1.Name = "ucSituacao1";
            this.ucSituacao1.Size = new System.Drawing.Size(200, 70);
            this.ucSituacao1.status = Entidades.Enumeradores.Status.Inativo;
            this.ucSituacao1.TabIndex = 17;
            // 
            // FrmCadAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 363);
            this.Controls.Add(this.txtValorAdicional);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ucSituacao1);
            this.Controls.Add(this.txtObservacaoAdicional);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtDescricaoAdicional);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnBscAdicional);
            this.Controls.Add(this.txtCodigoAdicional);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadAdicionais";
            this.Text = "Cadastro de adicionais";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoAdicional;
        private System.Windows.Forms.Button btnBscAdicional;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoAdicional;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacaoAdicional;
        private UserControls.ucSituacao ucSituacao1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorAdicional;
    }
}