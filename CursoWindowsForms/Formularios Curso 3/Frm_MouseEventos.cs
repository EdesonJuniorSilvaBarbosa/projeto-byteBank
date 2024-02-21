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
    public partial class Frm_MouseEventos : Form
    {
        public Frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void btn_Mouse_MouseEnter(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Enter";
        }

        private void btn_Mouse_MouseLeave(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Leaver";
        }

        private void btn_Mouse_MouseHover(object sender, EventArgs e)
        {
            btn_Mouse.Text = "Mouse Houver";
        }

        private void btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Mouse.Text = "Mouse Down";
        }

        private void btn_Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Mouse.Text = "Mouse UP";
        }
    }
}
