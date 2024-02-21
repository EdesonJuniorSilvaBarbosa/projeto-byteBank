namespace CursoWindowsForms
{
    partial class Frm_ValidaCpf2_UC
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
            this.Msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_Cpf
            // 
            this.Msk_Cpf.Location = new System.Drawing.Point(12, 45);
            this.Msk_Cpf.Mask = "000,000,000-00";
            this.Msk_Cpf.Name = "Msk_Cpf";
            this.Msk_Cpf.Size = new System.Drawing.Size(218, 20);
            this.Msk_Cpf.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(245, 42);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Valida
            // 
            this.btn_Valida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Valida.Location = new System.Drawing.Point(245, 71);
            this.btn_Valida.Name = "btn_Valida";
            this.btn_Valida.Size = new System.Drawing.Size(111, 23);
            this.btn_Valida.TabIndex = 3;
            this.btn_Valida.Text = "Valida";
            this.btn_Valida.UseVisualStyleBackColor = true;
            this.btn_Valida.Click += new System.EventHandler(this.btn_Valida_Click);
            // 
            // Frm_ValidaCpf2_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Valida);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Msk_Cpf);
            this.Name = "Frm_ValidaCpf2_UC";
            this.Size = new System.Drawing.Size(368, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_Cpf;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Valida;
    }
}