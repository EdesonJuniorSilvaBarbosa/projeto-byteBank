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
    public partial class Frm_ValidaCpf_UC : UserControl
    {
        public Frm_ValidaCpf_UC()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            Msk_Cpf.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf = Cls_Uteis.Valida(Msk_Cpf.Text);

            if (validaCpf == true)
            {
                lbl_Resultado.Text = "Cpf válido";
                lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                lbl_Resultado.Text = "Cpf inválido";
                lbl_Resultado.ForeColor = Color.Red;

            }
        }
    }
}
