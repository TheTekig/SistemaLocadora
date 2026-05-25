namespace SistemaLocadora
{
    partial class FormFilme
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cboCor = new ComboBox();
            cboGenero = new ComboBox();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvFilmes = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 176, 0);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 202);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 0;
            label1.Text = "🎬Filme:";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 201);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 176, 0);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(24, 242);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 2;
            label2.Text = "🎨 Cor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 176, 0);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(18, 278);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 3;
            label3.Text = "🗃️ Gênero:";
            label3.Click += label3_Click;
            // 
            // cboCor
            // 
            cboCor.FormattingEnabled = true;
            cboCor.Location = new Point(125, 241);
            cboCor.Margin = new Padding(3, 4, 3, 4);
            cboCor.Name = "cboCor";
            cboCor.Size = new Size(82, 28);
            cboCor.TabIndex = 4;
            cboCor.SelectedIndexChanged += cboCor_SelectedIndexChanged;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(125, 277);
            cboGenero.Margin = new Padding(3, 4, 3, 4);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(138, 28);
            cboGenero.TabIndex = 5;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(255, 176, 0);
            btnIncluir.FlatAppearance.BorderSize = 0;
            btnIncluir.FlatStyle = FlatStyle.Flat;
            btnIncluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluir.ForeColor = SystemColors.ControlLightLight;
            btnIncluir.Location = new Point(34, 344);
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
            btnAlterar.Location = new Point(139, 344);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(86, 31);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 176, 0);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(34, 395);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 176, 0);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ControlLightLight;
            btnLimpar.Location = new Point(139, 395);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 31);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.BackgroundColor = SystemColors.ControlText;
            dgvFilmes.BorderStyle = BorderStyle.None;
            dgvFilmes.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvFilmes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFilmes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvFilmes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvFilmes.EnableHeadersVisualStyles = false;
            dgvFilmes.Location = new Point(296, 13);
            dgvFilmes.Margin = new Padding(3, 4, 3, 4);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.RowHeadersVisible = false;
            dgvFilmes.RowHeadersWidth = 51;
            dgvFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmes.Size = new Size(474, 589);
            dgvFilmes.TabIndex = 10;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 176, 0);
            pictureBox2.Location = new Point(-6, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 642);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Location = new Point(11, -9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 642);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 176, 0);
            label4.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(59, 31);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 13;
            label4.Text = "PESQUISA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 176, 0);
            label5.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(45, 59);
            label5.Name = "label5";
            label5.Size = new Size(201, 75);
            label5.TabIndex = 14;
            label5.Text = "FILMES";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 176, 0);
            label6.Font = new Font("Segoe UI", 65F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(34, 473);
            label6.Name = "label6";
            label6.Size = new Size(212, 146);
            label6.TabIndex = 15;
            label6.Text = "🎥";
            // 
            // FormFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(782, 615);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dgvFilmes);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(cboGenero);
            Controls.Add(cboCor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFilme";
            Text = "Filmes";
            Load += FormFilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private ComboBox cboCor;
        private ComboBox cboGenero;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvFilmes;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}