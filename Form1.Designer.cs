namespace Ferramentas
{
    partial class frmMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnGerirColaboradores = new System.Windows.Forms.Button();
            this.btnGerirFerramentas = new System.Windows.Forms.Button();
            this.btnGerirRequesicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(239, 75);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // btnGerirColaboradores
            // 
            this.btnGerirColaboradores.Location = new System.Drawing.Point(53, 167);
            this.btnGerirColaboradores.Name = "btnGerirColaboradores";
            this.btnGerirColaboradores.Size = new System.Drawing.Size(147, 62);
            this.btnGerirColaboradores.TabIndex = 1;
            this.btnGerirColaboradores.Text = "Gerir Colaboradores";
            this.btnGerirColaboradores.UseVisualStyleBackColor = true;
            this.btnGerirColaboradores.Click += new System.EventHandler(this.btnGerirColaboradores_Click);
            // 
            // btnGerirFerramentas
            // 
            this.btnGerirFerramentas.Location = new System.Drawing.Point(206, 167);
            this.btnGerirFerramentas.Name = "btnGerirFerramentas";
            this.btnGerirFerramentas.Size = new System.Drawing.Size(147, 62);
            this.btnGerirFerramentas.TabIndex = 2;
            this.btnGerirFerramentas.Text = "Gerir Ferramentas";
            this.btnGerirFerramentas.UseVisualStyleBackColor = true;
            this.btnGerirFerramentas.Click += new System.EventHandler(this.btnGerirFerramentas_Click);
            // 
            // btnGerirRequesicoes
            // 
            this.btnGerirRequesicoes.Location = new System.Drawing.Point(359, 167);
            this.btnGerirRequesicoes.Name = "btnGerirRequesicoes";
            this.btnGerirRequesicoes.Size = new System.Drawing.Size(147, 62);
            this.btnGerirRequesicoes.TabIndex = 3;
            this.btnGerirRequesicoes.Text = "Gerir Requesições";
            this.btnGerirRequesicoes.UseVisualStyleBackColor = true;
            this.btnGerirRequesicoes.Click += new System.EventHandler(this.btnGerirRequesicoes_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 316);
            this.Controls.Add(this.btnGerirRequesicoes);
            this.Controls.Add(this.btnGerirFerramentas);
            this.Controls.Add(this.btnGerirColaboradores);
            this.Controls.Add(this.lblMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnGerirColaboradores;
        private System.Windows.Forms.Button btnGerirFerramentas;
        private System.Windows.Forms.Button btnGerirRequesicoes;
    }
}

