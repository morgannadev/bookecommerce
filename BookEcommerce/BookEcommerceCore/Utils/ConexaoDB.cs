using BookEcommerceCore.Aplicacao;
using System.Data.SqlClient;

namespace BookEcommerceCore.Utils
{
    public class ConexaoDB
    {
        protected static Resultado resultado = new Resultado();        

        protected string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BookEcommerceDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public void teste()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}
