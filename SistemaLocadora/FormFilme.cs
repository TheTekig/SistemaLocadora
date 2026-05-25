using Npgsql;
using System.Data;


namespace SistemaLocadora
{
    public partial class FormFilme : Form
    {
        FilmeDAO dao = new FilmeDAO();
        public FormFilme()
        {
            InitializeComponent();
        }

        private void FormFilme_Load(object sender, EventArgs e)
        {
            CarregarFilmes();
            CarregarCores();
            CarregarGeneros();
        }

        private void CarregarFilmes()
        {
            dgvFilmes.DataSource = dao.Listar();

        }

        private void CarregarCores()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "SELECT cod_cor, nom_cor FROM cor";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);

            cboCor.DataSource = tabela;
            cboCor.DisplayMember = "nom_cor";
            cboCor.ValueMember = "cod_cor";
        }

        private void CarregarGeneros()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "SELECT cod_genero, nom_genero FROM genero";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);

            cboGenero.DataSource = tabela;
            cboGenero.DisplayMember = "nom_genero";
            cboGenero.ValueMember = "cod_genero";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                dao.Incluir(txtNome.Text, cboCor.SelectedValue.ToString(), (int)cboGenero.SelectedValue);

                MessageBox.Show("Filme incluído com sucesso!");
                CarregarFilmes();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir filme: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFilmes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um filme para alterar.");
                    return;
                }

                int cod = (int)dgvFilmes.SelectedRows[0].Cells["cod_filme"].Value;

                dao.Alterar(cod, txtNome.Text, cboCor.SelectedValue.ToString(), (int)cboGenero.SelectedValue);
                MessageBox.Show("Filme alterado com sucesso!");
                CarregarFilmes();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar filme: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFilmes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um filme para excluir.");
                    return;
                }

                int cod = (int)dgvFilmes.SelectedRows[0].Cells["cod_filme"].Value;
                var confirma = MessageBox.Show("Confirma exclusão do filme?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirma == DialogResult.Yes)
                {
                    dao.Excluir(cod);
                    MessageBox.Show("Filme excluído com sucesso!");
                    CarregarFilmes();
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir filme: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNome.Text = dgvFilmes.Rows[e.RowIndex].Cells["nom_filme"].Value.ToString();
                cboCor.SelectedValue = dgvFilmes.Rows[e.RowIndex].Cells["nom_cor"].Value.ToString();
                cboGenero.Text = dgvFilmes.Rows[e.RowIndex].Cells["nom_genero"].Value.ToString();
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            cboCor.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
