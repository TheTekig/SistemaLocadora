namespace SistemaLocadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            new FormFilme().ShowDialog();
        }

        private void btnFitas_Click(object sender, EventArgs e)
        {
            new FormFita().ShowDialog();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            new FormLocacao().ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FormConsultaCliente().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
