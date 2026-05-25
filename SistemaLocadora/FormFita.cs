using System.Data;
using Npgsql;

namespace SistemaLocadora
{
    public partial class FormFita : Form
    {
        FitaDAO dao = new FitaDAO();
        public FormFita()
        {
            InitializeComponent();
        }

        private void FormFita_Load(object sender, EventArgs e)
        {
            CarregarFilmes();
            CarregarFitas();
            CarregarSituacoes();
        }

        private void CarregarFitas()
        {
            dgvFitas.DataSource = dao.Listar();
        }

        private void CarregarFilmes()
        {
            using var conn = ConexaoDB.ObterConexao();
            conn.Open();

            string sql = "SELECT cod_filme, nom_filme FROM filme ORDER BY nom_filme";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var tabela = new DataTable();
            tabela.Load(reader);

            cboFilme.DataSource = tabela;
            cboFilme.DisplayMember = "nom_filme";
            cboFilme.ValueMember = "cod_filme";
        }

        private void CarregarSituacoes()
        {
            cboSituacao.Items.Clear();
            cboSituacao.Items.Add("1 - Disponível");
            cboSituacao.Items.Add("2 - Locada");
            cboSituacao.SelectedIndex = 0;
        }

        private short ObterSituacao()
        {
            return (short)(cboSituacao.SelectedIndex + 1);
        }

        private void cboFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpAquisicao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                dao.Incluir((int)cboFilme.SelectedValue, ObterSituacao(), dtpAquisicao.Value.Date);
                MessageBox.Show("Fita incluída com sucesso!");
                CarregarFitas();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir fita: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFitas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione uma fita para alterar.");
                    return;
                }

                int cod = (int)dgvFitas.SelectedRows[0].Cells["cod_fita"].Value;

                dao.AlterarSituacao(cod, ObterSituacao());
                MessageBox.Show("Fita alterada com sucesso!");
                CarregarFitas();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar fita: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvFitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboFilme.Text = dgvFitas.Rows[e.RowIndex].Cells["nom_filme"].Value.ToString();
                var sit = dgvFitas.Rows[e.RowIndex].Cells["sit_fita"].Value.ToString();
                cboSituacao.SelectedIndex = sit == "1" ? 0 : 1;
            }
        }

        private void Limpar()
        {
            cboFilme.SelectedIndex = 0;
            cboSituacao.SelectedIndex = 0;
            dtpAquisicao.Value = DateTime.Today;
        }
    }
}
