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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            label1 = new Label();
            txtBuscaCliente = new TextBox();
            lstClientes = new ListBox();
            dgvHistorico = new DataGridView();
            lblNome = new Label();
            lblQtd = new Label();
            lblTotal = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 176, 0);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 144);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Buscar Cliente:";
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(82, 171);
            txtBuscaCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(167, 27);
            txtBuscaCliente.TabIndex = 1;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // lstClientes
            // 
            lstClientes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 23;
            lstClientes.Location = new Point(82, 196);
            lstClientes.Margin = new Padding(3, 4, 3, 4);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(167, 119);
            lstClientes.TabIndex = 2;
            lstClientes.Click += lstCliente_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.Black;
            dgvHistorico.BorderStyle = BorderStyle.None;
            dgvHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.DimGray;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvHistorico.DefaultCellStyle = dataGridViewCellStyle14;
            dgvHistorico.EnableHeadersVisualStyles = false;
            dgvHistorico.Location = new Point(393, 13);
            dgvHistorico.Margin = new Padding(3, 4, 3, 4);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.RowHeadersWidth = 51;
            dgvHistorico.RowTemplate.Height = 35;
            dgvHistorico.Size = new Size(593, 455);
            dgvHistorico.TabIndex = 3;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.FromArgb(255, 176, 0);
            lblNome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(27, 234);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 23);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.BackColor = Color.FromArgb(255, 176, 0);
            lblQtd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQtd.ForeColor = SystemColors.ButtonHighlight;
            lblQtd.Location = new Point(27, 272);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(109, 23);
            lblQtd.TabIndex = 5;
            lblQtd.Text = "Quantidade:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(255, 176, 0);
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(27, 310);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 176, 0);
            pictureBox2.Location = new Point(-9, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 487);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Location = new Point(208, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 487);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 176, 0);
            label2.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(107, 13);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 9;
            label2.Text = "Locação";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 176, 0);
            label3.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(68, 32);
            label3.Name = "label3";
            label3.Size = new Size(201, 75);
            label3.TabIndex = 10;
            label3.Text = "FILMES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 176, 0);
            label4.Font = new Font("Segoe UI", 65F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(63, 350);
            label4.Name = "label4";
            label4.Size = new Size(212, 146);
            label4.TabIndex = 11;
            label4.Text = "👥";
            // 
            // FormConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(998, 481);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lstClientes);
            Controls.Add(lblTotal);
            Controls.Add(lblQtd);
            Controls.Add(lblNome);
            Controls.Add(dgvHistorico);
            Controls.Add(txtBuscaCliente);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConsultaCliente";
            Text = "FormConsultaCliente";
            Load += FormConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}