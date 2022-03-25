
namespace ProjetoComSelect
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.groupBoxInclusao = new System.Windows.Forms.GroupBox();
            this.textBoxInserir = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.groupBoxAlteracao = new System.Windows.Forms.GroupBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.groupBoxExclusao = new System.Windows.Forms.GroupBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxIdExcluir = new System.Windows.Forms.TextBox();
            this.textBoxIdConsulta = new System.Windows.Forms.TextBox();
            this.groupBoxConsulta.SuspendLayout();
            this.groupBoxInclusao.SuspendLayout();
            this.groupBoxAlteracao.SuspendLayout();
            this.groupBoxExclusao.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(291, 28);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 0;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.textBoxIdConsulta);
            this.groupBoxConsulta.Controls.Add(this.buttonConsultar);
            this.groupBoxConsulta.Location = new System.Drawing.Point(13, 12);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(390, 68);
            this.groupBoxConsulta.TabIndex = 1;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // groupBoxInclusao
            // 
            this.groupBoxInclusao.Controls.Add(this.textBoxInserir);
            this.groupBoxInclusao.Controls.Add(this.buttonInserir);
            this.groupBoxInclusao.Location = new System.Drawing.Point(13, 86);
            this.groupBoxInclusao.Name = "groupBoxInclusao";
            this.groupBoxInclusao.Size = new System.Drawing.Size(390, 84);
            this.groupBoxInclusao.TabIndex = 2;
            this.groupBoxInclusao.TabStop = false;
            this.groupBoxInclusao.Text = "Inclusão";
            // 
            // textBoxInserir
            // 
            this.textBoxInserir.Location = new System.Drawing.Point(17, 37);
            this.textBoxInserir.Name = "textBoxInserir";
            this.textBoxInserir.Size = new System.Drawing.Size(268, 20);
            this.textBoxInserir.TabIndex = 1;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(291, 34);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 0;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // groupBoxAlteracao
            // 
            this.groupBoxAlteracao.Controls.Add(this.textBoxNome);
            this.groupBoxAlteracao.Controls.Add(this.textBoxId);
            this.groupBoxAlteracao.Controls.Add(this.buttonAlterar);
            this.groupBoxAlteracao.Location = new System.Drawing.Point(13, 189);
            this.groupBoxAlteracao.Name = "groupBoxAlteracao";
            this.groupBoxAlteracao.Size = new System.Drawing.Size(390, 66);
            this.groupBoxAlteracao.TabIndex = 3;
            this.groupBoxAlteracao.TabStop = false;
            this.groupBoxAlteracao.Text = "Alteração";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(75, 23);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(210, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(18, 23);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(51, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(291, 20);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 0;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // groupBoxExclusao
            // 
            this.groupBoxExclusao.Controls.Add(this.buttonExcluir);
            this.groupBoxExclusao.Controls.Add(this.textBoxIdExcluir);
            this.groupBoxExclusao.Location = new System.Drawing.Point(13, 262);
            this.groupBoxExclusao.Name = "groupBoxExclusao";
            this.groupBoxExclusao.Size = new System.Drawing.Size(390, 66);
            this.groupBoxExclusao.TabIndex = 4;
            this.groupBoxExclusao.TabStop = false;
            this.groupBoxExclusao.Text = "Exclusão";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(291, 25);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 1;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxIdExcluir
            // 
            this.textBoxIdExcluir.Location = new System.Drawing.Point(17, 28);
            this.textBoxIdExcluir.Name = "textBoxIdExcluir";
            this.textBoxIdExcluir.Size = new System.Drawing.Size(52, 20);
            this.textBoxIdExcluir.TabIndex = 0;
            // 
            // textBoxIdConsulta
            // 
            this.textBoxIdConsulta.Location = new System.Drawing.Point(17, 28);
            this.textBoxIdConsulta.Name = "textBoxIdConsulta";
            this.textBoxIdConsulta.Size = new System.Drawing.Size(67, 20);
            this.textBoxIdConsulta.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 339);
            this.Controls.Add(this.groupBoxExclusao);
            this.Controls.Add(this.groupBoxAlteracao);
            this.Controls.Add(this.groupBoxInclusao);
            this.Controls.Add(this.groupBoxConsulta);
            this.Name = "FormPrincipal";
            this.Text = "Aplicativo";
            this.groupBoxConsulta.ResumeLayout(false);
            this.groupBoxConsulta.PerformLayout();
            this.groupBoxInclusao.ResumeLayout(false);
            this.groupBoxInclusao.PerformLayout();
            this.groupBoxAlteracao.ResumeLayout(false);
            this.groupBoxAlteracao.PerformLayout();
            this.groupBoxExclusao.ResumeLayout(false);
            this.groupBoxExclusao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.GroupBox groupBoxInclusao;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.GroupBox groupBoxAlteracao;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBoxInserir;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.GroupBox groupBoxExclusao;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxIdExcluir;
        private System.Windows.Forms.TextBox textBoxIdConsulta;
    }
}

