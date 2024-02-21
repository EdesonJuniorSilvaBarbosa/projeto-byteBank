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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCpf = 0;
        int ControleValidaCpf2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        int ControleCadastroClientes = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;

            Frm_DesmonstracaoKey_UC u = new Frm_DesmonstracaoKey_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Demonstração Key " + ControleDemonstracaoKey;
            tb.Text = "Demonstração Key " + ControleDemonstracaoKey;
            tb.ImageIndex = 0;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;

            Frm_HelloWorld_UC u = new Frm_HelloWorld_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Hello World " + ControleHelloWorld;
            tb.Text = "Hello World " + ControleHelloWorld;
            tb.ImageIndex = 1;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            Frm_Mascara_UC u = new Frm_Mascara_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Máscara " + ControleMascara;
            tb.Text = "Máscara " + ControleMascara;
            tb.ImageIndex = 2;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCpf += 1;

            Frm_ValidaCpf_UC u = new Frm_ValidaCpf_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida CPF " + ControleValidaCpf;
            tb.Text = "Valida CPF " + ControleValidaCpf;
            tb.ImageIndex = 3;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCpf2 += 1;

            Frm_ValidaCpf2_UC u = new Frm_ValidaCpf2_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida CPF 2 " + ControleValidaCpf2;
            tb.Text = "Valida CPF 2 " + ControleValidaCpf2;
            tb.ImageIndex = 4;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;

            Frm_ValidaSenha_UC u = new Frm_ValidaSenha_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Valida Senha " + ControleValidaSenha;
            tb.Text = "Valida Senha " + ControleValidaSenha;
            tb.ImageIndex = 5;
            tb.Controls.Add(u);
            tbc_Aplicacoes.TabPages.Add(tb);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(tbc_Aplicacoes.SelectedTab == null))
            {
               ApagaAba(tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*instanciação do formulario do tipo OpenFileDialog*/
            OpenFileDialog db = new OpenFileDialog(); 

            /*Inicialização de alguns parametros do formulario*/
            db.InitialDirectory = "D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            db.Filter = "PNG|*.PNG";
            db.Title = "Escolha a imagem";

            /*Abro o formulario*/
            if (db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = db.FileName;

                ControleArquivoImagem += 1;

                /*Passando parâmetros*/
                Frm_ArquivoImagem_UC u = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                u.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();
                tb.Name = "Abrir Imagem " + ControleArquivoImagem;
                tb.Text = "Abrir Imagem " + ControleArquivoImagem;
                tb.ImageIndex = 6;
                tb.Controls.Add(u);
                tbc_Aplicacoes.TabPages.Add(tb);
            }
         }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string senha = f.senha;
                string login = f.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao db = new Frm_Questao("question_mark", "Você deseja desconectar?");
            db.ShowDialog();

            if (db.DialogResult == DialogResult.Yes)
            {
                //tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.SelectedTab);

                for(int i = tbc_Aplicacoes.TabPages.Count -1; i >=  0; i+=-1)
                {
                    ApagaAba(tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                cadastrosToolStripMenuItem.Enabled = false;
            }
        }

        private void tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                 /* Cria a variavel menu */
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar todas as esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar todas as direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");


                /* adiciona os itens passando a função ToolStripMenuItem */
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);

                /*desenha o item do menu*/
                ContextMenu.Show(this, new Point(e.X, e.Y));

                /*Adiciona o evento click no item de menu*/
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);
            }
        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(tbc_Aplicacoes.SelectedIndex);

            }
        }

        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(tbc_Aplicacoes.SelectedTab == null))
            {
               ApagaDireita(tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(tbc_Aplicacoes.SelectedIndex);
            }
        }

        /* função adicionar item ao menu */
        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            return vToolTip;
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = tbc_Aplicacoes.TabCount - 1; i > ItemSelecionado; i += -1)
            {
                ApagaAba(tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i += -1)
            {
                ApagaAba(tbc_Aplicacoes.TabPages[i]);
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;

                Frm_CadastroCliente_UC u = new Frm_CadastroCliente_UC();
                u.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();
                tb.Name = "Cadastro de Clientes";
                tb.Text = "Cadastro de Clientes";
                tb.ImageIndex = 7;
                tb.Controls.Add(u);
                tbc_Aplicacoes.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não posso abrir o cadastro de clientes por que já está aberto", "Banco ByteBank",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        void ApagaAba(TabPage tb)
        {
            if (tb.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }

            tbc_Aplicacoes.TabPages.Remove(tb);
        }

        private void agenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Agencia FForm = new Frm_Agencia();
            FForm.ShowDialog();
        }
    }
}
