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
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void btn_VerConteudo_Click(object sender, EventArgs e)
        {
            lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void btn_Cep_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }

        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }

        private void btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }

        private void btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "000000";
            lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }
    }
}
