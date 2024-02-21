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
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;

            InitializeComponent();

            this.Text = "BUSCA";
            tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            tls_Principal.Items[1].ToolTipText = "Fechar a seleção";
            PreencherLista();
            lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            lst_Busca.Items.Clear();

            for (int i = 0; i <= _ListaBusca.Count -1; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];

                lst_Busca.Items.Add(X);

            }
        }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox ItemSelecionado = (ItemBox)lst_Busca.Items[lst_Busca.SelectedIndex];
            idSelect = ItemSelecionado.id;
            //idSelect = _ListaBusca[lst_Busca.SelectedIndex][0];
            this.Close();
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
