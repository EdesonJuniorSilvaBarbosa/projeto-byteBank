using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CursoWindowsFormsBiblioteca.DataBases
{
    public class SQLServerClass
    {
        public string stringConn; // cria a propriedade da string de conexao
        public SqlConnection connDB; // cria a string de conexao 

        public SQLServerClass()
        {
            try
            {
                //stringConn = "Data Source=JUNINHO\\SQLEXPRESS;Initial Catalog=ByteBank;Integrated Security=True";   //passa o string de conexao
                stringConn = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                connDB = new SqlConnection(stringConn);      //faz a conexao 
                connDB.Open();        //abre a conexao

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

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
