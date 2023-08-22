namespace PrimeiroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txnome = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.Button();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_confSenha = new System.Windows.Forms.TextBox();
            this.tx_ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lb_diferente = new System.Windows.Forms.Label();
            this.lbDiferente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // txnome
            // 
            this.txnome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txnome.Location = new System.Drawing.Point(111, 115);
            this.txnome.Name = "txnome";
            this.txnome.Size = new System.Drawing.Size(100, 20);
            this.txnome.TabIndex = 2;
            this.txnome.TextChanged += new System.EventHandler(this.t_TextChanged);
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.Lime;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(230, 381);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(87, 32);
            this.tx_nome.TabIndex = 3;
            this.tx_nome.Text = "Salvar";
            this.tx_nome.UseVisualStyleBackColor = false;
            this.tx_nome.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tx_email.Location = new System.Drawing.Point(114, 233);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(100, 20);
            this.tx_email.TabIndex = 5;
            this.tx_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tx_senha.Location = new System.Drawing.Point(114, 270);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(100, 20);
            this.tx_senha.TabIndex = 6;
            this.tx_senha.TextChanged += new System.EventHandler(this.tx_senha_TextChanged);
            // 
            // tx_confSenha
            // 
            this.tx_confSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tx_confSenha.Location = new System.Drawing.Point(159, 315);
            this.tx_confSenha.Name = "tx_confSenha";
            this.tx_confSenha.PasswordChar = '*';
            this.tx_confSenha.Size = new System.Drawing.Size(100, 20);
            this.tx_confSenha.TabIndex = 7;
            // 
            // tx_
            // 
            this.tx_.AutoSize = true;
            this.tx_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_.Location = new System.Drawing.Point(53, 115);
            this.tx_.Name = "tx_";
            this.tx_.Size = new System.Drawing.Size(60, 20);
            this.tx_.TabIndex = 8;
            this.tx_.Text = "Nome:";
            this.tx_.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "C.p.f:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conf.Senha:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(111, 194);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(100, 20);
            this.tx_cpf.TabIndex = 15;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(53, 154);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(84, 20);
            this.Telefone.TabIndex = 17;
            this.Telefone.Text = "Telefone:";
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(134, 156);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(100, 20);
            this.tx_telefone.TabIndex = 18;
            // 
            // lb_diferente
            // 
            this.lb_diferente.AutoSize = true;
            this.lb_diferente.Location = new System.Drawing.Point(588, 303);
            this.lb_diferente.Name = "lb_diferente";
            this.lb_diferente.Size = new System.Drawing.Size(0, 13);
            this.lb_diferente.TabIndex = 19;
            // 
            // lbDiferente
            // 
            this.lbDiferente.AutoSize = true;
            this.lbDiferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiferente.ForeColor = System.Drawing.Color.Red;
            this.lbDiferente.Location = new System.Drawing.Point(48, 366);
            this.lbDiferente.Name = "lbDiferente";
            this.lbDiferente.Size = new System.Drawing.Size(47, 15);
            this.lbDiferente.TabIndex = 20;
            this.lbDiferente.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDiferente);
            this.Controls.Add(this.lb_diferente);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_);
            this.Controls.Add(this.tx_confSenha);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.txnome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txnome;
        private System.Windows.Forms.Button tx_nome;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_confSenha;
        private System.Windows.Forms.Label tx_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.Label lb_diferente;
        private System.Windows.Forms.Label lbDiferente;
        private System.Windows.Forms.Button button1;
    }
}

