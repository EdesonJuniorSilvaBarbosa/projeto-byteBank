using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // inicializa os acessos as bibliotecas externas
using System.Data; 

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class LocalDBClass
    {
        public string stringConn; // cria a propriedade da string de conexao
        public SqlConnection connDB; // cria a string de conexao 

        // Construtor da classe
        public LocalDBClass()
        {
            try
            {
                //stringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Users\\edesonjsb\\FORMACAO C SHARP\\7 - Pojeto Curso\\CursoWindowsForms\\CursoWindowsFormsBiblioteca\\DataBases\\Fichario.mdf;Integrated Security=True";   //passa o string de conexao
                connDB = new SqlConnection(stringConn);      //faz a conexao 
                connDB.Open();        //abre a conexao

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        //Método para retornar dados ou seja quando fazer uma consulta ao banco de dados
        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return dt;
        }

        // Método para retornar uma mensagem
        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        // Método para fechar a conexao
        public void Close()
        {
            connDB.Close();
        }
    }
}
