namespace radiobutton
{
    partial class Form1
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
            this.aprovado = new System.Windows.Forms.RadioButton();
            this.recuperacao = new System.Windows.Forms.RadioButton();
            this.confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aprovado
            // 
            this.aprovado.AutoSize = true;
            this.aprovado.Location = new System.Drawing.Point(373, 86);
            this.aprovado.Name = "aprovado";
            this.aprovado.Size = new System.Drawing.Size(70, 17);
            this.aprovado.TabIndex = 0;
            this.aprovado.TabStop = true;
            this.aprovado.Text = "aprovado";
            this.aprovado.UseVisualStyleBackColor = true;
            this.aprovado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // recuperacao
            // 
            this.recuperacao.AutoSize = true;
            this.recuperacao.Location = new System.Drawing.Point(324, 169);
            this.recuperacao.Name = "recuperacao";
            this.recuperacao.Size = new System.Drawing.Size(73, 17);
            this.recuperacao.TabIndex = 1;
            this.recuperacao.TabStop = true;
            this.recuperacao.Text = "reprovado";
            this.recuperacao.UseVisualStyleBackColor = true;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(334, 246);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 2;
            this.confirmar.Text = "confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.recuperacao);
            this.Controls.Add(this.aprovado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton aprovado;
        private System.Windows.Forms.RadioButton recuperacao;
        private System.Windows.Forms.Button confirmar;
    }
}

