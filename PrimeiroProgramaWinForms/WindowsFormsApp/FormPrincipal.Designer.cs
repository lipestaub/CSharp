
namespace WindowsFormsApp
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
            this.labelNomes = new System.Windows.Forms.Label();
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.textBoxNomes = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomes
            // 
            this.labelNomes.AutoSize = true;
            this.labelNomes.Location = new System.Drawing.Point(10, 9);
            this.labelNomes.Name = "labelNomes";
            this.labelNomes.Size = new System.Drawing.Size(40, 13);
            this.labelNomes.TabIndex = 0;
            this.labelNomes.Text = "Nomes";
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.Location = new System.Drawing.Point(13, 30);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(165, 225);
            this.listBoxNomes.TabIndex = 1;
            // 
            // textBoxNomes
            // 
            this.textBoxNomes.Location = new System.Drawing.Point(184, 30);
            this.textBoxNomes.Name = "textBoxNomes";
            this.textBoxNomes.Size = new System.Drawing.Size(192, 20);
            this.textBoxNomes.TabIndex = 2;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(184, 56);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(192, 23);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(185, 85);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(191, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 274);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxNomes);
            this.Controls.Add(this.listBoxNomes);
            this.Controls.Add(this.labelNomes);
            this.Name = "FormPrincipal";
            this.Text = "Primeiro Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomes;
        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.TextBox textBoxNomes;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonExcluir;
    }
}

