using System.Data;
using System.Runtime.InteropServices.Marshalling;
using Npgsql;

namespace SistemaLocadora
{
    public class FitaDAO
    {
        public DataTable Listar()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();
            
            string sql = @"SELECT f.cod_fita, fi.nom_filme, f.sit_fita, f.dat_aquisicao
                           FROM fita f
                           INNER JOIN filme fi ON fi.cod_filme = f.cod_filme";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);
            return tabela;
        }

        public void Incluir( int codFilme, short sitFita, DateTime datAquisicao)
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "INSERT INTO fita (cod_filme, sit_fita, dat_aquisicao) VALUES (@filme, @sit, @data)";
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@filme", codFilme);
            cmd.Parameters.AddWithValue("@sit", sitFita);
            cmd.Parameters.AddWithValue("@data", datAquisicao);

            cmd.ExecuteNonQuery();
        }

        public void AlterarSituacao(int codFita, short novaSit)
        {
            using var conn =  ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "UPDATE fita SET sit_fita = @sit WHERE cod_fita = @cod";

            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@sit", novaSit);
            cmd.Parameters.AddWithValue("@cod", codFita);

            cmd.ExecuteNonQuery();
        }
    }
}
