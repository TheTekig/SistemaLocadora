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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 176, 0);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(18, 148);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "🎬 Filme:";
            label1.Click += label1_Click;
            // 
            // cboFilme
            // 
            cboFilme.FormattingEnabled = true;
            cboFilme.Location = new Point(112, 147);
            cboFilme.Margin = new Padding(3, 4, 3, 4);
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(138, 28);
            cboFilme.TabIndex = 1;
            cboFilme.SelectedIndexChanged += cboFilme_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 176, 0);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(18, 203);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 2;
            label2.Text = "🔺 Situação:";
            // 
            // cboSituacao
            // 
            cboSituacao.FormattingEnabled = true;
            cboSituacao.Location = new Point(136, 202);
            cboSituacao.Margin = new Padding(3, 4, 3, 4);
            cboSituacao.Name = "cboSituacao";
            cboSituacao.Size = new Size(77, 28);
            cboSituacao.TabIndex = 3;
            cboSituacao.SelectedIndexChanged += cboSituacao_SelectedIndexChanged;
            // 
            // dtpAquisicao
            // 
            dtpAquisicao.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpAquisicao.Location = new Point(25, 305);
            dtpAquisicao.Margin = new Padding(3, 4, 3, 4);
            dtpAquisicao.Name = "dtpAquisicao";
            dtpAquisicao.Size = new Size(228, 27);
            dtpAquisicao.TabIndex = 4;
            dtpAquisicao.ValueChanged += dtpAquisicao_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 176, 0);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(60, 278);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 5;
            label3.Text = "🗓️ Data Aquisição:";
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(255, 176, 0);
            btnIncluir.FlatAppearance.BorderSize = 0;
            btnIncluir.FlatStyle = FlatStyle.Flat;
            btnIncluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluir.ForeColor = SystemColors.ControlLightLight;
            btnIncluir.Location = new Point(47, 357);
            btnIncluir.Margin = new Padding(3, 4, 3, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(86, 31);
            btnIncluir.TabIndex = 6;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(255, 176, 0);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.ControlLightLight;
            btnAlterar.Location = new Point(86, 396);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(115, 31);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar Situação";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 176, 0);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ControlLightLight;
            btnLimpar.Location = new Point(151, 357);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 31);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvFitas
            // 
            dgvFitas.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvFitas.BorderStyle = BorderStyle.None;
            dgvFitas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFitas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFitas.EnableHeadersVisualStyles = false;
            dgvFitas.Location = new Point(303, 13);
            dgvFitas.Margin = new Padding(3, 4, 3, 4);
            dgvFitas.Name = "dgvFitas";
            dgvFitas.RowHeadersVisible = false;
            dgvFitas.RowHeadersWidth = 51;
            dgvFitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFitas.Size = new Size(555, 554);
            dgvFitas.TabIndex = 9;
            dgvFitas.CellContentClick += dgvFitas_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 176, 0);
            pictureBox2.Location = new Point(-4, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 640);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Location = new Point(13, -8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 640);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 176, 0);
            label4.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(60, 9);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 15;
            label4.Text = "PESQUISA";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 176, 0);
            label5.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(46, 37);
            label5.Name = "label5";
            label5.Size = new Size(165, 75);
            label5.TabIndex = 16;
            label5.Text = "FITAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 176, 0);
            label6.Font = new Font("Segoe UI", 65F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(25, 423);
            label6.Name = "label6";
            label6.Size = new Size(212, 146);
            label6.TabIndex = 17;
            label6.Text = "📼";
            // 
            // FormFita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(870, 580);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
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
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFita";
            Text = "Fitas";
            Load += FormFita_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}