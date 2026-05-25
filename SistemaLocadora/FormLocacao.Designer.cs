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
            ((System.ComponentModel.ISupportInitialize)dgvLocacoes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Fita:";
            // 
            // cboFita
            // 
            cboFita.FormattingEnabled = true;
            cboFita.Location = new Point(47, 218);
            cboFita.Name = "cboFita";
            cboFita.Size = new Size(121, 23);
            cboFita.TabIndex = 3;
            cboFita.SelectedIndexChanged += cboFita_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 292);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(54, 289);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // btnLocar
            // 
            btnLocar.Location = new Point(17, 350);
            btnLocar.Name = "btnLocar";
            btnLocar.Size = new Size(103, 23);
            btnLocar.TabIndex = 6;
            btnLocar.Text = "Realizar Locação";
            btnLocar.UseVisualStyleBackColor = true;
            btnLocar.Click += btnLocar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(145, 350);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvLocacoes
            // 
            dgvLocacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocacoes.Location = new Point(254, 55);
            dgvLocacoes.Name = "dgvLocacoes";
            dgvLocacoes.Size = new Size(519, 365);
            dgvLocacoes.TabIndex = 8;
            dgvLocacoes.CellContentClick += dgvLocacoes_CellContentClick;
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(62, 55);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(100, 23);
            txtBuscaCliente.TabIndex = 9;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(62, 84);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(100, 109);
            lstClientes.TabIndex = 10;
            lstClientes.Click += lstClientes_Click;
            // 
            // FormLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormLocacao";
            Text = "FormLocacao";
            Load += FormLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLocacoes).EndInit();
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
    }
}