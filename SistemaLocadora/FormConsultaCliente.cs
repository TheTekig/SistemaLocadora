using System.Data;
using Npgsql;

namespace SistemaLocadora
{
    public partial class FormConsultaCliente : Form
    {
        private int _codClienteSelecionado = 0;

        public FormConsultaCliente()
        {
            InitializeComponent();
        }
        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {

        }
        private void lstCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem == null) return;
            
            var row = (DataRowView)lstClientes.SelectedItem;

            _codClienteSelecionado = (int)row["cod_cliente"];
            txtBuscaCliente.Text = row["nom_cliente"].ToString();
            lstClientes.Visible = false;
            CarregarHistorico();
        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscaCliente.Text.Length < 3)
            {
                lstClientes.Visible = false;
                return;
            }

            using var conn = ConexaoDB.ObterConexao();  
            conn.Open();

            string sql = @"SELECT cod_cliente, nom_cliente 
                           FROM cliente 
                           WHERE nom_cliente ILIKE @busca 
                           ORDER BY nom_cliente 
                           LIMIT 10"; 

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("busca", $"%{txtBuscaCliente.Text}%");

            using var reader = cmd.ExecuteReader();
            var tabela = new DataTable();
            tabela.Load(reader);

            lstClientes.DataSource = tabela;
            lstClientes.DisplayMember = "nom_cliente";
            lstClientes.ValueMember = "cod_cliente";
            lstClientes.Visible = tabela.Rows.Count > 0;
        }

        private void CarregarHistorico()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();
            string sql = @"SELECT 
                           fi.nom_filme AS Filme,
                           l.dat_locacao AS DATA,
                           l.val_locacao AS Valor,
                          CASE
                            WHEN f.sit_fita = 1 THEN 'Disponível'
                            ELSE 'Locada'
                          END AS Situacao
                          FROM locacao l
                          INNER JOIN fita f
                            ON f.cod_fita = l.cod_fita
                          INNER JOIN filme fi
                            ON fi.cod_filme = f.cod_filme
                          WHERE l.cod_cliente = @cod
                          ORDER BY l.dat_locacao DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("cod", _codClienteSelecionado);
            using var reader = cmd.ExecuteReader();
            var tabela = new DataTable();
            tabela.Load(reader);
            dgvHistorico.DataSource = tabela;
            lblNome.Text = "Cliente: " + txtBuscaCliente.Text;
            lblQtd.Text = "Total de locações: " + tabela.Rows.Count;
            decimal total = 0;
            foreach (DataRow row in tabela.Rows)
            {
                total += Convert.ToDecimal(row["Valor"]);
            }
            lblTotal.Text = "Valor total gasto: R$ " + total.ToString("F2");
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
