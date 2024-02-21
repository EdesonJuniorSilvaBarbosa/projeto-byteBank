using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            lbl_ArquivoImagem.Text = nomeArquivoImagem;
            pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog cdb = new ColorDialog();
            if (cdb.ShowDialog() == DialogResult.OK)
            {
                lbl_ArquivoImagem.ForeColor = cdb.Color;
            }
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog fdb = new FontDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                lbl_ArquivoImagem.Font = fdb.Font;
            }
        }
    }
}
