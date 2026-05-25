using Npgsql;

namespace SistemaLocadora
{
    public class ConexaoDB
    {
        private static string connectionString = "Host=localhost; Database=loc004; Username=postgres; Password=Didi0731;";
        
        public static NpgsqlConnection ObterConexao()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
