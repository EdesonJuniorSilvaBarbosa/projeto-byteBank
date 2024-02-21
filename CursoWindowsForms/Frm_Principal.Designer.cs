namespace CursoWindowsForms
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.btn_HelloWorld = new System.Windows.Forms.Button();
            this.btn_Mascara = new System.Windows.Forms.Button();
            this.btn_ValidaCpf = new System.Windows.Forms.Button();
            this.btn_ValidaCpf2 = new System.Windows.Forms.Button();
            this.btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DemonstracaoKey
            // 
            this.btn_DemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("btn_DemonstracaoKey.Image")));
            this.btn_DemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.btn_DemonstracaoKey.Name = "btn_DemonstracaoKey";
            this.btn_DemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.btn_DemonstracaoKey.TabIndex = 0;
            this.btn_DemonstracaoKey.Text = "Demonstração Key";
            this.btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.btn_DemonstracaoKey.Click += new System.EventHandler(this.btn_DemonstracaoKey_Click);
            // 
            // btn_HelloWorld
            // 
            this.btn_HelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("btn_HelloWorld.Image")));
            this.btn_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.btn_HelloWorld.Name = "btn_HelloWorld";
            this.btn_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.btn_HelloWorld.TabIndex = 1;
            this.btn_HelloWorld.Text = "Hello World";
            this.btn_HelloWorld.UseVisualStyleBackColor = true;
            this.btn_HelloWorld.Click += new System.EventHandler(this.btn_HelloWorld_Click);
            // 
            // btn_Mascara
            // 
            this.btn_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mascara.Image")));
            this.btn_Mascara.Location = new System.Drawing.Point(252, 12);
            this.btn_Mascara.Name = "btn_Mascara";
            this.btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.btn_Mascara.TabIndex = 2;
            this.btn_Mascara.Text = "Máscara";
            this.btn_Mascara.UseVisualStyleBackColor = true;
            this.btn_Mascara.Click += new System.EventHandler(this.btn_Mascara_Click);
            // 
            // btn_ValidaCpf
            // 
            this.btn_ValidaCpf.Image = ((System.Drawing.Image)(resources.GetObject("btn_ValidaCpf.Image")));
            this.btn_ValidaCpf.Location = new System.Drawing.Point(12, 66);
            this.btn_ValidaCpf.Name = "btn_ValidaCpf";
            this.btn_ValidaCpf.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaCpf.TabIndex = 3;
            this.btn_ValidaCpf.Text = "Valida CPF";
            this.btn_ValidaCpf.UseVisualStyleBackColor = true;
            this.btn_ValidaCpf.Click += new System.EventHandler(this.btn_ValidaCpf_Click);
            // 
            // btn_ValidaCpf2
            // 
            this.btn_ValidaCpf2.Image = ((System.Drawing.Image)(resources.GetObject("btn_ValidaCpf2.Image")));
            this.btn_ValidaCpf2.Location = new System.Drawing.Point(132, 66);
            this.btn_ValidaCpf2.Name = "btn_ValidaCpf2";
            this.btn_ValidaCpf2.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaCpf2.TabIndex = 4;
            this.btn_ValidaCpf2.Text = "Valida CPF 2";
            this.btn_ValidaCpf2.UseVisualStyleBackColor = true;
            this.btn_ValidaCpf2.Click += new System.EventHandler(this.btn_ValidaCpf2_Click);
            // 
            // btn_ValidaSenha
            // 
            this.btn_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("btn_ValidaSenha.Image")));
            this.btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.btn_ValidaSenha.Name = "btn_ValidaSenha";
            this.btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaSenha.TabIndex = 5;
            this.btn_ValidaSenha.Text = "Valida Senha";
            this.btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.btn_ValidaSenha.Click += new System.EventHandler(this.btn_ValidaSenha_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.btn_ValidaSenha);
            this.Controls.Add(this.btn_ValidaCpf2);
            this.Controls.Add(this.btn_ValidaCpf);
            this.Controls.Add(this.btn_Mascara);
            this.Controls.Add(this.btn_HelloWorld);
            this.Controls.Add(this.btn_DemonstracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DemonstracaoKey;
        private System.Windows.Forms.Button btn_HelloWorld;
        private System.Windows.Forms.Button btn_Mascara;
        private System.Windows.Forms.Button btn_ValidaCpf;
        private System.Windows.Forms.Button btn_ValidaCpf2;
        private System.Windows.Forms.Button btn_ValidaSenha;
    }
}