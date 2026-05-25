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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnFilmes.Location = new Point(12, 197);
            btnFilmes.Margin = new Padding(3, 4, 3, 4);
            btnFilmes.Name = "btnFilmes";
            btnFilmes.Size = new Size(138, 40);
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
            btnFitas.Location = new Point(12, 233);
            btnFitas.Margin = new Padding(3, 4, 3, 4);
            btnFitas.Name = "btnFitas";
            btnFitas.Size = new Size(138, 40);
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
            btnLocacao.Location = new Point(12, 159);
            btnLocacao.Margin = new Padding(3, 4, 3, 4);
            btnLocacao.Name = "btnLocacao";
            btnLocacao.Size = new Size(138, 40);
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
            btnClientes.Location = new Point(12, 273);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 40);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "👥Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 176, 0);
            pictureBox2.Location = new Point(-5, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 487);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Location = new Point(12, -5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 487);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(667, 481);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientes);
            Controls.Add(btnLocacao);
            Controls.Add(btnFitas);
            Controls.Add(btnFilmes);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sistema Locadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFilmes;
        private Button btnFitas;
        private Button btnLocacao;
        private Button btnClientes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
