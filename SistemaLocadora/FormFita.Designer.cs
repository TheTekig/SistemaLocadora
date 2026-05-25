namespace SistemaLocadora
{
    partial class FormFita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboFilme = new ComboBox();
            label2 = new Label();
            cboSituacao = new ComboBox();
            dtpAquisicao = new DateTimePicker();
            label3 = new Label();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnLimpar = new Button();
            dgvFitas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Filme:";
            // 
            // cboFilme
            // 
            cboFilme.FormattingEnabled = true;
            cboFilme.Location = new Point(69, 38);
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(121, 23);
            cboFilme.TabIndex = 1;
            cboFilme.SelectedIndexChanged += cboFilme_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 43);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Situação:";
            // 
            // cboSituacao
            // 
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Location = new Point(268, 38);
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(68, 23);
            cboSituacao.TabIndex = 3;
            cboSituacao.SelectedIndexChanged += cboSituacao_SelectedIndexChanged;
            // 
            // dtpAquisicao
            // 
            dtpAquisicao.Location = new Point(447, 38);
            dtpAquisicao.Name = "dtpAquisicao";
            dtpAquisicao.Size = new Size(200, 23);
            dtpAquisicao.TabIndex = 4;
            dtpAquisicao.ValueChanged += dtpAquisicao_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 43);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Data Aquisição:";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(197, 82);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 6;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(308, 82);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(101, 23);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar Situação";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(441, 82);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvFitas
            // 
            dgvFitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFitas.Location = new Point(95, 135);
            dgvFitas.Name = "dgvFitas";
            dgvFitas.Size = new Size(511, 292);
            dgvFitas.TabIndex = 9;
            dgvFitas.CellContentClick += dgvFitas_CellContentClick;
            // 
            // FormFita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(dgvFitas);
            Controls.Add(btnLimpar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(label3);
            Controls.Add(dtpAquisicao);
            Controls.Add(cboSituacao);
            Controls.Add(label2);
            Controls.Add(cboFilme);
            Controls.Add(label1);
            Name = "FormFita";
            Text = "Fitas";
            Load += FormFita_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboFilme;
        private Label label2;
        private ComboBox cboSituacao;
        private DateTimePicker dtpAquisicao;
        private Label label3;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnLimpar;
        private DataGridView dgvFitas;
    }
}