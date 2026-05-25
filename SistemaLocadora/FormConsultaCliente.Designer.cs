namespace SistemaLocadora
{
    partial class FormConsultaCliente
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
            txtBuscaCliente = new TextBox();
            lstClientes = new ListBox();
            dgvHistorico = new DataGridView();
            lblNome = new Label();
            lblQtd = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar Cliente:";
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(135, 27);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(147, 23);
            txtBuscaCliente.TabIndex = 1;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(135, 56);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(147, 94);
            lstClientes.TabIndex = 2;
            lstClientes.Click += lstCliente_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(322, 84);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(453, 337);
            dgvHistorico.TabIndex = 3;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(331, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(494, 35);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(72, 15);
            lblQtd.TabIndex = 5;
            lblQtd.Text = "Quantidade:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(667, 35);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // FormConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblQtd);
            Controls.Add(lblNome);
            Controls.Add(dgvHistorico);
            Controls.Add(lstClientes);
            Controls.Add(txtBuscaCliente);
            Controls.Add(label1);
            Name = "FormConsultaCliente";
            Text = "FormConsultaCliente";
            Load += FormConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscaCliente;
        private ListBox lstClientes;
        private DataGridView dgvHistorico;
        private Label lblNome;
        private Label lblQtd;
        private Label lblTotal;
    }
}