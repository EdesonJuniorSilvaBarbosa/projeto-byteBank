﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DesmonstracaoKey_UC : UserControl
    {
        public Frm_DesmonstracaoKey_UC()
        {
            InitializeComponent();
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Codigo da tecla: " + ((int)e.KeyCode) + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Msg.Text = "";
            txt_Input.Text = "";
            lbl_Upper.Text = "";
            lbl_Lower.Text = "";
            lbl_Maius.Text = "";
            lbl_Minus.Text = "";
        }
    }
}