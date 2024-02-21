using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;

        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_Resultado.Text = "";
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            lbl_Resultado.Text = forca.ToString();

            if (lbl_Resultado.Text == "Inaceitavel")
            {
                lbl_Resultado.ForeColor = Color.Red;

            }
            else if (lbl_Resultado.Text == "Fraca")
            {
                lbl_Resultado.ForeColor = Color.Orange;

            }
            else if (lbl_Resultado.Text == "Aceitavel")
            {
                lbl_Resultado.ForeColor = Color.LightGreen;

            }
            else if (lbl_Resultado.Text == "Forte")
            {
                lbl_Resultado.ForeColor = Color.YellowGreen;
            }
            else
            {
                lbl_Resultado.ForeColor = Color.DarkGreen;
            }
        }

        private void btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                btn_VerSenha.Text = "Esconder senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                btn_VerSenha.Text = "Ver senha";
            }
        }
    }
}