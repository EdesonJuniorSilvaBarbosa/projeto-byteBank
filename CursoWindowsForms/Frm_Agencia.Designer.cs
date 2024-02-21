namespace CursoWindowsForms
{
    partial class Frm_Agencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agencia));
            this.tls_Principal = new System.Windows.Forms.ToolStrip();
            this.ApagatoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_Principal
            // 
            this.tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApagatoolStripButton1});
            this.tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.tls_Principal.Name = "tls_Principal";
            this.tls_Principal.Size = new System.Drawing.Size(375, 25);
            this.tls_Principal.TabIndex = 83;
            this.tls_Principal.Text = "toolStrip1";
            // 
            // ApagatoolStripButton1
            // 
            this.ApagatoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton1.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton1.Name = "ApagatoolStripButton1";
            this.ApagatoolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton1.Text = "toolStripButton1";
            this.ApagatoolStripButton1.Click += new System.EventHandler(this.ApagatoolStripButton1_Click);
            // 
            // Frm_Agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 325);
            this.Controls.Add(this.tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Agencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Busca";
            this.tls_Principal.ResumeLayout(false);
            this.tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_Principal;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton1;
    }
}