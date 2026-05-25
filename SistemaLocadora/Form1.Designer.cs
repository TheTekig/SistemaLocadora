namespace SistemaLocadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnFilmes = new Button();
            btnFitas = new Button();
            btnLocacao = new Button();
            btnClientes = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFilmes
            // 
            btnFilmes.AccessibleName = "btnFilmes";
            btnFilmes.BackColor = Color.FromArgb(255, 176, 0);
            btnFilmes.FlatAppearance.BorderSize = 0;
            btnFilmes.FlatStyle = FlatStyle.Flat;
            btnFilmes.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilmes.ForeColor = Color.White;
            btnFilmes.Location = new Point(229, 208);
            btnFilmes.Name = "btnFilmes";
            btnFilmes.Size = new Size(121, 30);
            btnFilmes.TabIndex = 0;
            btnFilmes.Text = "🎬 Filmes";
            btnFilmes.UseVisualStyleBackColor = false;
            btnFilmes.Click += btnFilmes_Click;
            // 
            // btnFitas
            // 
            btnFitas.AccessibleName = "btnFitas";
            btnFitas.BackColor = Color.FromArgb(255, 176, 0);
            btnFitas.FlatAppearance.BorderSize = 0;
            btnFitas.FlatStyle = FlatStyle.Flat;
            btnFitas.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFitas.ForeColor = Color.White;
            btnFitas.Location = new Point(229, 235);
            btnFitas.Name = "btnFitas";
            btnFitas.Size = new Size(121, 30);
            btnFitas.TabIndex = 1;
            btnFitas.Text = "📼 Fitas";
            btnFitas.UseVisualStyleBackColor = false;
            btnFitas.Click += btnFitas_Click;
            // 
            // btnLocacao
            // 
            btnLocacao.AccessibleName = "btnLocacao";
            btnLocacao.BackColor = Color.FromArgb(255, 176, 0);
            btnLocacao.FlatAppearance.BorderSize = 0;
            btnLocacao.FlatStyle = FlatStyle.Flat;
            btnLocacao.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocacao.ForeColor = Color.White;
            btnLocacao.Location = new Point(229, 178);
            btnLocacao.Name = "btnLocacao";
            btnLocacao.Size = new Size(121, 30);
            btnLocacao.TabIndex = 2;
            btnLocacao.Text = "📋 Locação";
            btnLocacao.UseVisualStyleBackColor = false;
            btnLocacao.Click += btnLocacao_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(255, 176, 0);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(229, 265);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(121, 30);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "👥Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(584, 361);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientes);
            Controls.Add(btnLocacao);
            Controls.Add(btnFitas);
            Controls.Add(btnFilmes);
            Name = "Form1";
            Text = "Sistema Locadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFilmes;
        private Button btnFitas;
        private Button btnLocacao;
        private Button btnClientes;
        private PictureBox pictureBox1;
    }
}
