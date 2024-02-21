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
    public partial class Frm_Login : Form
    {
        public string senha;
        public string login;

        public Frm_Login()
        {
            InitializeComponent();
            lbl_Login.Text = "Usuário";
            lbl_Password.Text = "Senha";
            btn_Ok.Text = "OK";
            btn_Cancel.Text = "Cancel";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            senha = txt_Senha.Text;
            login = txt_Login.Text;

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txt_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
