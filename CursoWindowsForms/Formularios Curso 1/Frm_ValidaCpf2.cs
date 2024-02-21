using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCpf2 : Form
    {
        public Frm_ValidaCpf2()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_Cpf.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_Cpf.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-","");
            vConteudo = vConteudo.Trim();

            if(vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 digitos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (MessageBox.Show("Você deseja realmente validar o cpf?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCpf = false;
                        validaCpf = Cls_Uteis.Valida(Msk_Cpf.Text);

                        if (validaCpf == true)
                        {
                            MessageBox.Show("Cpf válido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cpf inválido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

        }
    }

}
