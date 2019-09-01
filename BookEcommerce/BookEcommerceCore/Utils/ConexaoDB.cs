using BookEcommerceCore.Aplicacao;
using System.Data.SqlClient;
using System.Data.Common;

namespace BookEcommerceCore.Utils
{
    public class ConexaoDB
    {
        protected static Resultado resultado = new Resultado();
        protected static DbConnection dbConnection { get; set; }
        protected DbTransaction dbTransaction { get; set; }

        public static DbConnection GetDbConnection()
        {
            dbConnection = new SqlConnection();

            try
            {
                dbConnection.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=BookEcommerceDB;Trusted_Connection=True;MultipleActiveResultSets=true";
                return dbConnection;
            }
            catch (DbException ex)
            {
                resultado.Mensagem = ex.Message;
                throw;
            }
        }

        public static DbCommand GetDbCommand(DbConnection dbConnection)
        {
            return dbConnection.CreateCommand();
        }
    }
}
