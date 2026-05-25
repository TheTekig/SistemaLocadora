using System.Data;
using System.Net.Sockets;
using System.Security.Cryptography;
using Npgsql;

namespace SistemaLocadora
{
    public class LocacaoDAO
    {
        public DataTable Listar()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = @"SELECT l.cod_locacao, c.nom_cliente, fi.nom_filme, l.dat_locacao, l.dat_prevista_devolucao, l.val_locacao 
                           FROM locacao l
                           INNER JOIN cliente c ON c.cod_cliente = l.cod_cliente
                           INNER JOIN fita f ON f.cod_fita = l.cod_fita
                           INNER JOIN filme fi ON fi.cod_filme = f.cod_filme";

            var cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);
            return tabela;
        }

        public void Realizar(int codCliente, int codFita, decimal valLocacao)
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();
            
            string sqlVerifica = "SELECT sit_fita FROM fita WHERE cod_fita = @cod";
            using var cmdVerifica = new NpgsqlCommand(sqlVerifica, conn);

            cmdVerifica.Parameters.AddWithValue("@cod", codFita);

            var sit = cmdVerifica.ExecuteScalar();

            if (sit == null || (short)sit != 1)
            {
                throw new Exception("Fita indisponível para locação.");
            }

            string sql = @"INSERT INTO locacao (cod_cliente, cod_fita, dat_locacao, dat_prevista_devolucao, val_locacao)
                           VALUES (@cliente, @fita, NOW(), NOW() + INTERVAL '3 days', @val)";
            
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cliente", codCliente);
            cmd.Parameters.AddWithValue("@fita", codFita);
            cmd.Parameters.AddWithValue("@val", valLocacao);

            cmd.ExecuteNonQuery();

            string sqlAtualiza = "UPDATE fita SET sit_fita = 2 WHERE cod_fita = @cod";
            using var cmdAtualiza = new NpgsqlCommand(sqlAtualiza, conn);
            cmdAtualiza.Parameters.AddWithValue("@cod", codFita);
            cmdAtualiza.ExecuteNonQuery();
        }
    }
}
