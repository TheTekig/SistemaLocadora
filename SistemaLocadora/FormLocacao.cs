using Npgsql;
using System.Data;
using System.Linq.Expressions;


namespace SistemaLocadora
{
    public partial class FormLocacao : Form
    {
        LocacaoDAO dao = new LocacaoDAO();
        private int _codClienteSelecionado = 0;
        public FormLocacao()
        {
            InitializeComponent();
        }

        private void FormLocacao_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarClientes();
                CarregarFitas();
                CarregarLocacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarLocacoes()
        {
            dgvLocacoes.DataSource = dao.Listar();
        }

        private void CarregarClientes()
        {

        }

        private void CarregarFitas()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = @"SELECT f.cod_fita, fi.nom_filme
                           FROM fita f
                           INNER JOIN filme fi ON fi.cod_filme = f.cod_filme
                           WHERE f.sit_fita = 1
                           ORDER BY fi.nom_filme";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);

            cboFita.DataSource = tabela;
            cboFita.DisplayMember = "nom_filme";
            cboFita.ValueMember = "cod_fita";
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLocar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_codClienteSelecionado == 0 || cboFita.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um cliente e uma fita para realizar a locação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    MessageBox.Show("Informe o valor da locação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dao.Realizar(_codClienteSelecionado, (int)cboFita.SelectedValue, decimal.Parse(txtValor.Text));
                MessageBox.Show("Locação realizada com sucesso!");
                CarregarLocacoes();
                CarregarFitas();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar locação: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvLocacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {   


            if (txtBuscaCliente.Text.Length < 2)
            {
                lstClientes.Visible = false;
                return;
            }
 
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "SELECT cod_cliente, nom_cliente FROM cliente WHERE nom_cliente ILIKE @busca ORDER BY nom_cliente LIMIT 10";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@busca", "%" + txtBuscaCliente.Text + "%");
            using var reader = cmd.ExecuteReader();
            var tabela = new DataTable();
            tabela.Load(reader);

            lstClientes.DataSource = tabela;
            lstClientes.DisplayMember = "nom_cliente";
            lstClientes.ValueMember = "cod_cliente";
            lstClientes.Visible = tabela.Rows.Count > 0;
        }
        private void lstClientes_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem == null) return;

            var row = (DataRowView)lstClientes.SelectedItem;
            _codClienteSelecionado = (int)row["cod_cliente"];
            txtBuscaCliente.Text = row["nom_cliente"].ToString();
            lstClientes.Visible = false;
        }

        private void Limpar()
        {
            txtBuscaCliente.Text = "";
            lstClientes.Visible = false;
            _codClienteSelecionado = 0;
            cboFita.SelectedIndex = 0;
            txtValor.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
