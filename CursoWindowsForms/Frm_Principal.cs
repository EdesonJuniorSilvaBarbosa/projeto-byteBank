using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld f = new Frm_HelloWorld();
            f.ShowDialog();

        }

        private void btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void btn_ValidaCpf_Click(object sender, EventArgs e)
        {
            Frm_ValidaCpf f = new Frm_ValidaCpf();
            f.ShowDialog();
        }

        private void btn_ValidaCpf2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCpf2 f = new Frm_ValidaCpf2();
            f.ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
        }
    }
}
