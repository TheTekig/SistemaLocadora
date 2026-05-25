namespace SistemaLocadora
{
    partial class FormLocacao
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
            label2 = new Label();
            cboFita = new ComboBox();
            label3 = new Label();
            txtValor = new TextBox();
            btnLocar = new Button();
            btnLimpar = new Button();
            dgvLocacoes = new DataGridView();
            txtBuscaCliente = new TextBox();
            lstClientes = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLocacoes).BeginInit();
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
            label1.Location = new Point(46, 205);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 0;
            label1.Text = "👤Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 176, 0);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(47, 271);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 2;
            label2.Text = "📼 Fita:";
            // 
            // cboFita
            // 
            cboFita.FormattingEnabled = true;
            cboFita.Location = new Point(147, 271);
            cboFita.Margin = new Padding(3, 4, 3, 4);
            cboFita.Name = "cboFita";
            cboFita.Size = new Size(138, 28);
            cboFita.TabIndex = 3;
            cboFita.SelectedIndexChanged += cboFita_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 176, 0);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(47, 338);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 4;
            label3.Text = "💵 Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(147, 334);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(114, 27);
            txtValor.TabIndex = 5;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // btnLocar
            // 
            btnLocar.BackColor = Color.FromArgb(255, 176, 0);
            btnLocar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnLocar.FlatAppearance.BorderSize = 0;
            btnLocar.FlatStyle = FlatStyle.Flat;
            btnLocar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocar.ForeColor = SystemColors.ControlLightLight;
            btnLocar.Location = new Point(53, 418);
            btnLocar.Margin = new Padding(3, 4, 3, 4);
            btnLocar.Name = "btnLocar";
            btnLocar.Size = new Size(118, 31);
            btnLocar.TabIndex = 6;
            btnLocar.Text = "Realizar Locação";
            btnLocar.UseVisualStyleBackColor = false;
            btnLocar.Click += btnLocar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 176, 0);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ControlLightLight;
            btnLimpar.Location = new Point(177, 418);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 31);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvLocacoes
            // 
            dgvLocacoes.AllowUserToAddRows = false;
            dgvLocacoes.BackgroundColor = Color.Black;
            dgvLocacoes.BorderStyle = BorderStyle.None;
            dgvLocacoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLocacoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLocacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLocacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLocacoes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLocacoes.EnableHeadersVisualStyles = false;
            dgvLocacoes.Location = new Point(386, 13);
            dgvLocacoes.Margin = new Padding(3, 4, 3, 4);
            dgvLocacoes.Name = "dgvLocacoes";
            dgvLocacoes.ReadOnly = true;
            dgvLocacoes.RowHeadersVisible = false;
            dgvLocacoes.RowHeadersWidth = 51;
            dgvLocacoes.Size = new Size(524, 574);
            dgvLocacoes.TabIndex = 8;
            dgvLocacoes.CellContentClick += dgvLocacoes_CellContentClick;
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(147, 205);
            txtBuscaCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(114, 27);
            txtBuscaCliente.TabIndex = 9;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(147, 232);
            lstClientes.Margin = new Padding(3, 4, 3, 4);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(114, 144);
            lstClientes.TabIndex = 10;
            lstClientes.Click += lstClientes_Click;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 176, 0);
            pictureBox2.Location = new Point(-11, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 611);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Location = new Point(216, -9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 611);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 176, 0);
            label4.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(73, 36);
            label4.Name = "label4";
            label4.Size = new Size(158, 35);
            label4.TabIndex = 13;
            label4.Text = "LOCACAO DE";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 176, 0);
            label5.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(53, 56);
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
            label6.Location = new Point(53, 463);
            label6.Name = "label6";
            label6.Size = new Size(212, 146);
            label6.TabIndex = 15;
            label6.Text = "🍿";
            // 
            // FormLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lstClientes);
            Controls.Add(txtBuscaCliente);
            Controls.Add(dgvLocacoes);
            Controls.Add(btnLimpar);
            Controls.Add(btnLocar);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(cboFita);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLocacao";
            Text = "FormLocacao";
            Load += FormLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLocacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboFita;
        private Label label3;
        private TextBox txtValor;
        private Button btnLocar;
        private Button btnLimpar;
        private DataGridView dgvLocacoes;
        private TextBox txtBuscaCliente;
        private ListBox lstClientes;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}