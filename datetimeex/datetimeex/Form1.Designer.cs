namespace datetimeex
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
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Location = new System.Drawing.Point(281, 27);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(200, 20);
            this.dtp_nascimento.TabIndex = 0;
            this.dtp_nascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(529, 193);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 1;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(85, 307);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(74, 13);
            this.lb_resultado.TabIndex = 2;
            this.lb_resultado.Text = "a sua idade é:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.dtp_nascimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label lb_resultado;
    }
}

