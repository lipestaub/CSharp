
namespace interfaceUsuario.UserControls
{
    partial class ucSituacao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.optAtivo = new System.Windows.Forms.RadioButton();
            this.optInativo = new System.Windows.Forms.RadioButton();
            this.gbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.optInativo);
            this.gbSituacao.Controls.Add(this.optAtivo);
            this.gbSituacao.Location = new System.Drawing.Point(4, 4);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(193, 63);
            this.gbSituacao.TabIndex = 0;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // optAtivo
            // 
            this.optAtivo.AutoSize = true;
            this.optAtivo.Location = new System.Drawing.Point(28, 29);
            this.optAtivo.Name = "optAtivo";
            this.optAtivo.Size = new System.Drawing.Size(49, 17);
            this.optAtivo.TabIndex = 0;
            this.optAtivo.TabStop = true;
            this.optAtivo.Text = "Ativo";
            this.optAtivo.UseVisualStyleBackColor = true;
            this.optAtivo.CheckedChanged += new System.EventHandler(this.optAtivo_CheckedChanged);
            // 
            // optInativo
            // 
            this.optInativo.AutoSize = true;
            this.optInativo.Location = new System.Drawing.Point(101, 29);
            this.optInativo.Name = "optInativo";
            this.optInativo.Size = new System.Drawing.Size(57, 17);
            this.optInativo.TabIndex = 1;
            this.optInativo.TabStop = true;
            this.optInativo.Text = "Inativo";
            this.optInativo.UseVisualStyleBackColor = true;
            this.optInativo.CheckedChanged += new System.EventHandler(this.optInativo_CheckedChanged);
            // 
            // ucSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSituacao);
            this.Name = "ucSituacao";
            this.Size = new System.Drawing.Size(200, 70);
            this.Load += new System.EventHandler(this.ucSituacao_Load);
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSituacao;
        private System.Windows.Forms.RadioButton optInativo;
        private System.Windows.Forms.RadioButton optAtivo;
    }
}
