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
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;

                //    MessageBox.Show("Cliquei com o botão direito do mouse. A posição relativa foi (" + PosicaoX.ToString() + "," + PosicaoY.ToString() + ")");

                /* Cria a variavel menu */
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");

                /* adiciona os itens passando a função ToolStripMenuItem */
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                
                /*desenha o item do menu*/
                ContextMenu.Show(this, new Point(e.X, e.Y));

                /*Adiciona o evento click no item de menu*/
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
            }

           void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção 002");
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
        }
    }
}
