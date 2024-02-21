using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.DataBases;


namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            grp_Codigo.Text = "Código";
            grp_DadosPessoais.Text = "Dados Pessoais";
            chk_TemPai.Text = "Pai desconhecido";
            grp_Endereco.Text = "Endereço";
            grp_Outros.Text = "Outros";
            txt_Cidade.Text = "Cidade";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            rdb_Masculino.Text = "Masculino";
            rdb_Feminino.Text = "Feminino";
            rdb_Indefinido.Text = "Indefinido";
            grp_Genero.Text = "Genero";
            btn_Busca.Text = "Buscar";


            // inicializa os estados
            cmb_Estado.Items.Clear();
            cmb_Estado.Items.Add("Acre (AC)");
            cmb_Estado.Items.Add("Alagoas(AL)");
            cmb_Estado.Items.Add("Amapá(AP)");
            cmb_Estado.Items.Add("Amazonas(AM)");
            cmb_Estado.Items.Add("Bahia(BA)");
            cmb_Estado.Items.Add("Ceará(CE)");
            cmb_Estado.Items.Add("Distrito Federal(DF)");
            cmb_Estado.Items.Add("Espírito Santo(ES)");
            cmb_Estado.Items.Add("Goiás(GO)");
            cmb_Estado.Items.Add("Maranhão(MA)");
            cmb_Estado.Items.Add("Mato Grosso(MT)");
            cmb_Estado.Items.Add("Mato Grosso do Sul(MS)");
            cmb_Estado.Items.Add("Minas Gerais(MG)");
            cmb_Estado.Items.Add("Pará(PA)");
            cmb_Estado.Items.Add("Paraíba(PB)");
            cmb_Estado.Items.Add("Paraná(PR)");
            cmb_Estado.Items.Add("Pernambuco(PE)");
            cmb_Estado.Items.Add("Piauí(PI)");
            cmb_Estado.Items.Add("Rio de Janeiro(RJ)");
            cmb_Estado.Items.Add("Rio Grande do Norte(RN)");
            cmb_Estado.Items.Add("Rio Grande do Sul(RS)");
            cmb_Estado.Items.Add("Rondônia(RO)");
            cmb_Estado.Items.Add("Roraima(RR)");
            cmb_Estado.Items.Add("Santa Catarina(SC)");
            cmb_Estado.Items.Add("São Paulo(SP)");
            cmb_Estado.Items.Add("Sergipe(SE)");
            cmb_Estado.Items.Add("Tocantins(TO)");

            tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado na base";
            tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";

            grp_DataGrid.Text = "Clientes";
            AtualizaGrid();
            

            LimparFormulario();

        }

        private void LimparFormulario()
        {
            txt_Codigo.Text = "";
            txt_Cidade.Text = "";
            Txt_Bairro.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            cmb_Estado.SelectedIndex = -1;
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = "";
            Txt_Telefone.Text = "";
            chk_TemPai.Checked = false;
            rdb_Masculino.Checked = true;

        }

        private void chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();
                //C.IncluirFicharioSQLREL();
                //C.IncluirFicharioSQL("Cliente");
                //C.IncluirFicharioDB("Cliente");
                //C.IncluirFichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                //MessageBox.Show("Ok: Identificador incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //AtualizaGrid();
                //LimparFormulario();

                #region "Salvar no diretorio fichario em formato JSON"
                string clienteJson = Cliente.SerializedClassUnit(C);

                Fichario F = new Fichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");

                if (F.status)
                {
                    F.Incluir(C.Id, clienteJson);

                    if (F.status)
                    {
                        MessageBox.Show("Ok: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                #endregion
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Codigo.Text == "")
                {
                    MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Cliente.Unit C = new Cliente.Unit();
                        C = C.BuscarFicharioSQLREL(txt_Codigo.Text);
                        //C = C.BuscarFicharioSQL(txt_Codigo.Text, "Cliente");
                        //C = C.BuscarFicharioDB(txt_Codigo.Text, "Cliente");
                        //C = C.BuscarFichario(txt_Codigo.Text, "D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                        if (C == null)
                        {
                            MessageBox.Show("Identificador nao encontrado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            EscreveFormulario(C);
                        }

                        #region "Codigo comentado"
                        //Fichario F = new Fichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                        //if (F.status)
                        //{
                        //    string clienteJson = F.Buscar(txt_Codigo.Text);
                        //    Cliente.Unit C = new Cliente.Unit();
                        //    C = Cliente.DesSerializedClassUnit(clienteJson);
                        //    EscreveFormulario(C);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        #endregion
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            // testar se o campo do codigo está em branco
            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    C.AlterarFicharioSQLREL();
                    //C.AlterarFicharioSQL("Cliente");
                    //C.AlterarFicharioDB("Cliente");
                    //C.AlterarFichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                    MessageBox.Show("Ok: Identificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid();

                    #region "Codigo comentado"

                    //string clienteJson = Cliente.SerializedClassUnit(C);

                    //Fichario F = new Fichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");

                    //if (F.status)
                    //{
                    //    F.Alterar(C.Id, clienteJson);

                    //    if (F.status)
                    //    {
                    //        MessageBox.Show("Ok: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}
                    #endregion

                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

    }

        private void ApagatoolStripButton1_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioSQLREL(txt_Codigo.Text);
                    //C = C.BuscarFicharioSQL(txt_Codigo.Text, "Cliente");
                    //C = C.BuscarFicharioDB(txt_Codigo.Text, "Cliente");
                    //C = C.BuscarFichario(txt_Codigo.Text, "D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador nao encontrado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);

                        Frm_Questao db = new Frm_Questao("question_mark", "Você quer excluir o cliente?");
                        db.ShowDialog();
                        if (db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFicharioSQLREL();
                            //C.ApagarFicharioSQL("Cliente");
                            //C.ApagarFicharioDB("Cliente");
                            //C.ApagarFichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                            MessageBox.Show("Ok: Identificador apagado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizaGrid();
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #region "Parte do codigo comentado"
                // Fichario F = new Fichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                // if (F.status)
                // {
                //     string clienteJson = F.Buscar(txt_Codigo.Text);
                //     Cliente.Unit C = new Cliente.Unit();
                //     C = Cliente.DesSerializedClassUnit(clienteJson);
                //     EscreveFormulario(C);

                //     Frm_Questao db = new Frm_Questao("question_mark", "Você quer excluir o cliente?");
                //     db.ShowDialog();
                //     if (db.DialogResult == DialogResult.Yes)
                //     {
                //         F.Apagar(txt_Codigo.Text);
                //         if (F.status)
                //         {
                //             MessageBox.Show("Ok: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //             LimparFormulario();
                //         }
                //         else
                //         {
                //             MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //         }
                //     }
                //}
                // else
                // {
                //     MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // }
                #endregion
            }
        }

        private void LimpartoolStripButton1_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

#region Função Leitura do formulário

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (chk_TemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }

            if (rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }

            C.Cpf = Txt_CPF.Text;
            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;

            if(cmb_Estado.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = cmb_Estado.Items[cmb_Estado.SelectedIndex].ToString();
            }

            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);

                if(vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }

            return C;
        }

        #endregion

        void EscreveFormulario(Cliente.Unit C)
        {
            txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;
            Txt_NomePai.Text = C.NomePai;

            if (C.NaoTemPai == true)
            {
                chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                chk_TemPai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                rdb_Masculino.Checked = true;
            }

            if (C.Genero == 1)
            {
               rdb_Feminino.Checked = true;
            }
            if (C.Genero == 2)
            {
                rdb_Indefinido.Checked = true;
            }

            Txt_CPF.Text = C.Cpf;
            Txt_CEP.Text = C.Cep;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            txt_Cidade.Text = C.Cidade;
            Txt_Bairro.Text = C.Bairro;
            Txt_Telefone.Text = C.Telefone;
            Txt_Profissao.Text  = C.Profissao;


            if (C.Estado == "")
            {
                cmb_Estado.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= cmb_Estado.Items.Count -1; i++)
                {
                    if (C.Estado == cmb_Estado.Items[i].ToString())
                    {
                        cmb_Estado.SelectedIndex = i;
                    }
                }
           }

            Txt_RendaFamiliar.Text = C.RendaFamiliar.ToString();
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            
            // declaração da variavel vCEP
            string vCep = Txt_CEP.Text;

            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        Cep.Unit cep = new Cep.Unit();
                        cep = Cep.DesSerializedClassUnit(vJson);
                        Txt_Logradouro.Text = cep.logradouro;
                        Txt_Bairro.Text = cep.bairro;
                        txt_Cidade.Text = cep.localidade;

                        cmb_Estado.SelectedIndex = -1;

                        for (int i = 0; i <= cmb_Estado.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(cmb_Estado.Items[i].ToString(),"(" + cep.uf + ")");

                            if (vPos > 0)
                            {
                                cmb_Estado.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //var ListaBusca = C.BuscarFicharioTodos("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                //var ListaBusca = C.BuscarFicharioDBTodosDB("Cliente");
                //var ListaBusca = C.BuscarFicharioDBTodosSQL("Cliente");
                var ListaBusca = C.BuscarFicharioDBTodosSQLREL();
                Frm_Busca FForm = new Frm_Busca(ListaBusca);
                FForm.ShowDialog();
                if (FForm.DialogResult == DialogResult.OK)
                {
                    var idSelect = FForm.idSelect;
                    //C = C.BuscarFichario(idSelect, "D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                    //C = C.BuscarFicharioDB(idSelect, "Cliente");
                    //C = C.BuscarFicharioSQL(idSelect, "Cliente");
                    C = C.BuscarFicharioSQLREL(idSelect);
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region "Versao anterior"
            //Fichario F = new Fichario("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
            //if (F.status)
            //{
            //    List<string> List = new List<string>();
            //    List = F.BuscarTodos();
            //    if (F.status)
            //    {
            //        List<List<string>> ListaBusca = new List<List<string>> ();
            //        for (int i = 0; i <= List.Count - 1; i++)
            //        {
            //            Cliente.Unit C = Cliente.DesSerializedClassUnit(List[i]);
            //            ListaBusca.Add(new List<string> { C.Id, C.Nome });
            //        }
            //        Frm_Busca FForm = new Frm_Busca(ListaBusca);
            //        FForm.ShowDialog();
            //        if (FForm.DialogResult == DialogResult.OK)
            //        {
            //            var idSelect = FForm.idSelect;
            //            string clienteJson = F.Buscar(idSelect);
            //            Cliente.Unit C = new Cliente.Unit();
            //            C = Cliente.DesSerializedClassUnit(clienteJson);
            //            EscreveFormulario(C);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERR " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }                 
            //}
            //else
            //{
            //    MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion
        }

        private void AtualizaGrid()
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                //var ListaBusca = C.BuscarFicharioTodos("D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\Fichario");
                //var ListaBusca = C.BuscarFicharioDBTodosDB("Cliente");
                //var ListaBusca = C.BuscarFicharioDBTodosSQL("Cliente");
                var ListaBusca = C.BuscarFicharioDBTodosSQLREL();
                dg_Clientes.Rows.Clear();

                for (int i = 0; i <= ListaBusca.Count -1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dg_Clientes);
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    dg_Clientes.Rows.Add(row);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dg_Clientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dg_Clientes.SelectedRows[0];
                string Id = row.Cells[0].Value.ToString();  // busca o id da base

                Cliente.Unit C = new Cliente.Unit();
                C = C.BuscarFicharioSQLREL(Id);
                if (C == null)
                {
                    MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EscreveFormulario(C);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
