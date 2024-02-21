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
    public partial class Frm_Agencia : Form
    {
        public Frm_Agencia()
        {
            InitializeComponent();
            this.Text = "Cadastro de Agência";
            tls_Principal.Items[1].ToolTipText = "Fechar a caixa de diálogo";
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
