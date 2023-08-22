namespace prova2
{
    partial class gabarito
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
            this.bt_avaliar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_avaliar
            // 
            this.bt_avaliar.Location = new System.Drawing.Point(346, 62);
            this.bt_avaliar.Name = "bt_avaliar";
            this.bt_avaliar.Size = new System.Drawing.Size(75, 23);
            this.bt_avaliar.TabIndex = 10;
            this.bt_avaliar.Text = "avaliar";
            this.bt_avaliar.UseVisualStyleBackColor = true;
            this.bt_avaliar.Click += new System.EventHandler(this.bt_avaliar_Click);
            // 
            // gabarito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_avaliar);
            this.Name = "gabarito";
            this.Text = "gabarito";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_avaliar;
    }
}