using Npgsql;
using System.Data;
namespace SistemaLocadora
{
    public class FilmeDAO
    {
        public DataTable Listar()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = @"SELECT f.cod_filme, f.nom_filme, c.nom_cor, g.nom_genero
                           FROM filme f
                           INNER JOIN cor c ON c.cod_cor = f.cod_cor
                           INNER JOIN genero g ON g.cod_genero = f.cod_genero";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            
            var tabela = new DataTable();
            tabela.Load(reader);
            return tabela;
        }

        public void Incluir( string nomFilme, string codCor, int codGenero)
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "INSERT INTO filme (nom_filme, cod_cor, cod_genero) VALUES (@nom, @cor, @genero)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nom", nomFilme);
            cmd.Parameters.AddWithValue("@cor", codCor);
            cmd.Parameters.AddWithValue("@genero", codGenero);

            cmd.ExecuteNonQuery();
        }

        public void Alterar(int codFilme, string nomFilme, string codCor, int codGenero)
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = @"UPDATE filme SET nom_filme=@nom, cod_cor = @cor, cod_genero = @genero WHERE cod_filme = @cod";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nom", nomFilme);
            cmd.Parameters.AddWithValue("@cor", codCor);
            cmd.Parameters.AddWithValue("@genero", codGenero);
            cmd.Parameters.AddWithValue("@cod", codFilme);

            cmd.ExecuteNonQuery();
        }

        public void Excluir(int codFilme)
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "DELETE FROM filme WHERE cod_filme = @cod";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", codFilme);

            cmd.ExecuteNonQuery();
        }
    }
}
